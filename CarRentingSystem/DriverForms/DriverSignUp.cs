using CarRentalSystemRepository;
using CarRentingSystem.LoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarRentingSystem.DriverForms
{
    public partial class DriverSignUp : Form
    {
        public DriverSignUp()
        {
            InitializeComponent();
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
        private void cusButton1_Click(object sender, EventArgs e)
        {

            CDriver cDriver = new CDriver();
            cDriver.fullName = this.FullNameTxt.Text;
            cDriver.email = this.EmailTxt.Text;
            cDriver.phoneNo = this.PhoneTxt.Text;
            cDriver.licenceNo = this.LicenceTxt.Text;
            cDriver.carType = this.CarTypeTxt.Text;
            cDriver.CarNo = this.CarNoTxt.Text;
            cDriver.userName = this.userNameTxt.Text;
            cDriver.password = this.passwordTxt.Text;
            if (IsValidEmail(cDriver.email))
            {
                DriverResp driverResp = new DriverResp();
                bool success = driverResp.DriverAdd(cDriver);

                if (success)
                {
                    MessageBox.Show("Driver Signup successfull. Please Login");
                    UserLogin userLogin = new UserLogin();
                    userLogin.Show();
                    this.Hide();
                }
                else if(success == false)
                {
                    MessageBox.Show("Username Duplicate ditected! please try another one...");
                    DriverSignUp driverSignUp = new DriverSignUp();
                    driverSignUp.Show();
                    this.Hide();
                }
            }
            else
            {
                // Show error message
                MessageBox.Show("Invalid email address. Please enter a valid email.");
            }



        }


































        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarNoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarTypeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LicenceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }
    }
}
