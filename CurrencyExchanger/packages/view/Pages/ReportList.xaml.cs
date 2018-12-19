using System.Windows.Controls;
using Currency.bo;
using Person.bo;
using Report.bo;
using User.bo;

namespace CurrencyExchanger.packages.view.Pages
{
    public partial class ReportList : UserControl
    {
        public ReportList()
        {
            InitializeComponent();
            foreach (var report in (Abstract.model.Report[]) GetReportsBO.GetInstance().DoRead())
            {
                var user = GetEmployeeBO.GetUserById(report.UserId);
                var currency = GetCurrencyBO.GetCurrencyById(report.CurrencyId);
                var person = GetCustomerBO.GetPersonById(report.PersonId);
                Reports.Children.Add(new TextBlock
                {
                    Text = " - " + person.FirstName + " " + person.LastName + ", " +
                           person.BirthDate.Value.ToShortDateString() + " birth, passport id: " + person.PassportId +
                           " has exchanged " + report.IncomAmount + " " + currency.CurrencyName + " to " +
                           report.OutcomeAmount + " units. \nResponsible for the operation is " + user.FirstName + " " +
                           user.LastName + ". Date: " + report.Date.ToShortDateString() + ".\n\n"
                });
            }
        }
    }
}