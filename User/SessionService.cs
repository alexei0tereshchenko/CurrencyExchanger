using Abstract.model;
using User.bo;

namespace User
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
                _instance.DbContext = CurrencyExchangerContext.GetInstance();
            }

            return _instance;
        }

        public CurrencyExchangerContext DbContext { get; private set; }

        public Abstract.model.User User { get; private set; }

        public int Authorizate(string login, string password)
        {
            var user = GetEmployeeBO.GetUserByLogin(login, password);
            if (user == null)
            {
                return 0;
            }
            User = user;
            return User.Login.Equals("ADMIN") ? 1 : 2;
        }
    }
}