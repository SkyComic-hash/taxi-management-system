using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabSystem
{
    public partial class AddCar : Form
    {

        IDGeneration idGenration;
        DatabaseHelper dbHelper;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public AddCar()
        {
            InitializeComponent();
            idGenration = new IDGeneration();
            dbHelper = new DatabaseHelper(connectionString);
        }
        //Initiating Combo Boxes
        private void InitiateComboBox()
        {
            //FuelType ComboBox
            fuelcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fuelcomboBox.Items.Add("Petrol");
            fuelcomboBox.Items.Add("Diesel");
            fuelcomboBox.Items.Add("Electric");
            fuelcomboBox.Items.Add("Hybrid");

            //Vehicle Type ComboBox

            VehiclecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            VehiclecomboBox.Items.Add("Car");
            VehiclecomboBox.Items.Add("Van");
            VehiclecomboBox.Items.Add("Pick Up Truck");
            VehiclecomboBox.Items.Add("Mini Van");
            VehiclecomboBox.Items.Add("Crossover SUV");
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            InitiateComboBox();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Close();
            adminDashboard.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string vehicleID = idGenration.GenerateCarID();
            string make = nametextBox.Text;
            string model = modelTxt.Text;
            string type = VehiclecomboBox.SelectedItem?.ToString();
            string FuelType = fuelcomboBox.SelectedItem?.ToString();
            string plateNo = platetext.Text;
            string year = yeartext.Text;
            int cost;
            if(!int.TryParse(costText.Text, out cost))
            {
                MessageBox.Show("Invalid Cost. Please Enter Numerical Values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(string.IsNullOrEmpty(make) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(FuelType) || string.IsNullOrEmpty(plateNo) || string.IsNullOrEmpty(year))
            {
                MessageBox.Show("Please Fill All the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool carAdded = dbHelper.AddVehicleToDB(vehicleID, make, model, type, FuelType, plateNo, year, cost);
                if(carAdded)
                {
                    MessageBox.Show("Vehicle Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add Vehicle to database. Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
