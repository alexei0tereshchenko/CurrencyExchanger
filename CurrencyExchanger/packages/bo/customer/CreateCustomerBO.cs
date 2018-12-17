using System;
using System.Collections.Generic;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.customer
{
    public class CreateCustomerBO : AbstractCreateBO
    {
        public override void DoCreate(Dictionary<string, object> parameters)
        {
            var person = new Person();
            
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
    }
}