using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.currency
{
    public class DeleteCurrencyBO:AbstractDeleteBO
    {
        public override void Delete(int currencyId)
        {
            GetCurrencyexchangerContext().Currency.Remove(new Currency{CurrencyId = currencyId});
            GetCurrencyexchangerContext().SaveChanges();
        }
    }
}