using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TravelAround
{
    // Login form: handles user authentication
    public partial class FrmLogin : Form
    {
        // Constructor: initializes login form UI
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Runs when user clicks Login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check for empty input fields
            if (txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all fields");
                return;
            }

            // Validate email format
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            // Hash the entered password before comparison
            // This ensures security and matches stored hashed password
            string hashedPassword = PasswordHelper.HashPassword(txtPassword.Text.Trim());

            // Open database connection
            using (var con = Db.GetConn())
            {
                con.Open();

                // SQL query to verify user credentials
                string sql = @"SELECT userID FROM tblUsers 
                               WHERE userEmail=@email AND userPassword=@pass";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", hashedPassword);

                    // Execute query and read result
                    using (var rd = cmd.ExecuteReader())
                    {
                        // If a record is found → login successful
                        if (rd.Read())
                        {
                            // Store logged-in user ID globally
                            RouteStorage.CurrentUserID = rd.GetInt32(0);

                            // Hide login form
                            this.Hide();

                            // Open main menu as modal window
                            using (var menu = new MainMenu())
                            {
                                menu.ShowDialog();
                            }

                            // Close login form after main menu exits
                            this.Close();
                        }
                        else
                        {
                            // If no record found → invalid credentials
                            MessageBox.Show("Invalid login details");
                        }
                    }
                }
            }
        }

        // Opens signup form when Signup button is clicked
        private void btnSignup_Click(object sender, EventArgs e)
        {
            new FrmSignup().ShowDialog();
        }

        // Simple email validation helper function
        private bool IsValidEmail(string email)
        {
            // Return false if email is empty
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Basic format check
            return email.Contains("@") && email.Contains(".");
        }
    }
}
