using System.Collections.Generic;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.currency
{
    public class AddCurrencyBO: AbstractCreateBO
    {
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
    }
}