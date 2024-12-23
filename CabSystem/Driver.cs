using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabSystem
{
    public class Driver : Person
    {
        public string DriverID { get; set; }

        private string driverPassword { get; set; }


        public string _driverPassword
        {
            get { return driverPassword; }
            set { driverPassword = value; }
        }
        public int ContactNumber { get; set; }
        public string Availability { get; set; }

        public Driver(string driverID, string name, string DriverPassword, string address, int contactNumber, string gender) : base(name, address, gender)
        {
            DriverID = driverID;
            _driverPassword = DriverPassword;
            ContactNumber = contactNumber;
            Availability = "Available";

        }

        public override string ToString()
        {
            return $"{Name}\n{Address}\n {Gender}";
        }
    }
}
