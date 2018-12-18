using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace User.bo
{
    public class GetEmployeeBO:AbstractReadBO
    {
        private static GetEmployeeBO _instance;

        private GetEmployeeBO()
        {
        }

        public static GetEmployeeBO GetInstance()
        {
            return _instance ?? (_instance = new GetEmployeeBO());
        }

        public override IModel[] DoRead()
        {
            return GetCurrencyExchangerContext().User.ToArray();
        }
        
        public static CurrencyExchanger.packages.model.User GetUserByLogin(string login, string password)
        {
            var user = GetCurrencyExchangerContext().User.FirstOrDefault(u => u.Login.Equals(login));
            return user != null && user.Password.Equals(password) ? user : null;
        }

        public static CurrencyExchanger.packages.model.User GetUserById(int userId)
        {
            return GetCurrencyExchangerContext().User.FirstOrDefault(u => u.UserId.Equals(userId));
        }
    }
}