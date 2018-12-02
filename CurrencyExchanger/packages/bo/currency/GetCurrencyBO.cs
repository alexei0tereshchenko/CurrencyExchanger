using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.currency
{
    public class GetCurrencyBO:AbstractReadBO
    {
        public Currency[] DoRead()
        {
            return GetCurrencyexchangerContext().Currency.ToArray();
        }     
    }
}