using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.Models;

namespace CurrencyExchanger.packages.bo.currency
{
    public class GetCurrencyBO:AbstractReadBO
    {
        public override Model[] DoRead()
        {
            return GetCurrencyexchangerContext().Currency.ToArray();
        }     
    }
}