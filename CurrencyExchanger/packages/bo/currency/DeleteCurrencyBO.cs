using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.currency
{
    public class DeleteCurrencyBO:AbstractDeleteBO
    {
        public override void Delete(IModel currency)
        {
            GetCurrencyexchangerContext().Currency.Remove((Currency)currency);
            GetCurrencyexchangerContext().SaveChanges();
        }
    }
}