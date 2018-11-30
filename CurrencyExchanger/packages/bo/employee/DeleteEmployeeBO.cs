using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.Models;

namespace CurrencyExchanger.packages.bo.employee
{
    public class DeleteEmployeeBO:AbstractDeleteBO
    {
        public override void Delete(int userId)
        {
            GetCurrencyexchangerContext().User.Remove(new User {UserId = userId});
            GetCurrencyexchangerContext().SaveChangesAsync();
        }
    }
}