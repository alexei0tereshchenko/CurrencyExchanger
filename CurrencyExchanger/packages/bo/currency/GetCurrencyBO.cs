using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.currency
{
    public class GetCurrencyBO : AbstractReadBO
    {
        private static GetCurrencyBO _instance;

        private GetCurrencyBO()
        {
        }

        public static GetCurrencyBO GetInstance()
        {
            return _instance ?? (_instance = new GetCurrencyBO());
        }

        public override IModel[] DoRead()
        {
            return GetCurrencyExchangerContext().Currency.ToArray();
        }

        public static Currency GetCurrencyByName(string currencyName)
        {
            if (currencyName == string.Empty)
            {
                return null;
            }

            return GetCurrencyExchangerContext().Currency
                .FirstOrDefault(currency => currency.CurrencyName.Equals(currencyName));
        }

        public static Currency GetCurrencyById(int currencyId)
        {
            return GetCurrencyExchangerContext().Currency
                .FirstOrDefault(currency => currency.CurrencyId.Equals(currencyId));
        }
    }
}