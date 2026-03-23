using MySql.Data.MySqlClient;

namespace TravelAround
{
    // Database helper class: provides MySQL connection to the entire application
    public static class Db
    {
        // Connection string for MySQL database
        // Contains server address, database name, username, and password
        // This should be changed according to environment (local/production)
        private static string cs = "server=localhost;database=travelaround;uid=root;pwd=YOUR_PASSWORD;";

        // Returns a new MySqlConnection object using the connection string
        // This method is reused across all forms and storage classes
        public static MySqlConnection GetConn()
        {
            return new MySqlConnection(cs);
        }
    }
}
