using Abstract.model;

namespace Abstract.bo.@abstract
{
    public abstract class AbstractBO
    {
        protected static CurrencyExchangerContext GetCurrencyExchangerContext()
        {
           return CurrencyExchangerContext.GetInstance();
        }
    }
}