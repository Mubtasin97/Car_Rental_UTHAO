using CarRentalSystemRepository;
using CarRentingSystem.LoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentingSystem
{
    public partial class ForgetPassword : Form
    {
        private bool forgett = false;

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetBtn_Click(object sender, EventArgs e)
        {
           
            string username = userName.TextBox;
            string email = Email.TextBox;
            

            // First, verify if the username and email exist in the database
            bool isUserValid = VerifyUser(username, email);

            if (isUserValid)
            {
                // If the user is valid, allow password update
                forgett = isUserValid;
                Email.Visible = false;
                userName.Visible = false;
                ForgetBtn.Visible = false;
                showPass.Visible = true;
                NewPassword.Visible = true;
                ConfirmPassTxt.Visible = true;
                ConfirmBtn.Visible = true;
            }
            else
            {
                // Show error message if the username or email is incorrect
                MessageBox.Show("Username or Email does not exist. Please check and try again.");
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            NewPassword.TogglePasswordVisibility(showPass.Checked);
         
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string newPassword = NewPassword.TextBox;
            string confrimpass = ConfirmPassTxt.TextBox;
            if (forgett && (newPassword == confrimpass))
            {
                UpdatePassword(userName.TextBox,Email.TextBox, NewPassword.TextBox);
                MessageBox.Show("Password Updated please login to your account");
                UserLogin uloginDb = new UserLogin();
                uloginDb.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something is wrong try again later!");
            }
            /*UserLogin uloginDb = new UserLogin();
            uloginDb.Show();
            this.Close();*/

           
        }

        private bool VerifyUser(string username, string email)
        {
            bool userExists = false;

            // Define your connection string (update it accordingly)
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            // SQL Query to check if the username and email combination exists
            string query = "SELECT COUNT(*) FROM Customer WHERE Username = @username AND Email = @userEmail";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@userEmail", email);

                try
                {
                    // Open connection
                    conn.Open();

                    // Execute the query and get the result
                    int count = (int)cmd.ExecuteScalar();

                    // If count is greater than 0, it means the user exists
                    if (count > 0)
                    {
                        userExists = true;
                    }
                }
                catch (Exception ex)
                {
                    // Handle errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return userExists;
        }
        private void UpdatePassword(string username, string email, string newPassword)
        {
            // Define your connection string (update it accordingly)
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            // SQL Query to update the password
            string updateQuery = "UPDATE Customer SET Password = @newPassword WHERE Username = @username AND Email = @userEmail";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, conn);

                // Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@userEmail", email);

                try
                {
                    // Open connection
                    conn.Open();

                    // Execute the update query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the password update was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.");
                        // Redirect to login form
                        UserLogin uloginDb = new UserLogin();
                        uloginDb.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password update failed. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            UserLogin uloginDb = new UserLogin();
            uloginDb.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
