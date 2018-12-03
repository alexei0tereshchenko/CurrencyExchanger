using FirstFloor.ModernUI.Windows.Controls;
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
using CurrencyExchanger.packages.bo.employee;
using CurrencyExchanger.packages.model;
using CurrencyExchanger.pages;

namespace CurrencyExchanger.packages.view.Dialogs
{
    /// <inheritdoc cref="ModernDialog" />
    /// <summary>
    /// Interaction logic for AddEmployeeDialog.xaml
    /// </summary>
    public partial class AddEmployeeDialog : ModernDialog
    {
        public AddEmployeeDialog()
        {
            InitializeComponent();

            CloseButton.Visibility = Visibility.Hidden;
        }

        private EmployeeList _employeeList;
        public void ShowWithPropagate(EmployeeList employeeList)
        {
            _employeeList = employeeList;
            Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextFirstName.Text != "" && TextLastName.Text != "" && LoginBox.Text != "" &&
                PasswordBox.Password != "" && PasswordBox.Password.Equals(RepeatPasswordBox.Password))
            {
                var newUser = new User
                {
                    Login = LoginBox.Text, Password = PasswordBox.Password, FirstName = TextFirstName.Text,
                    LastName = TextLastName.Text, City = TextCity.Text, BirthDate = DateBirth.SelectedDate,
                    State = ComboState.Text, Address = TextAddress.Text, ZipCode = TextZipCode.Text,
                    EMail = Email.Text
                };

                if (RadioMale.IsChecked != null && RadioMale.IsChecked.Value)
                {
                    newUser.Gender = "Male";
                }
                else if (RadioFemale.IsChecked != null && RadioFemale.IsChecked.Value)
                {
                    newUser.Gender = "Female";
                }
                AddEmployeeBO.CreateUser(newUser);
                _employeeList.ReloadUsers();
                Close();    
            }
            else
            {
                if (TextFirstName.Text == "" || TextLastName.Text == "" || LoginBox.Text == "" ||
                    PasswordBox.Password == "" || RepeatPasswordBox.Password == "")
                {
                    FirstNameMessage.Visibility = TextFirstName.Text == "" ? Visibility.Visible : Visibility.Hidden;

                    LastNameMessage.Visibility = TextLastName.Text == "" ? Visibility.Visible : Visibility.Hidden;

                    LoginMessage.Visibility = LoginBox.Text == "" ? Visibility.Visible : Visibility.Hidden;

                    PasswordMessage.Visibility = PasswordBox.Password == "" ? Visibility.Visible : Visibility.Hidden;
                    if (RepeatPasswordBox.Password == "")
                    {
                        PasswordsDontMatch.Text = "*";
                        PasswordsDontMatch.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        PasswordsDontMatch.Visibility = Visibility.Hidden;
                    }

                    ShowMessage("Required fields should be filled", "Error", MessageBoxButton.OK);
                }

                else if (!PasswordBox.Password.Equals(RepeatPasswordBox.Password))
                {
                    PasswordsDontMatch.Text = "*Passwords should match";
                    PasswordsDontMatch.Visibility = Visibility.Visible;
                    ShowMessage("Passwords should match", "Error", MessageBoxButton.OK);
                }
                else
                {
                    PasswordsDontMatch.Visibility = Visibility.Hidden;
                }
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void RepeatPasswordBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (RepeatPasswordBox.Password != "")
                PasswordsDontMatch.Text = "*Passwords should match";
            if (!RepeatPasswordBox.Password.Equals(PasswordBox.Password))
            {
                PasswordsDontMatch.Visibility = Visibility.Visible;
            }
            else if (RepeatPasswordBox.Password.Equals(PasswordBox.Password))
            {
                PasswordsDontMatch.Visibility = Visibility.Hidden;
            }
        }
    }
}