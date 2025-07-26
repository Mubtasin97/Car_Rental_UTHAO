using CarRentalSystemRepository;
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

namespace CarRentingSystem.AdminFrames
{
    public partial class UserData : Form
    {
        private string name;
        private DataGridView dataGridViewCustomers;
        private DataGridView dataGridViewDrivers;
        public UserData(string name)
        {
            InitializeComponent();
            this.name = name;
            LoadCustomersAndDrivers();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard(name);
            adminDashboard.Show();
            this.Hide();
        }
        /*private void LoadCustomers()
        {
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                string query = "SELECT CustomerID, Name, Email, PhoneNumber FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable customerTable = new DataTable();
                adapter.Fill(customerTable);

                dataGridViewCustomers.DataSource = customerTable;
            }
        }

        private void LoadDrivers()
        {
            using (SqlConnection connection = new SqlConnection("your_connection_string"))
            {
                string query = "SELECT DriverID, Name, LicenseNumber, PhoneNumber FROM Drivers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable driverTable = new DataTable();
                adapter.Fill(driverTable);

                dataGridViewDrivers.DataSource = driverTable;
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadCustomers(); // Load customer data on form load
            LoadDrivers();   // Load driver data on form load
        }*/


        private void LoadCustomersAndDrivers()

        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Sql Query to show Customers list
                string customerQuery = @"
                SELECT 
                FullName, 
                Email, 
                Phone, 
                Address, 
                Username, 
                Password 
                FROM Customer";

                // Sql Query to show Drivers List
                string driverQuery = @"
                SELECT 
                FullName, 
                Email, 
                Phone, 
                LicenceNo, 
                CarType, 
                CarNo, 
                NID, 
                Username, 
                Password 
                FROM Driver";

                // Load Customers
                SqlDataAdapter customerAdapter = new SqlDataAdapter(customerQuery, connection);
                DataTable customerTable = new DataTable();
                customerAdapter.Fill(customerTable);

                // Add additional driver-specific columns to customer table
                customerTable.Columns.Add("LicenceNo", typeof(string));
                customerTable.Columns.Add("CarType", typeof(string));
                customerTable.Columns.Add("CarNo", typeof(string));
                customerTable.Columns.Add("NID", typeof(string));

                // Set default values for driver-specific columns in customer table
                foreach (DataRow row in customerTable.Rows)
                {
                    row["LicenceNo"] = DBNull.Value;
                    row["CarType"] = DBNull.Value;
                    row["CarNo"] = DBNull.Value;
                    row["NID"] = DBNull.Value;
                }

                // Load Drivers
                SqlDataAdapter driverAdapter = new SqlDataAdapter(driverQuery, connection);
                DataTable driverTable = new DataTable();
                driverAdapter.Fill(driverTable);

                // Add additional customer-specific columns to driver table
                driverTable.Columns.Add("Address", typeof(string));

                // Set default values for customer-specific columns in driver table
                foreach (DataRow row in driverTable.Rows)
                {
                    row["Address"] = DBNull.Value;
                }

                // Combine both tables into one DataTable
                DataTable combinedTable = customerTable.Clone(); // Create schema from customerTable

                foreach (DataRow row in customerTable.Rows)
                {
                    combinedTable.ImportRow(row); // Add customer rows
                }

                foreach (DataRow row in driverTable.Rows)
                {
                    combinedTable.ImportRow(row); // Add driver rows
                }

                // Set combined data to the DataGridView
                dataGridView1.DataSource = combinedTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      /*  private void UserData_Load(object sender, EventArgs e)
        {
            LoadCustomersAndDrivers(); // Load combined customer and driver data on form load
        }*/
    }
}
