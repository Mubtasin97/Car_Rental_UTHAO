using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemRepository
{
    public class LoginClass
    {
        public bool UserLoginValidation(CLogIn C)
        {
            //string query = "SELECT * from Customer WHERE Id = '" + C.UserName + "' AND Password='" + C.Password + "'";
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to check if the Customer username and password match
                    string query = "SELECT COUNT(1) FROM Customer WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", C.UserName);
                        cmd.Parameters.AddWithValue("@Password", C.Password);

                        return true;
                    }
                }
            }
            catch (Exception ex) { 
                return false;
            }
            
            /* DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                C.UserName = sdr["UserName"].ToString();
                C.Type = Convert.ToInt32(sdr["Type"]);
                dcc.CloseConnection();
                return true;
            }
            else
            {
                dcc.CloseConnection();
                return false;
            }*/
        }
        public bool UserLoginValidationDriver(CLogIn C)
        {
            //string query = "SELECT * from Customer WHERE Id = '" + C.UserName + "' AND Password='" + C.Password + "'";
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query to check if the driver username and password match
                    string query = "SELECT COUNT(1) FROM Driver WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", C.UserName);
                        cmd.Parameters.AddWithValue("@Password", C.Password);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            /* DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            if (sdr.Read())
            {
                C.UserName = sdr["UserName"].ToString();
                C.Type = Convert.ToInt32(sdr["Type"]);
                dcc.CloseConnection();
                return true;
            }
            else
            {
                dcc.CloseConnection();
                return false;
            }*/
        }
    }
}
