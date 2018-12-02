using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractBO
    {
        protected static CurrencyexchangerContext GetCurrencyexchangerContext()
        {
            return SessionService.GetInstance().DbContext;
        }
    }
}