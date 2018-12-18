using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace Currency.bo
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

        public static CurrencyExchanger.packages.model.Currency GetCurrencyByName(string currencyName)
        {
            if (currencyName == string.Empty)
            {
                return null;
            }

            return GetCurrencyExchangerContext().Currency
                .FirstOrDefault(currency => currency.CurrencyName.Equals(currencyName));
        }

        public static CurrencyExchanger.packages.model.Currency GetCurrencyById(int currencyId)
        {
            return GetCurrencyExchangerContext().Currency
                .FirstOrDefault(currency => currency.CurrencyId.Equals(currencyId));
        }
    }
}