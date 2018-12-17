using CurrencyExchanger.packages.bo.employee;
using CurrencyExchanger.packages.model;
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
            {
                _instance = new SessionService();
            }

            if (_instance.DbContext == null)
            {
                _instance.DbContext = new CurrencyExchangerContext();
            }

            return _instance;
        }

        public CurrencyExchangerContext DbContext { get; private set; }

        public  User User { get; private set; }

        public bool Authorizate(string login, string password)
        {
            var user = GetEmployeeBO.GetUserByLogin(login, password);
            if (user == null)
            {
                return false;
            }
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