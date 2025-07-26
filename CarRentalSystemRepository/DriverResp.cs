using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemRepository
{
    public class DriverResp : IDriverResp
    {
        public bool DriverAdd(CDriver c)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                   
                    //Sql query to insert driver data
                    string query = "INSERT INTO Driver (FullName, Email, Phone, LicenceNo, CarType, CarNo ,UserName, Password) " +
                                   "VALUES (@FullName, @Email, @Phone, @LicenceNo, @CarType, @CarNo ,@UserName, @Password)";



                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FullName", c.fullName);
                        command.Parameters.AddWithValue("@Email", c.email);
                        command.Parameters.AddWithValue("@Phone", c.phoneNo);
                        command.Parameters.AddWithValue("@LicenceNo", c.licenceNo);
                        command.Parameters.AddWithValue("@CarType", c.carType);
                        command.Parameters.AddWithValue("@CarNo", c.CarNo);
                        command.Parameters.AddWithValue("@UserName", c.userName);
                        command.Parameters.AddWithValue("@Password", c.password);



                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;

                        }
                        else
                        {
                            return false;
                        }
                    }


                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Sql Error: " + sqlEx.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("UserName Conflict: " + ex.Message);
                return false;

            }
            
        }
    }
}
