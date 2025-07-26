using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemRepository
{

    public class CustomerResp :ICustomer
    {

        public bool CustomerAdd(CCustomer c)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\car.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    //SqlTransaction transaction = connection.BeginTransaction();

                    //Sql query to insert customer information
                    string query = "INSERT INTO Customer (FullName, Email, Phone,UserName, Password) " +
                                   "VALUES (@FullName, @Email, @Phone,@UserName, @Password)";
                  
                   /* string query1 = "INSERT INTO LoginTable (UserName, Password,Type) " +
                                   "VALUES (@UserName, @Password,@Type)";*/

                    /*


                                        SqlCommand customerCmd = new SqlCommand(query, connection, transaction);

                                        customerCmd.Parameters.AddWithValue("@FullName", c.Name);
                                        customerCmd.Parameters.AddWithValue("@Email", c.Email);
                                        customerCmd.Parameters.AddWithValue("@Phone", c.Phone);
                                        customerCmd.Parameters.AddWithValue("@UserName", c.UserName);
                                        customerCmd.Parameters.AddWithValue("@Password", c.Password);


                                        // Execute and retrieve CustomerID
                                        int customerId = Convert.ToInt32(customerCmd.ExecuteScalar());

                                        // Insert into Login table with the CustomerID


                                        SqlCommand loginCmd = new SqlCommand(query1, connection, transaction);

                                        loginCmd.Parameters.AddWithValue("@UserName", c.UserName);
                                        loginCmd.Parameters.AddWithValue("@Password", c.Password);
                                        loginCmd.Parameters.AddWithValue("@Type", c.Type);

                                        loginCmd.ExecuteNonQuery();

                                        // Commit the transaction
                                        transaction.Commit();

                                        return true;*/


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FullName", c.Name);
                        command.Parameters.AddWithValue("@Email", c.Email);
                        command.Parameters.AddWithValue("@Phone", c.Phone);
                        command.Parameters.AddWithValue("@UserName", c.UserName);
                        command.Parameters.AddWithValue("@Password", c.Password);

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

            /* try
             {
                // string query = "INSERT INTO Customer (FullName, Email, Phone, UserName, Password) VALUES ('@id="c.Name", @name, @salary)"; ;
                 string query2 = "INSERT into LoginTable VALUES ('" + c.Name + "','" + c.Password + "', " + c.Type + ")";
                 DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                 dcc.ConnectWithDB();
                // int x = dcc.ExecuteSQL(query);
                 int y = dcc.ExecuteSQL(query2);
                 dcc.CloseConnection();
                 return true;

             }
             catch (Exception ex)
             {
                 return false;
             }*/
        }
    }
}
