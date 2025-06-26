public partial class CarManagementForm : Form
{
    private List<CarModel> cars;
    private List<DriverModel> drivers;

    public CarManagementForm()
    {
        InitializeComponent();
        LoadCars();
        LoadDrivers();
    }

    private void LoadCars()
    {
        // Загрузка автомобилей из базы данных
        cars = new List<CarModel>
        {
            new CarModel { CarId = 1, Make = "Toyota", Model = "Camry", LicensePlate = "AA1234BB" },
            new CarModel { CarId = 2, Make = "Honda", Model = "Accord", LicensePlate = "AA5678BB" }
        };
        
        dataGridViewCars.DataSource = cars;
    }

    private void LoadDrivers()
    {
        // Загрузка водителей из базы данных
        drivers = new List<DriverModel>
        {
            new DriverModel { DriverId = 1, Name = "Иван Иванов" },
            new DriverModel { DriverId = 2, Name = "Петр Петров" }
        };
        
        cmbDrivers.DataSource = drivers;
        cmbDrivers.DisplayMember = "Name";
    }

    private void btnAssignDriver_Click(object sender, EventArgs e)
    {
        if (dataGridViewCars.SelectedRows.Count > 0 && cmbDrivers.SelectedItem is DriverModel driver)
        {
            var selectedCar = (CarModel)dataGridViewCars.SelectedRows[0].DataBoundItem;
            selectedCar.DriverId = driver.DriverId;
            
            // Обновляем в базе данных
            // carService.UpdateCar(selectedCar);
            
            MessageBox.Show($"Автомобиль {selectedCar.LicensePlate} назначен водителю {driver.Name}");
        }
    }

    private void btnSetMaintenance_Click(object sender, EventArgs e)
    {
        if (dataGridViewCars.SelectedRows.Count > 0)
        {
            var selectedCar = (CarModel)dataGridViewCars.SelectedRows[0].DataBoundItem;
            using (var form = new MaintenanceForm(selectedCar))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    selectedCar.IsAvailable = false;
                    selectedCar.MaintenanceStart = form.StartDate;
                    selectedCar.MaintenanceEnd = form.EndDate;
                    
                    // Обновляем в базе данных
                    // carService.UpdateCar(selectedCar);
                    
                    MessageBox.Show("Автомобиль поставлен на обслуживание");
                }
            }
        }
    }
}
