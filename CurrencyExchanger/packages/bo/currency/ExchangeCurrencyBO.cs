using System;
using System.Linq;
using System.Windows;
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
            string passportSeries, string passportId, string currencyName, double amount, bool isSelling)
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
            if (isSelling)
            {
                outcomeAmount = amount / currency.Sell;
            }


            if (!ValidateForDailyLimits(amount, currency))
            {
                ModernDialog.ShowMessage("Person can't exchange more than 1000 units \nof currency per day.", "Warning",
                    MessageBoxButton.OK);
                return;
            }

            var outReport = new Report
            {
                UserId = SessionService.GetInstance().User.UserId,
                PersonId = person.PersonId,
                CurrencyId = currency.CurrencyId,
                IncomAmount = amount,
                OutcomeAmount = outcomeAmount,
                Date = DateTime.Now
            };

            CreateReportBO.CreateReport(outReport);

            ModernDialog.ShowMessage("The operation completed successfully. \nYou need to issue " + outcomeAmount +
                                     " units of currency.", "Success!", MessageBoxButton.OK);
        }

        private static bool ValidateForDailyLimits(double amount, Currency currency)
        {
            const int maxDayLimit = 1000;
            var dailyAmountExchanged = ((Report[]) GetReportsBO.GetInstance().DoRead())
                .Where(report =>
                    currency.CurrencyId.Equals(report.CurrencyId) &&
                    DateTime.Now.ToShortDateString().Equals(report.Date.ToShortDateString()))
                .Sum(report => report.IncomAmount);

            dailyAmountExchanged += amount;

            return dailyAmountExchanged <= maxDayLimit;
        }
    }
}