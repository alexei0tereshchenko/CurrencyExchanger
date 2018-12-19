using System.Collections.Generic;
using Abstract.bo.@abstract;

namespace Currency.bo
{
    public class UpdateCurrencyBO:AbstractUpdateBO
    {
        private static UpdateCurrencyBO _instance;

        private UpdateCurrencyBO()
        {
        }
        
        public static UpdateCurrencyBO GetInstance()
        {
            return _instance ?? (_instance = new UpdateCurrencyBO());
        }
        
        public override void DoUpdate(int currencyId, Dictionary<string, object> parameters)
        {
            var currency = new Abstract.model.Currency {CurrencyId = currencyId};
            
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

            GetCurrencyExchangerContext().Currency.Update(currency);
            GetCurrencyExchangerContext().SaveChanges();
        }
        
        public static void UpdateCurrency(Abstract.model.Currency currency)
        {
            GetCurrencyExchangerContext().Currency.Update(currency);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}