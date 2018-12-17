using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.currency
{
    public class DeleteCurrencyBO:AbstractDeleteBO
    {
        public override void Delete(IModel currency)
        {
            GetCurrencyExchangerContext().Currency.Remove((Currency)currency);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}