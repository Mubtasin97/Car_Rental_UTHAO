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

namespace CarRentingSystem.DriverForms
{
    public partial class DriverUpdate : Form
    {
        private string DName;
        public DriverUpdate(string dName)
        {
            InitializeComponent();
            DName = dName;
            label2.Text = DName;
            LoadUserDetails();
            
        }
        private void LoadUserDetails()
        {
            // Step 1: Define your connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            // Step 2:Write SQL query to retrieve driver details by username
            string query = "SELECT FullName, Email, Phone, LicenceNo, NID, CarNo, CarType FROM Driver WHERE UserName = @username";

            // Step 3: Execute the query and populate the form fields
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", DName);

                try
                {
                    conn.Open();

                    // Execute the query and read the results
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Assuming you have TextBox controls to display the user details
                        textBox1.Text = reader["FullName"].ToString();
                        textBox2.Text = reader["Email"].ToString();
                        textBox3.Text = reader["Phone"].ToString();
                        textBox4.Text = reader["LicenceNo"].ToString();
                        textBox5.Text = reader["NID"].ToString();
                        textBox6.Text = reader["CarNo"].ToString();
                        textBox7.Text = reader["CarType"].ToString();
                       // textBox4.Text = reader["Address"].ToString();
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DriverDashBoard driverDashBoard = new DriverDashBoard(DName);
            driverDashBoard.Show();
            this.Hide();
        }

        private void DriverUpdateBtn_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve values from form controls
            string Name1 = textBox1.Text;
            string Email1 = textBox2.Text;
            string Phone1 = textBox3.Text;
            string LicenceNo1 = textBox4.Text;
            string NID1 = textBox5.Text;
            string CarNo1 = textBox6.Text;
            string CarType1 = textBox7.Text;

            // Step 2: Define your connection string (update accordingly)
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            //Step 3: SQL query to UPDATE driver information
            string updateQuery = "UPDATE Driver " +
                                 "SET FullName = @Name, Email = @Email, Phone = @Phone, LicenceNo = @LicenceNo,NID = @NID, CarNo = @CarNo, CarType = @CarType " +
                                 "WHERE UserName = @username";

            // Step 4: Execute the query to update the data in the database
            if (Name1 != null && LicenceNo1 != null && NID1 != null)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);

                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@username", DName);
                    cmd.Parameters.AddWithValue("@Email", Email1);
                    cmd.Parameters.AddWithValue("@Phone", Phone1);
                    cmd.Parameters.AddWithValue("@LicenceNo", LicenceNo1);
                    cmd.Parameters.AddWithValue("@NID", NID1);
                    cmd.Parameters.AddWithValue("@CarNo", CarNo1);
                    cmd.Parameters.AddWithValue("@CarType", CarType1);

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
