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

namespace CarRentingSystem.UserForms
{
    public partial class UserHistory : Form
    {
        private string userName;
        public UserHistory(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            label9.Text = userName;
            LoadBookingData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadBookingData()
        {
            // Define the connection string (make sure to replace it with your database connection details)
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            // SQL query to fetch booking data for the given userName
            string query = "SELECT * FROM CarBookings WHERE UserName = @UserName";

            try
            {
                // Create a connection to the database
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Open the connection
                    con.Open();

                    // Create a data adapter to execute the query
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        // Add the userName parameter to avoid SQL injection
                        adapter.SelectCommand.Parameters.AddWithValue("@UserName", userName);

                        // Create a DataTable to hold the data
                        DataTable bookingData = new DataTable();

                        // Fill the DataTable with data from the database
                        adapter.Fill(bookingData);

                        // Bind the DataTable to the DataGridView to display the data
                        dataGridView1.DataSource = bookingData;
                    }
                    // Close the connection
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("An error occurred while fetching booking data: " + ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            UserDashBoard userDash = new UserDashBoard(userName);
            userDash.Show();
            this.Hide();
        }
    }
}
