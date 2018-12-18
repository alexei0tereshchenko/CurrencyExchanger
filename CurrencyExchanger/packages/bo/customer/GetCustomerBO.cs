using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.customer
{
    public class GetCustomerBO: AbstractReadBO
    {
        public override IModel[] DoRead()
        {
            return GetCurrencyExchangerContext().Person.ToArray();
        }
        
        public static Person GetCustomerByPassportId(string passportId)
        {
            return GetCurrencyExchangerContext().Person.FirstOrDefault(p => p.PassportId.Equals(passportId));
        }
    }
}