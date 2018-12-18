using CurrencyExchanger.packages.model;
using User;

namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractBO
    {
        protected static CurrencyExchangerContext GetCurrencyExchangerContext()
        {
            return SessionService.GetInstance().DbContext;
        }
    }
}