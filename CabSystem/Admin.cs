using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CabSystem
{
    public class Admin : Person
    {
        public string AdminID { get; set; }

        private string adminUsername;

        private string AdminPassword;
        //Public property to access private field indirectly
        public string _adminUsername
        {
            get { return adminUsername; }
            set
            {
                adminUsername = value;
            }
        }

        public string _adminPassword
        {
            get { return AdminPassword; }
            set { AdminPassword = value; }
        }

        public Admin(string adminID, string adminusername, string adminpassword, string name, string address, string gender) : base(name, address, gender)
        {
            AdminID = adminID;
            _adminUsername = adminusername;
            _adminPassword = adminpassword;
        }
        public override string ToString()
        {
            return $"{Name}\n{Address}\n {Gender}";
        }
    }
}
