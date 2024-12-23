using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabSystem
{
    public class Customer : Person
    {
        public string CustomerID { get; set; }
        private string customerUsername { get; set; }
        private string customerPassword { get; set; }

        public string _customerUsername
        {
            get { return customerUsername; }
            set { customerUsername = value; }
        }

        public string _customerPassword
        {
            get { return customerPassword; }
            set { customerPassword = value; }
        }

        public int ContactNumber { get; set; }

        public List<Orders> PersonalOrders { get; set; } = new List<Orders>();

        public Customer(string customerID, string name, string customerUsername, string customerPassword, string address, int contactnumber, string gender) : base(name, address, gender)
        {
            CustomerID = customerID;
            _customerUsername = customerUsername;
            _customerPassword = customerPassword;
            ContactNumber = contactnumber;

        }


        public override string ToString()
        {
            return $"{Name}\n{Address}\n {Gender}";
        }
    }
}
