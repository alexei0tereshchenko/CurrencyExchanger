using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.currency
{
    public class GetCurrencyBO:AbstractReadBO
    {
        private static GetCurrencyBO _instance;

        private GetCurrencyBO()
        {
        }

        public static GetCurrencyBO GetInstance()
        {
            return _instance ?? (_instance = new GetCurrencyBO());
        }

        public override Model[] DoRead()
        {
            return GetCurrencyexchangerContext().Currency.ToArray();
        }     
    }
}