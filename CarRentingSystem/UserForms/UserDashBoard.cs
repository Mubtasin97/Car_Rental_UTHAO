using CarRentalSystemRepository;
using CarRentingSystem.UserForms;
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

namespace CarRentingSystem.LoginForms
{
    public partial class UserDashBoard : Form
    {
        private string userName;
        public UserDashBoard(string loggedInUserName)
        {
            InitializeComponent();
           userName = loggedInUserName;
            label6.Text =  userName;
        }

    

    private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateDetailsBtn_Click(object sender, EventArgs e)
        {
            UserDetailesUpdate userDetailesUpdate = new UserDetailesUpdate(userName);
            userDetailesUpdate.Show();
            this.Hide();
        }

        private void bookCarBtn_Click(object sender, EventArgs e)
        {
            BookCar bookCar = new BookCar(userName);
            bookCar.Show();
            this.Hide();
        }

        private void UpdateBookingBtn_Click(object sender, EventArgs e)
        {
            BookUpdate bookUpdate = new BookUpdate(userName);
            bookUpdate.Show();
            this.Hide();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            UserHistory userHistory = new UserHistory(userName);
            userHistory.Show();
            this.Hide();
        }
    }
}
