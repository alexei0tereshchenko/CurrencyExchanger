using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using CurrencyExchanger.packages.bo.currency;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.Content
{
    public partial class CurrencyExchange : UserControl
    {
        public CurrencyExchange()
        {
            InitializeComponent();
            foreach (var currency in (Currency[]) GetCurrencyBO.GetInstance().DoRead())
            {
                ExchangingCurrency.Items.Add(new ComboBoxItem {Content = currency.CurrencyName});
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var isForSell = SellRadioButton.IsChecked.Value;

            ExchangeCurrencyBO.ExchangeCurrency(TextFirstName.Text, TextLastName.Text,
                DateBirth.SelectedDate.Value, PassportSeries.Text, PassportID.Text, ExchangingCurrency.Text,
                double.Parse(Amount.Text, CultureInfo.InvariantCulture.NumberFormat), isForSell);
        }
    }
}