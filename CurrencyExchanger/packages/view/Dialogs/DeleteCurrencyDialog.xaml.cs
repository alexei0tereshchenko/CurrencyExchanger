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
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.view.Dialogs
{
    /// <inheritdoc cref="ModernDialog" />
    /// <summary>
    /// Interaction logic for EditCurrencyDialog.xaml
    /// </summary>
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
