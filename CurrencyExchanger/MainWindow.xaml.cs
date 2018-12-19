using System.Windows;
using System.Windows.Media;
using CurrencyExchanger.packages.view.Windows;
using User;

namespace CurrencyExchanger
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginBox_LostKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            if (LoginBox.Text.Equals(""))
            {
                LoginBox.Text = "Username";
                LoginBox.Foreground = Brushes.DarkGray;
            }
        }

        private void LoginBox_GotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            if (LoginBox.Text.Equals("Username"))
            {
                LoginBox.Text = "";
                LoginBox.Foreground = Brushes.Black;
            }
        }

        private void PasswordBox_GotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            if (PasswordBox.Password.Equals("Password"))
            {
                PasswordBox.Password = "";
                PasswordBox.Foreground = Brushes.Black;
            }
        }

        private void PasswordBox_LostKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            if (PasswordBox.Password.Equals(""))
            {
                PasswordBox.Password = "Password";
                PasswordBox.Foreground = Brushes.DarkGray;
            }
        }

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            var loginResult = SessionService.GetInstance().Authorizate(LoginBox.Text, PasswordBox.Password);
            switch (loginResult)
            {
                case 0:
                    TextBox.Text = "Wrong username or password.";
                    TextBox.Foreground = Brushes.Red;
                    break;
                case 1:
                    var administratorWindow = new AdministratorWindow();
                    administratorWindow.Show();
                    Close();
                    break;
                case 2:
                    var employeeWindow = new EmployeeWindow();
                    employeeWindow.Show();
                    Close();
                    break;
            }
        }
    }
}