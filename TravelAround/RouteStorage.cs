using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace TravelAround
{
    // RouteStorage: static data-access layer for all route-related database operations.
    // Centralises all SQL so no other class needs to know the schema directly.
    // All methods use parameterised queries to prevent SQL injection.
    public static class RouteStorage
    {
        // The userID of the currently logged-in user.
        // Set by FrmLogin after a successful authentication and used by every
        // query that must be scoped to a single user.
        public static int CurrentUserID = 1;

        // ─────────────────────────────────────────────────────────────────────
        // TRANSPORTS
        // ─────────────────────────────────────────────────────────────────────

        // Returns all transport types from tblTransport, sorted alphabetically.
        // Used to populate the transport ComboBox in FrmCreateRoute.
        public static List<Transport> GetTransports()
        {
            var list = new List<Transport>();

            using (var con = Db.GetConn())
            {
                con.Open();

                using (var cmd = new MySqlCommand(
                    "SELECT transportID, transportType FROM tblTransport ORDER BY transportType", con))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new Transport
                            {
                                TransportID   = rd.GetInt32(0),
                                TransportType = rd.GetString(1)
                            });
                        }
                    }
                }
            }
            return list;
        }

        // ─────────────────────────────────────────────────────────────────────
        // INSERT ROUTE
        // ─────────────────────────────────────────────────────────────────────

        // Inserts a new route into tblroutes for the current user.
        // Stops are serialised as a pipe-delimited string (e.g. "Leeds|York").
        // Returns the auto-generated routeID of the new row.
        public static int InsertRoute(Route r)
        {
            // Convert the stop list to a single pipe-delimited string;
            // store NULL in the database when there are no stops
            string stops = (r.Stops != null && r.Stops.Count > 0)
                ? string.Join("|", r.Stops)
                : null;

            int newId = 0;

            using (var con = Db.GetConn())
            {
                con.Open();

                // SELECT LAST_INSERT_ID() returns the ID generated for the INSERT
                string sql = @"
INSERT INTO tblroutes 
(userID, startLocation, endLocation, stopLocations, routeDistance, routeTime, transportID)
VALUES (@uid, @s, @e, @stops, @dist, @time, @tid);
SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@uid",   CurrentUserID);
                    cmd.Parameters.AddWithValue("@s",     r.Start);
                    cmd.Parameters.AddWithValue("@e",     r.End);
                    cmd.Parameters.AddWithValue("@stops", (object)stops ?? DBNull.Value); // NULL if no stops
                    cmd.Parameters.AddWithValue("@dist",  r.Distance);
                    cmd.Parameters.AddWithValue("@time",  r.Time);
                    cmd.Parameters.AddWithValue("@tid",   r.TransportID);

                    newId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return newId;
        }

        // ─────────────────────────────────────────────────────────────────────
        // SAVE TO SAVED ROUTES
        // ─────────────────────────────────────────────────────────────────────

        // Links an existing route to the current user's saved-routes list by
        // inserting a row into tblsavedroutes.
        // The savedName column stores a human-readable "Start → End" label.
        public static void SaveToSavedRoutes(int routeId)
        {
            using (var con = Db.GetConn())
            {
                con.Open();

                // Read the start and end locations to compose the saved name
                string routeName = "";
                using (var nameCmd = new MySqlCommand(
                    "SELECT CONCAT(startLocation,' → ',endLocation) FROM tblroutes WHERE routeID=@rid", con))
                {
                    nameCmd.Parameters.AddWithValue("@rid", routeId);
                    routeName = Convert.ToString(nameCmd.ExecuteScalar());
                }

                // Create the saved-routes entry
                using (var cmd = new MySqlCommand(
                    "INSERT INTO tblsavedroutes (userID, routeID, savedName) VALUES (@uid,@rid,@name)", con))
                {
                    cmd.Parameters.AddWithValue("@uid",  CurrentUserID);
                    cmd.Parameters.AddWithValue("@rid",  routeId);
                    cmd.Parameters.AddWithValue("@name", routeName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ─────────────────────────────────────────────────────────────────────
        // LOAD SAVED ROUTES
        // ─────────────────────────────────────────────────────────────────────

        // Returns all saved routes for the current user, joined with transport data.
        // Routes are returned newest-first (ORDER BY savedRouteID DESC).
        // The pipe-delimited stop string is split back into a List<string> here.
        public static List<Route> LoadSavedRoutes()
        {
            var routes = new List<Route>();

            using (var con = Db.GetConn())
            {
                con.Open();

                // Join tblsavedroutes → tblroutes → tbltransport so all data
                // is available in a single round trip
                string sql = @"
SELECT r.routeID, r.startLocation, r.endLocation, r.stopLocations,
       r.routeDistance, r.routeTime,
       t.transportID, t.transportType
FROM tblsavedroutes sr
JOIN tblroutes    r ON sr.routeID    = r.routeID
JOIN tbltransport t ON r.transportID = t.transportID
WHERE sr.userID = @uid
ORDER BY sr.savedRouteID DESC";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@uid", CurrentUserID);

                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            // Deserialise the pipe-delimited stop string back to a list;
                            // an empty string or NULL becomes an empty list
                            string stopText = rd.IsDBNull(3) ? "" : rd.GetString(3);
                            var stops = stopText == ""
                                ? new List<string>()
                                : stopText.Split('|').ToList();

                            routes.Add(new Route
                            {
                                RouteID     = rd.GetInt32(0),
                                Start       = rd.GetString(1),
                                End         = rd.GetString(2),
                                Stops       = stops,
                                Distance    = Convert.ToDouble(rd.GetDecimal(4)),
                                Time        = Convert.ToDouble(rd.GetDecimal(5)),
                                TransportID = rd.GetInt32(6),
                                Transport   = rd.GetString(7)
                            });
                        }
                    }
                }
            }
            return routes;
        }

        // ─────────────────────────────────────────────────────────────────────
        // UPDATE ROUTE
        // ─────────────────────────────────────────────────────────────────────

        // Updates an existing route record in tblroutes.
        // If the row was found and updated, also syncs the display name stored
        // in tblsavedroutes to reflect any change to the start/end locations.
        // Returns true if the route was updated, false if no matching row was found.
        public static bool UpdateRoute(Route r)
        {
            // Re-serialise the stop list (same format as InsertRoute)
            string stops = (r.Stops != null && r.Stops.Count > 0)
                ? string.Join("|", r.Stops)
                : null;

            using (var con = Db.GetConn())
            {
                con.Open();

                int rowsAffected;
                using (var cmd = new MySqlCommand(@"
UPDATE tblroutes
SET startLocation = @s,
    endLocation   = @e,
    stopLocations = @stops,
    routeDistance = @dist,
    routeTime     = @time,
    transportID   = @tid
WHERE routeID = @rid AND userID = @uid", con))
                {
                    cmd.Parameters.AddWithValue("@s",     r.Start);
                    cmd.Parameters.AddWithValue("@e",     r.End);
                    cmd.Parameters.AddWithValue("@stops", (object)stops ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@dist",  r.Distance);
                    cmd.Parameters.AddWithValue("@time",  r.Time);
                    cmd.Parameters.AddWithValue("@tid",   r.TransportID);
                    cmd.Parameters.AddWithValue("@rid",   r.RouteID);
                    cmd.Parameters.AddWithValue("@uid",   CurrentUserID);

                    rowsAffected = cmd.ExecuteNonQuery();
                }

                if (rowsAffected > 0)
                {
                    // Keep tblsavedroutes.savedName in sync with the new start/end
                    string newSavedName = r.Start + " → " + r.End;

                    using (var cmd2 = new MySqlCommand(@"
UPDATE tblsavedroutes
SET savedName = @name
WHERE routeID = @rid AND userID = @uid", con))
                    {
                        cmd2.Parameters.AddWithValue("@name", newSavedName);
                        cmd2.Parameters.AddWithValue("@rid",  r.RouteID);
                        cmd2.Parameters.AddWithValue("@uid",  CurrentUserID);
                        cmd2.ExecuteNonQuery();
                    }

                    return true; // Route was found and updated
                }

                return false; // No matching row; update was a no-op
            }
        }

        // ─────────────────────────────────────────────────────────────────────
        // DELETE ROUTE
        // ─────────────────────────────────────────────────────────────────────

        // Permanently removes a route from both tblsavedroutes and tblroutes.
        // The saved-routes row is deleted first to avoid a foreign-key violation.
        public static void DeleteSavedRoute(int routeId)
        {
            using (var con = Db.GetConn())
            {
                con.Open();

                // 1. Remove the saved-routes reference first (child table)
                using (var cmd = new MySqlCommand(
                    "DELETE FROM tblsavedroutes WHERE routeID=@rid AND userID=@uid", con))
                {
                    cmd.Parameters.AddWithValue("@rid", routeId);
                    cmd.Parameters.AddWithValue("@uid", CurrentUserID);
                    cmd.ExecuteNonQuery();
                }

                // 2. Remove the route record itself (parent table)
                using (var cmd2 = new MySqlCommand(
                    "DELETE FROM tblroutes WHERE routeID=@rid AND userID=@uid", con))
                {
                    cmd2.Parameters.AddWithValue("@rid", routeId);
                    cmd2.Parameters.AddWithValue("@uid", CurrentUserID);
                    cmd2.ExecuteNonQuery();
                }
            }
        }

        // ─────────────────────────────────────────────────────────────────────
        // GET CITIES
        // ─────────────────────────────────────────────────────────────────────

        // Returns all predefined city names from tblCities, sorted alphabetically.
        // Used to populate the Start, Stop, and End ComboBoxes in FrmCreateRoute.
        public static List<string> GetCities()
        {
            var list = new List<string>();

            using (var con = Db.GetConn())
            {
                con.Open();

                using (var cmd = new MySqlCommand(
                    "SELECT cityName FROM tblCities ORDER BY cityName", con))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                            list.Add(rd.GetString(0));
                    }
                }
            }

            return list;
        }

        // ─────────────────────────────────────────────────────────────────────
        // GET DISTANCE
        // ─────────────────────────────────────────────────────────────────────

        // Looks up the road distance in km between two cities from tblCityDistances.
        // The table stores each pair in both directions (A→B and B→A), so a single
        // directional lookup is sufficient.
        // Returns -1 if no matching row is found (signals "unknown distance" to callers).
        public static double GetDistance(string cityA, string cityB)
        {
            using (var con = Db.GetConn())
            {
                con.Open();

                using (var cmd = new MySqlCommand(@"
SELECT distanceKm
FROM tblCityDistances
WHERE cityA = @a AND cityB = @b
LIMIT 1", con))
                {
                    cmd.Parameters.AddWithValue("@a", cityA);
                    cmd.Parameters.AddWithValue("@b", cityB);

                    object result = cmd.ExecuteScalar();

                    // ExecuteScalar returns null when no row matches
                    if (result != null && result != DBNull.Value)
                        return Convert.ToDouble(result);
                }
            }

            return -1; // Sentinel value: distance not found in the database
        }
    }
}
