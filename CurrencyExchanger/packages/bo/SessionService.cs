using System.Linq;
using CurrencyExchanger.packages.bo.employee;
using CurrencyExchanger.packages.Models;
using CurrencyExchanger.Windows;

namespace CurrencyExchanger.packages.bo
{
    public class SessionService
    {
        private SessionService()
        {
        }

        private static SessionService _instance;

        public static SessionService GetInstance()
        {
            if (_instance == null)
                _instance = new SessionService();
            if (_instance.DbContext == null)
                _instance.DbContext = new CurrencyexchangerContext();
            return _instance;
        }

        public CurrencyexchangerContext DbContext { get; private set; }

        public  User User { get; private set; }

        public bool Authorizate(string login, string password)
        {
            var user = GetEmployeeBO.GetUserByLogin(login, password);
            if (user == null) return false;
            User = user;
            if (User.Login.Equals("ADMIN"))
            {
                var administratorWindow = new AdministratorWindow();
                administratorWindow.Show();
            }
            else
            {
                var employeeWindow = new EmployeeWindow();
                employeeWindow.Show();
            }
            return true;
        }
    }
}