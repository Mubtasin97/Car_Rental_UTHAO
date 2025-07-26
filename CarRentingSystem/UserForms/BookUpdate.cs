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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentingSystem.UserForms
{
    public partial class BookUpdate : Form
    {
        private string userName;
        public BookUpdate(string loggedInUserName)
        {
            InitializeComponent();
            userName = loggedInUserName;
            label9.Text = userName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UserDashBoard userDashBoard = new UserDashBoard(userName);
            userDashBoard.Show();
            this.Close();
        }
    }
}
