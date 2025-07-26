using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemRepository
{
    public class CCustomer
    {
        private string userName;
        private string name;
        private string email;
        private string phone;
        private string password;
        private int type;

        public string UserName
        {
            set { userName = value; }
            get { return userName; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public string Phone
        {
            set { phone = value; }
            get { return phone; }
        }

    }
}
