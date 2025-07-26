using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemRepository
{
    public class CLogIn
    {
            private string userName;
            private string password;


        public string UserName
            {
                set { userName = value; }
                get { return userName; }
            }

            public string Password
            {
                set { password = value; }
                get { return password; }
            }

    }
}
