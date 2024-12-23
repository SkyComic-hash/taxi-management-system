using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabSystem
{
    public class DatabaseHelper
    {
        private string connectionString;
        CabRental cabRental;
        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
            cabRental = new CabRental();
        }

        //Adding Customers to Database
        public bool RegisterCustomer(string customerID,string name, string address, string gender, string username, string password,int contact)
        {
            LoginValidations loginValidations = new LoginValidations();
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Customers (CustomerID, CustomerName, CustomerUsername, CustomerPassword, CustomerAddress, CustomerContact, Gender)" +
                        "VALUES (@CustomerID, @CustomerName, @CustomerUsername, @CustomerPassword, @CustomerAddress, @CustomerContact, @Gender)";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@CustomerName", name);
                        command.Parameters.AddWithValue("@CustomerUsername", username);
                        command.Parameters.AddWithValue("@CustomerPassword", password);
                        command.Parameters.AddWithValue("@CustomerAddress", address);
                        command.Parameters.AddWithValue("@CustomerContact", contact);
                        command.Parameters.AddWithValue("@Gender", gender);

                        if (loginValidations.CheckUsername(username)){
                            MessageBox.Show("Username is already taken. Please Choose another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            int result = command.ExecuteNonQuery();

                            return result > 0;

                        }

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        //Getting Customers by Username
        public string GetCustomerNameByUsername(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CustomerName FROM Customers WHERE CustomerUserName = @CustomerUsername";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerUsername", username);
                        object result = command.ExecuteScalar();
                        return result?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Adding Drivers to Database
        public bool AddDrivertoDB(string driverID, string name, string address, string contact, string gender, string password)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Drivers (DriverID, DriverName, DriverPassword, DriverAddress, DriverContact, DriverGender)" +
                        "VALUES (@DriverID, @DriverName, @DriverPassword, @DriverAddress, @DriverContact, @DriverGender)";
                    using(SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", driverID);
                        command.Parameters.AddWithValue("@DriverName", name);
                        command.Parameters.AddWithValue("@DriverPassword", password);
                        command.Parameters.AddWithValue("@DriverAddress", address);
                        command.Parameters.AddWithValue("@DriverContact", contact);
                        command.Parameters.AddWithValue("@DriverGender", gender);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Removing Driver from Database
        public bool RemoveDriverFromDB(string driverID)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string delQuery = "DELETE FROM Drivers WHERE DriverID = @DriverID";
                    using(SqlCommand command = new SqlCommand(delQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", driverID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool RemoveCustomerFromDB(string customerID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string delQuery = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                    using (SqlCommand command = new SqlCommand(delQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Adding Vehicle To Database
        public bool AddVehicleToDB(string vehicleID, string make, string model, string type, string fuelType, string plateNo, string year, int cost)
        {
            try
            {
                using(SqlConnection connection=new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Cars (CarID, Make, FuelType, VehicleType, Model, PlateNumber, ManufactureYear, Cost)" +
                        "VALUES (@CarID, @Make, @FuelType, @VehicleType, @Model, @PlateNumber, @ManufactureYear, @Cost)";
                    using(SqlCommand command=new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CarID", vehicleID);
                        command.Parameters.AddWithValue("@Make", make);
                        command.Parameters.AddWithValue("@FuelType", fuelType);
                        command.Parameters.AddWithValue("@VehicleType", type);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@PlateNumber", plateNo);
                        command.Parameters.AddWithValue("@ManufactureYear", year);
                        command.Parameters.AddWithValue("@Cost", cost);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Removing Vehicle From Database
        public bool RemoveVehicle(string vehicleID)
        {
            try
            {
                using(SqlConnection connection=new SqlConnection(connectionString))
                {
                    connection.Open();
                    string delQuery = "DELETE FROm Cars WHERE CarID = @CarID";
                    using(SqlCommand command = new SqlCommand(delQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CarID", vehicleID);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RemoveOrder(string orderID)
        {
            using(SqlConnection  conn=new SqlConnection(connectionString))
            {
                conn.Open();
                string delQuery = "DELETE FROM Orders WHERE OrderID = @OrderID";
                using(SqlCommand command = new SqlCommand( delQuery, conn))
                {
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    int rowAffect = command.ExecuteNonQuery();
                    if(rowAffect > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        //Adding Orders into Database
        public bool AddOrdersToDatabase(Orders orders)
        {
            string query = "INSERT INTO Orders (OrderID, CustomerID, CustomerName, DriverID, CarID, Destination, StartDate, EndDate)" +
                "VALUES (@OrderID, @CustomerID, @CustomerName, @DriverId, @CarID, @Destination, @StartDate, @EndDate)";
            try
            {
                using(SqlConnection  conn=new SqlConnection(connectionString))
                {
                    conn.Open();
                    using(SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@OrderID", orders.OrderID);
                        command.Parameters.AddWithValue("@CustomerID", orders.CustomerID);
                        command.Parameters.AddWithValue("@CustomerName", orders.CustomerName);
                        command.Parameters.AddWithValue("@DriverID", orders.DriverID);
                        command.Parameters.AddWithValue("@CarID", orders.CarID);
                        command.Parameters.AddWithValue("@Destination", orders.Location);
                        command.Parameters.AddWithValue("@StartDate", orders.Start_Date);
                        command.Parameters.AddWithValue("@EndDate", orders.End_Date);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Update Car Status After Booking
        public void UpdateCarStatus(Vechicle vechicle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Cars SET CarStatus = @CarStatus WHERE CarID = @CarID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CarStatus", vechicle.Availability);
                        command.Parameters.AddWithValue("@CarID", vechicle.CarID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update car status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Update Driver Status after Booking
        public void UpdateDriverStatus(Driver driver)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Drivers SET DriverStatus = @DriverStatus WHERE DriverID = @DriverID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DriverStatus", driver.Availability);
                        command.Parameters.AddWithValue("@DriverID", driver.DriverID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update car status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Update Order Status
        public void UpdateOrderStatus(Orders orders)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Orders SET OrderStatus = @OrderStatus WHERE OrderID = @OrderID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderStatus", orders.OrderStatus);
                        command.Parameters.AddWithValue("@OrderID", orders.OrderID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update order status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
