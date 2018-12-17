using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.employee
{
    public class DeleteEmployeeBO:AbstractDeleteBO
    {
        private static DeleteEmployeeBO _instance;

        private DeleteEmployeeBO()
        {
        }

        public static DeleteEmployeeBO GetInstance()
        {
            return _instance ?? (_instance = new DeleteEmployeeBO());
        }

        public override void Delete(IModel user)
        {
            GetCurrencyExchangerContext().User.Remove((User)user);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}