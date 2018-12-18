using FirstFloor.ModernUI.Windows.Controls;
using System.Windows;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.view.Dialogs
{
    public partial class DeleteCurrencyDialog : ModernDialog
    {
        public Currency[] Currencies { get; set; }
        public DeleteCurrencyDialog()
        {
            InitializeComponent();
            CloseButton.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
