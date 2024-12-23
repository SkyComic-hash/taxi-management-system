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
    public partial class AddDriver : Form
    {
        IDGeneration idGenration;
        DatabaseHelper dbHelper;
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public AddDriver()
        {
            InitializeComponent();
            idGenration = new IDGeneration();
            dbHelper = new DatabaseHelper(connectionString);
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {
            InitiateGenderBox();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        //Add Driver Button Functionality
        private void addBtn_Click(object sender, EventArgs e)
        {
            //Saving Inputs to  variables
            string driverID = idGenration.GenerateDriverID();
            string gender = gendercomboBox.SelectedItem?.ToString();
            string name = nametextBox.Text;
            string address = addresstextBox.Text;
            string password = passwordtextBox.Text;
            string contact = contacttextBox.Text;

            //Handling Errors where Inputs are not provided
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address)|| string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please Fill All the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               bool success= dbHelper.AddDrivertoDB(driverID, name, address, contact, gender, password);
                if (success)
                {
                    MessageBox.Show("Driver Added Successfully","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add driver to database. Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        
        //Initiating Gender Combo box
        private void InitiateGenderBox()
        {
            gendercomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gendercomboBox.Items.Add("Male");
            gendercomboBox.Items.Add("Female");
        }
    }
}
