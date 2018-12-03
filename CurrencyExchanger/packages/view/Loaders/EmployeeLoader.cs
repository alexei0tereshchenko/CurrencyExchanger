using CurrencyExchanger.Content;
using FirstFloor.ModernUI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyExchanger.packages.bo.employee;
using CurrencyExchanger.packages.view.Content;
using CurrencyExchanger.pages;

namespace CurrencyExchanger
{
    class EmployeeLoader : DefaultContentLoader
    {
        public EmployeeList EmployeeList { get; set; }

        protected override object LoadContent(Uri uri)
        {
            var userId = Convert.ToInt32(uri.OriginalString.Replace("/", string.Empty));
            var user = GetEmployeeBO.GetUserById(userId);
            var employeePage = new Employee
            {
                EmployeeList = EmployeeList,
                Email = {Text = user.EMail},
                TextFirstName = {Text = user.FirstName},
                TextLastName = {Text = user.LastName},
                NameSurname = {Text = user.FirstName + " " + user.LastName},
                User = user
            };
            switch (user.Gender)
            {
                case "Male":
                    employeePage.RadioMale.IsChecked = true;
                    break;
                case "Female":
                    employeePage.RadioFemale.IsChecked = true;
                    break;
            }

            employeePage.ComboState.Text = user.State;

            if (user.BirthDate != null)
            {
                employeePage.DateBirth.SelectedDate = user.BirthDate.Value;
            }

            employeePage.TextAddress.Text = user.Address;
            employeePage.TextCity.Text = user.City;
            employeePage.TextZipCode.Text = user.ZipCode;
            return employeePage;
        }
    }
}