public partial class OrderTaxiForm : Form
{
    private readonly UserModel customer;
    private readonly PricingService pricingService = new PricingService();
    private List<CarModel> availableCars;

    public OrderTaxiForm(UserModel customer)
    {
        InitializeComponent();
        this.customer = customer;
        LoadAvailableCars();
        dtpArrivalTime.MinDate = DateTime.Now.AddMinutes(30);
    }

    private void LoadAvailableCars()
    {
        // В реальном приложении получаем из базы данных
        availableCars = new List<CarModel>
        {
            new CarModel { CarId = 1, Make = "Toyota", Model = "Camry", LicensePlate = "AA1234BB" },
            new CarModel { CarId = 2, Make = "Honda", Model = "Accord", LicensePlate = "AA5678BB" }
        };
        
        cmbCars.DataSource = availableCars;
        cmbCars.DisplayMember = "LicensePlate";
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        if (cmbCars.SelectedItem is CarModel selectedCar)
        {
            // Заглушка для расстояния и времени
            decimal distance = 8.5m; // km
            decimal duration = 25m; // minutes
            
            decimal cost = pricingService.CalculatePredictedCost(
                distance, 
                duration, 
                customer.DiscountRate
            );
            
            lblPredictedCost.Text = cost.ToString("C");
        }
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        if (cmbCars.SelectedItem is CarModel selectedCar)
        {
            var order = new OrderModel
            {
                CustomerId = customer.UserId,
                CarId = selectedCar.CarId,
                StartLocation = txtFrom.Text,
                EndLocation = txtTo.Text,
                RequestedArrivalTime = dtpArrivalTime.Value,
                PredictedCost = decimal.Parse(lblPredictedCost.Text, NumberStyles.Currency)
            };
            
            new OrderService().CreateOrder(order);
            MessageBox.Show("Заказ успешно создан!");
            Close();
        }
    }
}
