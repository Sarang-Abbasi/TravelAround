using System.Security.Cryptography;
using System.Text;

namespace TravelAround
{
    // Helper class for handling password security
    public static class PasswordHelper
    {
        // Hashes a plain text password using SHA-256
        // This ensures passwords are never stored in plain text
        public static string HashPassword(string password)
        {
            // Create a SHA256 hashing object
            using (SHA256 sha = SHA256.Create())
            {
                // Convert password string into byte array and hash it
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                // StringBuilder is used to convert byte array into hex string
                StringBuilder sb = new StringBuilder();

                // Convert each byte into hexadecimal format
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));

                // Return final hashed password as string
                return sb.ToString();
            }
        }
    }
}
