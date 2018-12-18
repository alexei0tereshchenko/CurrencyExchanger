using System.Collections.Generic;
using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.currency
{
    public class AddCurrencyBO: AbstractCreateBO
    {
        private static AddCurrencyBO _instance;

        private AddCurrencyBO()
        {
        }
        
        public static AddCurrencyBO GetInstance()
        {
            return _instance ?? (_instance = new AddCurrencyBO());
        }
        public override void DoCreate(Dictionary<string, object> parameters)
        {
            var currency = new Currency();
            foreach (var row in parameters)
            {
                if (row.Key.Equals("Sell"))
                {
                    currency.Sell = (double) row.Value;
                }

                if (row.Key.Equals("CurrencyName"))
                {
                    currency.CurrencyName = row.Value.ToString();
                }

                if (row.Key.Equals("Purchase"))
                {
                    currency.Purchase = (double) row.Value;
                }
            }
            GetCurrencyExchangerContext().Currency.Add(currency);
            GetCurrencyExchangerContext().SaveChanges();
        }

        public void CreateCurrency(Currency currency)
        {
            currency.CurrencyId = 1;
            var currencies = GetCurrencyExchangerContext().Currency.ToArray();
            
            foreach (var u in currencies)
            {
                if (u.CurrencyId == currency.CurrencyId)
                {
                    currency.CurrencyId = u.CurrencyId + 1;
                }
            }
            GetCurrencyExchangerContext().Currency.Add(currency);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}