using CurrencyExchanger.packages.Models;

namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractBO
    {
        public static CurrencyexchangerContext GetCurrencyexchangerContext()
        {
            return SessionService.GetInstance().DbContext;
        }
    }
}