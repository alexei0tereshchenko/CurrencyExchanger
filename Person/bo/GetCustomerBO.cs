using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace Person.bo
{
    public class GetCustomerBO: AbstractReadBO
    {
        public override IModel[] DoRead()
        {
            return GetCurrencyExchangerContext().Person.ToArray();
        }
        
        public static CurrencyExchanger.packages.model.Person GetCustomerByPassportId(string passportId)
        {
            return GetCurrencyExchangerContext().Person.FirstOrDefault(p => p.PassportId.Equals(passportId));
        }

        public static CurrencyExchanger.packages.model.Person GetPersonById(int personId)
        {
            return GetCurrencyExchangerContext().Person.FirstOrDefault(p => p.PersonId.Equals(personId));
        }
    }
}