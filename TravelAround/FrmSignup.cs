using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TravelAround
{
    // Signup form: handles new user registration
    public partial class FrmSignup : Form
    {
        // Constructor: initializes the signup form UI
        public FrmSignup()
        {
            InitializeComponent();
        }

        // Runs when user clicks the Signup button
        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Validate empty fields
            if (txtName.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" ||
                txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("All fields are required");
                return; // Stop execution if validation fails
            }

            // Validate email format
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            // Enforce minimum password length for security
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long");
                return;
            }

            // Open database connection
            using (var con = Db.GetConn())
            {
                con.Open();

                // 🔎 1. Check if username already exists
                using (var checkUserCmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM tblUsers WHERE userName=@name", con))
                {
                    checkUserCmd.Parameters.AddWithValue("@name", txtName.Text.Trim());

                    int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());
                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists");
                        return;
                    }
                }

                // 🔎 2. Check if email is already registered
                using (var checkEmailCmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM tblUsers WHERE userEmail=@email", con))
                {
                    checkEmailCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                    int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());
                    if (emailCount > 0)
                    {
                        MessageBox.Show("Email already registered");
                        return;
                    }
                }

                // 🔐 3. Hash password before saving to database
                // This protects user passwords from being stored in plain text
                string hashedPassword = PasswordHelper.HashPassword(txtPassword.Text.Trim());

                // Insert new user record into database
                using (var insertCmd = new MySqlCommand(
                    "INSERT INTO tblUsers (userName, userEmail, userPassword) VALUES (@name,@email,@pass)", con))
                {
                    insertCmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@pass", hashedPassword);

                    insertCmd.ExecuteNonQuery(); // Execute INSERT query
                }

                // Notify user of successful registration
                MessageBox.Show("Account created successfully!");

                // Close signup form and return to login
                this.Close();
            }
        }

        // Back button click: closes signup form without saving
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Simple email validation method
        private bool IsValidEmail(string email)
        {
            // Check for null or empty email
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Basic format check
            return email.Contains("@") && email.Contains(".");
        }
    }
}
