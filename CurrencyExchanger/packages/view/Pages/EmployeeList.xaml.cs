using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using CurrencyExchanger.packages.bo.employee;
using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows.Controls;

namespace CurrencyExchanger.pages
{
    /// <inheritdoc cref="UserControl"/>
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : UserControl
    {
        public EmployeeList()
        {
            InitializeComponent();

            var allEmployees = GetEmployeeBO.DoRead();
            var employeeLinks = new LinkCollection();
            foreach (var employee in allEmployees)
            {
                employeeLinks.Add(new Link
                {
                    DisplayName = string.Concat(employee.FirstName, ' ', employee.LastName),
                    Source = new Uri("//" + employee.UserId)
                });
            }

            Employees.Links = employeeLinks;
            Employees.ContentLoader = new EmployeeLoader();
        }
    }
}