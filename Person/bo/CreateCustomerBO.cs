using System;
using System.Collections.Generic;
using System.Linq;
using Abstract.bo.@abstract;

namespace Person.bo
{
    public class CreateCustomerBO : AbstractCreateBO
    {
        public override void DoCreate(Dictionary<string, object> parameters)
        {
            var person1 = new Abstract.model.Person();
            var person = person1;
                        
            foreach (var row in parameters)
            {
                if (row.Key.Equals("FirstName"))
                {
                    person.FirstName = row.Value.ToString();
                }

                if (row.Key.Equals("LastName"))
                {
                    person.FirstName = row.Value.ToString();
                }

                if (row.Key.Equals("BirthDate"))
                {
                    person.BirthDate = (DateTime?) row.Value;
                }

                if (row.Key.Equals("PassportSeries"))
                {
                    person.PassportSeries = row.Value.ToString();
                }

                if (row.Key.Equals("PassportId"))
                {
                    person.PassportId = row.Value.ToString();
                }
            }

            GetCurrencyExchangerContext().Person.Add(person);
            GetCurrencyExchangerContext().SaveChanges();
        }
        
        public static void CreateCustomer(Abstract.model.Person person)
        {
            person.PersonId = 1;
            var persons = GetCurrencyExchangerContext().Person.ToArray();
            
            foreach (var p in persons)
            {
                if (p.PersonId == person.PersonId)
                {
                    person.PersonId = p.PersonId + 1;
                }
            }
            GetCurrencyExchangerContext().Person.Add(person);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}