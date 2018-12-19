using System.Windows;
using System.Windows.Controls;

namespace CurrencyExchanger.packages.view.Pages
{
    public partial class CurrencyExchange : UserControl
    {
        public CurrencyExchange()
        {
            InitializeComponent();
        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this)?.Close();
        }
    }
}
