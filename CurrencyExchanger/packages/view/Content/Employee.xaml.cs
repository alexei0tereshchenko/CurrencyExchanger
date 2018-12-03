using System.Windows;
using System.Windows.Controls;
using CurrencyExchanger.packages.bo.employee;
using CurrencyExchanger.packages.model;
using CurrencyExchanger.pages;

namespace CurrencyExchanger.packages.view.Content
{
    /// <inheritdoc cref="UserControl" />
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }

        public User User { private get; set; }
        public EmployeeList EmployeeList { get; set; }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            User.Address = TextAddress.Text;
            User.City = TextCity.Text;
            if (RadioMale.IsChecked != null && RadioMale.IsChecked.Value)
            {
                User.Gender = "Male";
            }
            else if (RadioFemale.IsChecked != null && RadioFemale.IsChecked.Value)
            {
                User.Gender = "Female";
            }

            User.State = ComboState.Text;
            if (DateBirth.SelectedDate != null) User.BirthDate = DateBirth.SelectedDate.Value;
            User.EMail = Email.Text;
            User.FirstName = TextFirstName.Text;
            User.LastName = TextLastName.Text;

            UpdateEmployeeBO.UpdateUser(User);
            NameSurname.Text = User.FirstName + " " + User.LastName;
            EmployeeList.ReloadUsers();
        }
    }
}