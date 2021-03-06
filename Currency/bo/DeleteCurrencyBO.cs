

using Abstract.bo.@abstract;
using Abstract.model;

namespace Currency.bo
{
    public class DeleteCurrencyBO:AbstractDeleteBO
    {
        private static DeleteCurrencyBO _instance;

        private DeleteCurrencyBO()
        {
        }

        public static DeleteCurrencyBO GetInstance()
        {
            return _instance ?? (_instance = new DeleteCurrencyBO());
        }

        public override void Delete(IModel currency)
        {
            GetCurrencyExchangerContext().Currency.Remove((Abstract.model.Currency)currency);
            GetCurrencyExchangerContext().SaveChanges();
        }

        public void DeleteCurrencyByName(string currencyName)
        {
            if (currencyName == string.Empty) return;
            var currency = GetCurrencyBO.GetCurrencyByName(currencyName);
            if (currency==null) return;
            Delete(currency);
        }
    }
}