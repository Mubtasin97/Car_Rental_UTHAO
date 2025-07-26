using CarRentalSystemRepository;
using CarRentingSystem.LoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentingSystem.AdminFrames
{
    public partial class AdminDashboard : Form
    {
        private string adminUser;
        public AdminDashboard(string AdminUser)
        {
            InitializeComponent();
            
            this.adminUser = AdminUser;
            label6.Text = adminUser;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void cusButton2_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData(adminUser);
            userData.Show();
            this.Hide();
        }

        private void cusButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is under construction");
        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is under construction");
        }

        private void cusButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is under construction");
        }
    }
}
