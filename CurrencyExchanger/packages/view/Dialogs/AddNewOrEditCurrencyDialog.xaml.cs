using System.Windows;
using CurrencyExchanger.packages.model;
using FirstFloor.ModernUI.Windows.Controls;

namespace CurrencyExchanger.packages.view.Dialogs
{
    public partial class AddNewOrEditCurrencyDialog : ModernDialog
    {
        public Currency[] Currencies { get; set; }
        public AddNewOrEditCurrencyDialog()
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
