using System.Globalization;
using System.Windows;
using Currency.bo;
using CurrencyExchanger.packages.view.Pages;
using FirstFloor.ModernUI.Windows.Controls;

namespace CurrencyExchanger.packages.view.Dialogs
{
    public partial class AddNewOrEditCurrencyDialog : ModernDialog
    {
        private static Abstract.model.Currency[] Currencies { get; set; }

        public ExchangeRate ExchangeRatePage { private get; set; }

        public AddNewOrEditCurrencyDialog()
        {
            InitializeComponent();
            CloseButton.Visibility = Visibility.Hidden;
        }


        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (Sell.Text == string.Empty || Purchase.Text == string.Empty)
            {
                return;
            }

            if (GetCurrencyBO.GetCurrencyByName(CurrencyBox.Text) == null)
            {
                var currency = new Abstract.model.Currency
                {
                    CurrencyName = CurrencyBox.Text,
                    Purchase = double.Parse(Purchase.Text, CultureInfo.InvariantCulture.NumberFormat),
                    Sell = double.Parse(Sell.Text, CultureInfo.InvariantCulture.NumberFormat)
                };
                AddCurrencyBO.GetInstance().CreateCurrency(currency);
                ExchangeRatePage.Reload();
            }
            else
            {
                var currency = GetCurrencyBO.GetCurrencyByName(CurrencyBox.Text);
                currency.Purchase = double.Parse(Purchase.Text, CultureInfo.InvariantCulture.NumberFormat);
                currency.Sell = double.Parse(Sell.Text, CultureInfo.InvariantCulture.NumberFormat);

                UpdateCurrencyBO.UpdateCurrency(currency);
                ExchangeRatePage.Reload();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}