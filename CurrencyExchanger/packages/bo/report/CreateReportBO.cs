using System;
using System.Collections.Generic;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.report
{
    public class CreateReportBO:AbstractCreateBO
    {
        public override void DoCreate(Dictionary<string, object> parameters)
        {
            var report = new Report();
            foreach (var row in parameters)
            {
                if (row.Key.Equals("Person"))
                {
                    report.Person = (Person) row.Value;
                }

                if (row.Key.Equals("Currency"))
                {
                    report.Currency = (Currency) row.Value;
                }

                if (row.Key.Equals("User"))
                {
                    report.User = (User) row.Value;
                }

                if (row.Key.Equals("IncomAmount"))
                {
                    report.IncomAmount = (double) row.Value;
                }

                if (row.Key.Equals("OutcomeAmount"))
                {
                    report.OutcomeAmount = (double) row.Value;
                }

                if (row.Key.Equals("Date"))
                {
                    report.Date = (DateTime) row.Value;
                }
            }

            report.CurrencyId = report.Currency.CurrencyId;
            report.PersonId = report.Person.PersonId;
            report.UserId = report.User.UserId;
            GetCurrencyExchangerContext().Report.Add(report);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}