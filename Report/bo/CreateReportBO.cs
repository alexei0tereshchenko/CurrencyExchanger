using System;
using System.Collections.Generic;
using System.Linq;
using Abstract.bo.@abstract;
using Abstract.model;


namespace Report.bo
{
    public class CreateReportBO:AbstractCreateBO
    {
        public override void DoCreate(Dictionary<string, object> parameters)
        {
            var report = new Abstract.model.Report();
            
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
        
        public static void CreateReport(Abstract.model.Report report)
        {
            report.ReportId = 1;
            var reports = GetCurrencyExchangerContext().Report.ToArray();
            
            foreach (var r in reports)
            {
                if (r.ReportId == report.ReportId)
                {
                    report.ReportId = r.ReportId + 1;
                }
            }
            GetCurrencyExchangerContext().Report.Add(report);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}