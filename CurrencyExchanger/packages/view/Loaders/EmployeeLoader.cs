using CurrencyExchanger.Content;
using FirstFloor.ModernUI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyExchanger.packages.bo.employee;

namespace CurrencyExchanger
{
    class EmployeeLoader: DefaultContentLoader
    {
        protected override object LoadContent(Uri uri)
        {
            var employeePage = new Employee();
            var userId = Convert.ToInt32(uri.OriginalString.Replace("/", string.Empty));
            var user = GetEmployeeBO.GetUserById(userId);
            employeePage.Email.Text = user.EMail;
            employeePage.TextFirstName.Text = user.FirstName;
            employeePage.TextLastName.Text = user.LastName;
            employeePage.NameSurname.Text = user.FirstName + " " + user.LastName;
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
            
            if (user.BirthDate!=null)
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
