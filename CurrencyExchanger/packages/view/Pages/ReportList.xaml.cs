using System.Windows.Controls;
using CurrencyExchanger.packages.bo.currency;
using CurrencyExchanger.packages.bo.customer;
using CurrencyExchanger.packages.bo.employee;
using CurrencyExchanger.packages.bo.report;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.Pages
{
    public partial class ReportList : UserControl
    {
        public ReportList()
        {
            InitializeComponent();
            foreach (var report in (Report[])GetReportsBO.GetInstance().DoRead())
            {
                var user = GetEmployeeBO.GetUserById(report.UserId);
                var currency = GetCurrencyBO.GetCurrencyById(report.CurrencyId);
                var person = GetCustomerBO.GetPersonById(report.PersonId);
                Reports.Children.Add(new TextBlock{Text = "Person: "});
            }
        }
    }
}
