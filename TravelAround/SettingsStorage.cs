using MySql.Data.MySqlClient;

namespace TravelAround
{
    // SettingsStorage: handles reading and writing user accessibility settings
    // from/to the tblAccessibility table in the database.
    // All methods are scoped to the currently logged-in user via RouteStorage.CurrentUserID.
    public static class SettingsStorage
    {
        // Loads the accessibility settings for the current user.
        // If no row exists yet (e.g. a brand-new account), default settings are
        // created automatically and then returned.
        public static AppSettings Load()
        {
            using (var con = Db.GetConn())
            {
                con.Open();

                string sql = @"SELECT fontSize, highContrast
                               FROM tblAccessibility
                               WHERE userID = @uid";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@uid", RouteStorage.CurrentUserID);

                    using (var rd = cmd.ExecuteReader())
                    {
                        // If a settings row exists, deserialise and return it
                        if (rd.Read())
                        {
                            return new AppSettings
                            {
                                FontSize     = rd.GetInt32("fontSize"),
                                HighContrast = rd.GetBoolean("highContrast")
                            };
                        }
                    }
                }

                // No row found – first time this user has opened the app.
                // Insert defaults and then re-call Load() to return the new row.
                CreateDefault();
                return Load();
            }
        }

        // Persists updated settings to tblAccessibility for the current user.
        // Called from FrmSettings when the user clicks Apply.
        public static void Save(int fontSize, bool highContrast)
        {
            using (var con = Db.GetConn())
            {
                con.Open();

                string sql = @"UPDATE tblAccessibility
                               SET fontSize     = @f,
                                   highContrast = @h
                               WHERE userID = @uid";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@f",   fontSize);
                    cmd.Parameters.AddWithValue("@h",   highContrast);
                    cmd.Parameters.AddWithValue("@uid", RouteStorage.CurrentUserID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Inserts a default settings row for a new user.
        // Defaults: FontSize = 3 (medium), HighContrast = false (normal mode)
        private static void CreateDefault()
        {
            using (var con = Db.GetConn())
            {
                con.Open();

                string sql = @"INSERT INTO tblAccessibility
                               (userID, fontSize, highContrast)
                               VALUES (@uid, 3, 0)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@uid", RouteStorage.CurrentUserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
