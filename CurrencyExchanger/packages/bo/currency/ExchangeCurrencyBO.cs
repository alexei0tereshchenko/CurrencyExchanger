using System;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.bo.customer;
using CurrencyExchanger.packages.bo.report;
using CurrencyExchanger.packages.model;
using FirstFloor.ModernUI.Windows.Controls;

namespace CurrencyExchanger.packages.bo.currency
{
    public class ExchangeCurrencyBO : AbstractBO
    {

        public static void ExchangeCurrency(string personFirstName, string personLastName, DateTime birthDate,
            string passportSeries, string passportId, string currencyName, double amount)
        {
            var person = GetCustomerBO.GetCustomerByPassportId(passportId);
            if (person == null)
            {
                person = new Person
                {
                    FirstName = personFirstName, LastName = personLastName, BirthDate = birthDate,
                    PassportSeries = passportSeries, PassportId = passportId
                };
                CreateCustomerBO.CreateCustomer(person);
            }

            var currency = GetCurrencyBO.GetCurrencyByName(currencyName);
            var outcomeAmount = currency.Purchase * amount;
            if (currencyName.Equals("BYN"))
            {
                outcomeAmount = amount / currency.Sell;
            }

            var report = new Report
            {
                UserId = SessionService.GetInstance().User.UserId,
                PersonId = person.PersonId,
                CurrencyId = currency.CurrencyId,
                IncomAmount = amount,
                OutcomeAmount = outcomeAmount,
                Date = DateTime.Now
            };

            CreateReportBO.CreateReport(report);

            var message = new ModernDialog
            {
                Content = "The operation completed successfully. You need to issue " + outcomeAmount +
                          " units of currency."
            };
            message.Show();
        }
    }
}