using System.Windows;
using System.Windows.Controls;
using CurrencyExchanger.packages.bo.employee;
using CurrencyExchanger.packages.model;
using CurrencyExchanger.pages;
using FirstFloor.ModernUI.Windows.Controls;

namespace CurrencyExchanger.packages.view.Content
{
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }

        public User User { private get; set; }
        public EmployeeList EmployeeList { private get; set; }

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

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            const MessageBoxButton btn = MessageBoxButton.YesNo;
            var result = ModernDialog.ShowMessage(
                "You are going to delete user " + User.FirstName + " " + User.LastName + ".\nAre you sure?",
                "Delete User", btn);
            if (result != MessageBoxResult.Yes) return;
            DeleteEmployeeBO.GetInstance().Delete(User);
            EmployeeList.ReloadUsers();
        }
    }
}