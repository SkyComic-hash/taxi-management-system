public partial class User : Form
{
    private readonly UserModel currentUser;

    public User(UserModel user)
    {
        InitializeComponent();
        currentUser = user;
        lblWelcome.Text = $"Добро пожаловать, {user.Name}!";
    }

    // Добавляем этот метод
    private void btnOrderTaxi_Click(object sender, EventArgs e)
    {
        OrderTaxiForm orderForm = new OrderTaxiForm(currentUser);
        orderForm.Show();
    }

    // Остальные методы...
}
