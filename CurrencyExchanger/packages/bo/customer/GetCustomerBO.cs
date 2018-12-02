using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.customer
{
    public class GetCustomerBO: AbstractReadBO
    {
        public static Person[] DoRead()
        {
            return GetCurrencyexchangerContext().Person.ToArray();
        }
    }
}