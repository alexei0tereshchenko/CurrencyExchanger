using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace User.bo
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
            GetCurrencyExchangerContext().User.Remove((CurrencyExchanger.packages.model.User)user);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}