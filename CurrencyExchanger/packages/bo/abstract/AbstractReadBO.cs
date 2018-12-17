using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractReadBO : AbstractBO
    {
        public abstract IModel[] DoRead();
    }
    
}