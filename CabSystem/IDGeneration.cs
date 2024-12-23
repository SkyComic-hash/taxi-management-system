using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabSystem
{
    public class IDGeneration
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        //Getting Customer Count
        public int GetCustomerCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 CustomerID FROM Customers ORDER BY CustomerID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string latestcustomer = result.ToString();
                        string numericPart = latestcustomer.Substring(3);
                        int latestCustomerID = int.Parse(numericPart);
                        return latestCustomerID;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        //Checking for Customer ID Existance
        public bool CheckIDExistance(string customerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT (*) FROM Customers WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }

        }

        //Generating Unique Customer ID
        public string GenerateCustomerID()
        {
            int latestCustomer = GetCustomerCount();
            while (CheckIDExistance("CUS" + latestCustomer.ToString("000")))
            {
                latestCustomer++;
            }
            return "CUS" + latestCustomer.ToString("000");

        }

        //Getting Drivers Count

        public int GetDriverCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 DriverID FROM Drivers ORDER BY DriverID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string latestdriver = result.ToString();
                        string numericPart = latestdriver.Substring(3);
                        int latestDriverID = int.Parse(numericPart);
                        return latestDriverID;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        //Checking Driver ID Existance
        public bool checkDriverID(string driverID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Drivers WHERE DriverID = @DriverID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        //Generating Unique Driver ID
        public string GenerateDriverID()
        {
            int latestDriver = GetDriverCount();
            while (checkDriverID("DRI" + latestDriver.ToString("000")))
            {
                latestDriver++;
            }
            return "DRI" + latestDriver.ToString("000");
        }

        //Getting Car Count

        public int GetCarCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 CarID FROM Cars ORDER BY CarID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string latestcar = result.ToString();
                        string numericPart = latestcar.Substring(3);
                        int latestcarID = int.Parse(numericPart);
                        return latestcarID;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        //Checking Car ID Existance
        public bool checkCarIDExistance(string carID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT (*) FROM Cars WHERE CarID = @CarID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CarID", carID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        //Generating Unique Car ID
        public string GenerateCarID()
        {
            int latestCar = GetCarCount();
            while (checkCarIDExistance("CAR" + latestCar.ToString("000")))
            {
                latestCar++;
            }
            return "CAR" + latestCar.ToString("000");
        }

        public int GetOrderCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string latestorder = result.ToString();
                        string numericPart = latestorder.Substring(3);
                        int latestorderID = int.Parse(numericPart);
                        return latestorderID;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        // Checking OrderID Existence
        public bool checkOrderID(string orderID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Orders WHERE OrderID = @OrderID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Generating Unique Order ID
        public string GenerateOrderID()
        {
            int latestOrder = GetOrderCount();
            while (checkOrderID("REN" + latestOrder.ToString("000")))
            {
                latestOrder++;
            }
            return "REN" + latestOrder.ToString("000");
        }



    }
}
