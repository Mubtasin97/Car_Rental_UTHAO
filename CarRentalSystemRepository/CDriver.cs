using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemRepository
{
    public class CDriver
    {
        private string FullName;
        private string Email;
        private string PhoneNo;
        private string LicenceNo;
        private string CarType;
        private string carNo;
        private string UserName;
        private string Password;


        public string fullName
        {
            set { FullName = value; }
            get { return FullName; }
        }
        public string email
        {
            set { Email = value; }
            get { return Email; }
        }
        public string phoneNo
        {
            set { PhoneNo = value; }
            get { return PhoneNo; }
        }
        public string licenceNo
        {
            set { LicenceNo = value; }
            get { return LicenceNo; }
        }
        public string carType
        {
            set { CarType = value; }
            get { return CarType; }
        }
        public string CarNo
        {
            set { carNo = value; }
            get { return carNo; }
        }
        public string userName
        {
            set { UserName = value; }
            get { return UserName; }
        }
        public string password
        {
            set { Password = value; }
            get { return Password; }
        }


    }
}
