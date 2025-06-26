using System;
using System.Windows.Forms;
using CabSystem.Forms;
using CabSystem.Models;
using CabSystem.Services;

namespace CabSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Показываем форму входа
            Login loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Определяем тип пользователя и открываем соответствующую форму
                switch (loginForm.LoggedInUserType)
                {
                    case UserType.Admin:
                        Application.Run(new AdminDashboard());
                        break;
                    case UserType.Driver:
                        var driver = new DriverService().GetDriverById(loginForm.LoggedInUserId);
                        Application.Run(new DriverDashboard(driver));
                        break;
                    case UserType.Customer:
                        var customer = new UserService().GetUserById(loginForm.LoggedInUserId);
                        Application.Run(new CustomerDashboard(customer));
                        break;
                }
            }
        }
    }

    // Добавляем перечисление для типов пользователей
    public enum UserType
    {
        Admin,
        Customer,
        Driver
    }
}
