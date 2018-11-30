using System.Collections.Generic;

namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractUpdateBO: AbstractBO
    {
        public abstract void DoUpdate(int id, Dictionary<string, object> parameters);
    }
}