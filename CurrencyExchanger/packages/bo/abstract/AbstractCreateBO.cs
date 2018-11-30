using System.Collections.Generic;

namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractCreateBO: AbstractBO
    {
        public abstract void DoCreate(Dictionary<string, object> parameters);
    }
}