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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRentingSystem.UserForms
{
    public partial class BookCar : Form
    {
        private string userName;
        public BookCar(string loggedUser)
        {
            InitializeComponent();
            userName = loggedUser;
            NameText.Text = userName;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            UserDashBoard userDashBoard = new UserDashBoard(userName);
            userDashBoard.Show();
            this.Hide();
        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            /* PaymentForm pf = new PaymentForm(userName);
             pf.Show();
             this.Hide();*/
            // Step 1: Retrieve values from the form controls
            string fromLocation = comboBox1.SelectedItem.ToString();  // Assuming it's a ComboBox
            string toLocation = comboBox2.SelectedItem.ToString();
            DateTime pickDate = dateTimePicker1.Value;  // Assuming it's a DateTimePicker
            string carType = comboBox3.SelectedItem.ToString();  // Assuming it's a ComboBox
            string duration = comboBox4.SelectedItem.ToString();  // Assuming it's a ComboBox

            // Step 2: Define your connection string (update accordingly)
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            // Step 3:Sql query to INSERT booking information
            string insertQuery = "INSERT INTO CarBookings (UserName, FromLocation, ToLocation, PickDate, CarType, Duration, Status) " +
                                 "VALUES (@UserName, @fromLocation, @toLocation, @pickDate, @carType, @duration, @status)";

            // Step 4: Execute the query to store the data in the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(insertQuery, conn);

                // Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@fromLocation", fromLocation);
                cmd.Parameters.AddWithValue("@toLocation", toLocation);
                cmd.Parameters.AddWithValue("@pickDate", pickDate);
                cmd.Parameters.AddWithValue("@carType", carType);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@status", "Pending");

                try
                {
                    // Open connection
                    conn.Open();

                    // Execute the insert query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Show a message if the insert was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking success please pay now..");
                        PaymentForm pf = new PaymentForm(userName);
                        pf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to book the car. Please try again.");
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
