using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.employee
{
    public class DeleteEmployeeBO:AbstractDeleteBO
    {
        public override void Delete(int userId)
        {
            GetCurrencyexchangerContext().User.Remove(new User {UserId = userId});
            GetCurrencyexchangerContext().SaveChanges();
        }
    }
}