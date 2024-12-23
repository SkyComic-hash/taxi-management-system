using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CabSystem
{
    public class CabRental
    {

        public List<Customer> Customers { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Vechicle> Cars { get; set; }
        public List<Orders> Orders { get; set; }


        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public CabRental()
        {
            Customers = LoadCustomersFromDB();
            Orders = LoadOrdersFromDB();
            Cars = LoadCarsFromDB();
            Drivers = LoadDriversFromDB();
            
        }


        //Loading Customers Into a List
        public List<Customer> LoadCustomersFromDB()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Customer customer = new Customer(reader["CustomerID"].ToString(), reader["CustomerName"].ToString(), reader["CustomerUsername"].ToString(), reader["CustomerPassword"].ToString(), reader["CustomerAddress"].ToString(), Convert.ToInt32(reader["CustomerContact"].ToString()), reader["Gender"].ToString());
                        customers.Add(customer);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return customers;
        }
        //Loading Orders into a List
        public List<Orders> LoadOrdersFromDB()
        {
            List<Orders> orders = new List<Orders>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Orders", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Orders order = new Orders(reader["OrderID"].ToString(), reader["CustomerID"].ToString(), reader["CustomerName"].ToString(), reader["DriverID"].ToString(), reader["CarID"].ToString(), reader["Destination"].ToString(), Convert.ToDateTime(reader["StartDate"].ToString()), Convert.ToDateTime(reader["EndDate"].ToString()))
                        {
                            OrderStatus = reader["OrderStatus"].ToString()
                        };
                        orders.Add(order);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orders;
        }

        //Loading Cars from Database into a List

        public List<Vechicle> LoadCarsFromDB()
        {
            List<Vechicle> cars = new List<Vechicle>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Cars", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Vechicle car = new Vechicle(reader["CarID"].ToString(), reader["Make"].ToString(), reader["FuelType"].ToString(), reader["VehicleType"].ToString(), reader["Model"].ToString(), reader["PlateNumber"].ToString(), Convert.ToInt32(reader["ManufactureYear"].ToString()), Convert.ToInt32(reader["Cost"].ToString()))
                        {
                            Availability = reader["CarStatus"].ToString()
                        };
                        cars.Add(car);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cars;
        }

        //Load Drivers from Database into a list

        public List<Driver> LoadDriversFromDB()
        {
            List<Driver> drivers = new List<Driver>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Drivers", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Driver driver = new Driver(reader["DriverID"].ToString(), reader["DriverName"].ToString(), reader["DriverPassword"].ToString(), reader["DriverAddress"].ToString(), Convert.ToInt32(reader["DriverContact"].ToString()), reader["DriverGender"].ToString())
                        {
                            Availability = reader["DriverStatus"].ToString()
                        };
                        drivers.Add(driver);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return drivers;
        }


        //Loading Customers to Datatable

        public DataTable LoadCustomersToTable()
        {
            DataTable customers = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CustomerID, CustomerName, CustomerAddress, CustomerContact, Gender FROM Customers";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        customers.Load(reader);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return customers;
        }

        //Loading Vehicles to DataTable

        public DataTable LoadVehiclesToTable()
        {
            DataTable vehicles = new DataTable();
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CarID, Make, Model, FuelType, VehicleType, CarStatus, Cost FROM Cars";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        vehicles.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vehicles;
        }

   

        //Loading Drivers to DataTable
        public DataTable LoadDriversTotable()
        {
            DataTable drivers = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DriverID, DriverName, DriverAddress, DriverContact, DriverGender, DriverStatus FROM Drivers";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        drivers.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return drivers;
        }

        //Loading Orders to DataTable
        public DataTable LoadingOrdersToTable()
        {
            DataTable orders = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT OrderID, CustomerID, CustomerName, DriverID, CarID, Destination, StartDate, EndDate, OrderStatus FROM Orders";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        orders.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return orders;
        }

        //Extracting Orders Specific to Log in Customer
        public List<Orders>GetCustomerOrders(string customerId)
        {
            return Orders.Where(order=>order.CustomerID == customerId).ToList();
        }

        //Checking if Customer has On going order
        public bool CheckingCustomerOrder(string customerId)
        {
            return Orders.Any(o=> o.CustomerID == customerId && o.OrderStatus == "On Going");
        }

        //Checking if Driver has On going Orders
        public bool CheckingDriverOrders(string driverId)
        {
            return Orders.Any(o=>o.DriverID == driverId && o.OrderStatus == "On Going");
        }

        //Checking if Vehicle is on Active Order
        public bool CheckVehicleOrders(string vehicleId)
        {
            return Orders.Any(o=>o.CarID == vehicleId && o.OrderStatus == "On Going");
        }

        //Checking Car Availability
        public bool CarAvailability(string carID)
        {
            try
            {
                string query = "SELECT CarStatus FROM Cars WHERE CarID = @CarID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarID", carID);
                        string availability = (string)command.ExecuteScalar();
                        return availability == "Booked";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to check car status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Checking Driver Availability
        public bool DriverAvailability(string driverId)
        {
            try
            {
                string query = "SELECT DriverStatus FROM Drivers WHERE DriverID = @DriverID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", driverId);
                        string availability = (string)command.ExecuteScalar();
                        return availability == "Booked";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to check car status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        

    }
}
