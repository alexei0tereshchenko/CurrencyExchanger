using System.Linq;
using Abstract.bo.@abstract;
using Abstract.model;

namespace Person.bo
{
    public class GetCustomerBO: AbstractReadBO
    {
        public override IModel[] DoRead()
        {
            return GetCurrencyExchangerContext().Person.ToArray();
        }
        
        public static Abstract.model.Person GetCustomerByPassportId(string passportId)
        {
            return GetCurrencyExchangerContext().Person.FirstOrDefault(p => p.PassportId.Equals(passportId));
        }

        public static Abstract.model.Person GetPersonById(int personId)
        {
            return GetCurrencyExchangerContext().Person.FirstOrDefault(p => p.PersonId.Equals(personId));
        }
    }
}