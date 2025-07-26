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

namespace CarRentingSystem.DriverForms
{
    
    public partial class DriverDashBoard : Form
    {
        private string DName;
        public DriverDashBoard(string dName)
        {
            InitializeComponent();
            DName = dName;
            label2.Text = DName;
        }

        private void cusButton1_Click(object sender, EventArgs e)
        {
            DriverUpdate driverUpdate = new DriverUpdate(DName);
            driverUpdate.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }
    }
}
