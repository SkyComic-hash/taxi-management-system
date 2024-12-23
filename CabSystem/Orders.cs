using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabSystem
{
    public class Orders
    {
        public string OrderID { get; set; }
        public string CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string DriverID { get; set; }

        public string CarID { get; set; }

        public string Location { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_Date { get; set; }

     
        public string OrderStatus { get; set; }

        public static List<Orders> AllOrders { get; set; } = new List<Orders>();

        public Orders(string orderID, string customerID, string customerName, string driverID, string carID, string location, DateTime start_Date, DateTime end_Date)
        {
            OrderID = orderID;
            CustomerID = customerID;
            CustomerName = customerName;
            DriverID = driverID;
            CarID = carID;
            Location = location;
            Start_Date = start_Date;
            End_Date = end_Date;
            OrderStatus = "On Going";
       
        }
    }
}
