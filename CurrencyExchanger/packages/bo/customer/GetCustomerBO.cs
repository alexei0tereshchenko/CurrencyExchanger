using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.Models;

namespace CurrencyExchanger.packages.bo.customer
{
    public class GetCustomerBO: AbstractReadBO
    {
        public override Model[] DoRead()
        {
            return GetCurrencyexchangerContext().Person.ToArray();
        }
    }
}