using CarRentalSystemRepository;
using CarRentingSystem.DriverForms;
using CarRentingSystem.LoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentingSystem
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }


        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FullName_Load(object sender, EventArgs e)
        {

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            userPass.TogglePasswordVisibility(ShowPass.Checked);
            if (ShowPass.Checked == true)
            {
                ShowPass.Text = "Hide Password";
            }
            else
            {
                ShowPass.Text = "Show Password";
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Check if email matches the pattern
            if (Regex.IsMatch(email, pattern))
            {
                return true;  // Valid email
            }
            return false;  // Invalid email
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            String fName = FullName.TextBox;
            String email = emailAdd.TextBox;
            String Ph = PhoneNo.TextBox;
            String userN = userName.TextBox;
            String userP = userPass.TextBox;
            //MessageBox.Show(fName);
            if (IsValidEmail(email))
            {
                // Proceed with signup process
                // MessageBox.Show("Email is valid. Proceeding with signup...");
                CCustomer c = new CCustomer();
                c.Name = fName;
                c.Email = email;
                c.Phone = Ph;
                c.UserName = userN;
                c.Password = userP;

                CustomerResp customerResp = new CustomerResp();

                bool success = customerResp.CustomerAdd(c);

                if (success)
                {
                    MessageBox.Show("User Signup successfull. Please Login");
                    UserLogin userLogin = new UserLogin();
                    userLogin.Show();
                    this.Hide();
                }
                else if(success==false) 
                {
                        MessageBox.Show("Username Duplicate ditected! please try another one...");
                        SignUp signUp = new SignUp();
                        signUp.Show();
                        this.Hide();
                }

            }
            else
            {
                // Show error message
                MessageBox.Show("Invalid email address. Please enter a valid email.");
            }

       







        }
       
    }
}