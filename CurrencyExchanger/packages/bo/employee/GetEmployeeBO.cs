using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.Models;

namespace CurrencyExchanger.packages.bo.employee
{
    public class GetEmployeeBO:AbstractReadBO
    {
        public override Model[] DoRead()
        {
            return GetCurrencyexchangerContext().User.ToArray();
        }

        public static User GetUserByLogin(string login, string password)
        {
            var user = GetCurrencyexchangerContext().User.FirstOrDefault(u => u.Login.Equals(login));
            return user != null && user.Password.Equals(password) ? user : null;
        }

        public static User GetUserById(int userId)
        {
            return GetCurrencyexchangerContext().User.FirstOrDefault(u => u.UserId.Equals(userId));
        }
    }
}