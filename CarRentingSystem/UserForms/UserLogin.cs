using CarRentalSystemRepository;
using CarRentingSystem.DriverForms;
using CarRentingSystem.UserForms;
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

namespace CarRentingSystem.LoginForms
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void cusButton1_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void ForgetPass_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
            this.Hide();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            LoginDb loginDb = new LoginDb();
            loginDb.Show();
            this.Hide();
        }

        private void ForgetPass_Click_1(object sender, EventArgs e)
        {
            ForgetPassword forgetPass = new ForgetPassword();
            forgetPass.Show();
            this.Hide();
        }

        private void CreateAcc_Click(object sender, EventArgs e)
        {
            SignUpBtn signupBtn = new SignUpBtn();
            signupBtn.Show();
            this.Hide();
        }

        private void ShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            passwordbox.TogglePasswordVisibility(ShowPassWord.Checked);
            if (ShowPassWord.Checked == true)
            {
                ShowPassWord.Text = "Hide Password";
            }
            else
            {
                ShowPassWord.Text = "Show Password";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginDb loginDb =new LoginDb();
            loginDb.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DriverS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            CLogIn cLogIn = new CLogIn();
            cLogIn.UserName = this.userName.TextBox;
            cLogIn.Password = this.passwordbox.TextBox;
            // customerLogin(userName.TextBox, passwordbox.TextBox);
            LoginClass loginClass = new LoginClass();
            if (CustomerRadio.Checked == true)
            {
                    if (cLogIn != null || loginClass.UserLoginValidation(cLogIn))
                    {
                       
                            UserDashBoard userDashBoard = new UserDashBoard(userName.TextBox);
                            userDashBoard.Show();
                            this.Hide();
 
                    }
            }else if(DriverS.Checked == true)
            {
                    if (cLogIn != null || loginClass.UserLoginValidationDriver(cLogIn))
                    {
                  
                            DriverDashBoard driverDashBoard = new DriverDashBoard(userName.TextBox);
                            driverDashBoard.Show();
                            this.Hide();
                        
                    
                    }
                
            }
        }

        public void customerLogin(string UserName,string UserPassword)
        {
            
        /*{
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nazrul Islam\Documents\CarRentingSystem.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM RegistrationTable WHERE Username=@Username AND Password=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", UserName);
                        cmd.Parameters.AddWithValue("@Password", UserPassword);

                        int result = (int)cmd.ExecuteScalar();

                        if (result == 1)
                        {
                            MessageBox.Show("Login successful!");
                            UserDashBoard userDashBoard = new UserDashBoard(UserName);
                            userDashBoard.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }*/
        }
       


    }
}
