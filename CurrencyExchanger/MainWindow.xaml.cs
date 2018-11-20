using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using CurrencyExchanger.pages;
using CurrencyExchanger.Windows;
using DMSkin.WPF.Small;

namespace CurrencyExchanger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
            var workWindow = new EmployeeWindow();
            this.Close();
            workWindow.Show();
        }
    }
}