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

namespace CarRentingSystem.UserForms
{
    public partial class UserDetailesUpdate : Form
    {
        private string username;
        public UserDetailesUpdate(string loggeduser)
        {
            InitializeComponent();
            username = loggeduser;
            LoadUserDetails();
            //PasswordUpdateTextBox.Text = "*************";
        }
        private void LoadUserDetails()
        {
            // Step 1: Define your connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            // Step 2: Write SQL query to retrieve user details by username
            string query = "SELECT FullName, Email, Phone,Password ,Address FROM Customer WHERE UserName = @username";

            // Step 3: Execute the query and populate the form fields
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                try
                {
                    conn.Open();

                    // Execute the query and read the results
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you have TextBox controls to display the user details
                        NameUpdateTextBox.Text = reader["FullName"].ToString();
                        EmailUpdateTextBox.Text = reader["Email"].ToString();
                        PhoneUpdateTextBox.Text = reader["Phone"].ToString();
                        PasswordUpdateTextBox.Text = reader["Password"].ToString();
                        AddressUpdateTextBox.Text = reader["Address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserDashBoard userDashBoard = new UserDashBoard(username);
            userDashBoard.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cusButton1_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve values from form controls
            string Name = NameUpdateTextBox.Text;
            string Email = EmailUpdateTextBox.Text;
            string Phone  = PhoneUpdateTextBox.Text;
            string Address = AddressUpdateTextBox.Text;
            string password = PasswordUpdateTextBox.Text;

            // Step 2: Define your connection string (update accordingly)
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            // Step 3: Write the UPDATE SQL query
            string updateQuery = "UPDATE Customer " +
                                 "SET FullName = @FullName, Email = @Email, Phone = @Phone, Address = @Address " +
                                 "WHERE UserName = @Username";

            // Step 4: Execute the query to update the data in the database
           if(Name != null && Address !=null && password !=null)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);

                    // Add parameters to avoid SQL injection
                    /* cmd.Parameters.AddWithValue("@Username", username);
                     cmd.Parameters.AddWithValue("@UserName", username);*/
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@FullName", Name);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        // Open connection
                        conn.Open();

                        // Execute the update query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Show a message if the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No user found with the provided UserID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
          
        }
    }
}
