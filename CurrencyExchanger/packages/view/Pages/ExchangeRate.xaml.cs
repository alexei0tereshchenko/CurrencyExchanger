using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Currency.bo;
using CurrencyExchanger.packages.model;
using CurrencyExchanger.packages.view.Dialogs;

namespace CurrencyExchanger.packages.view.Pages
{
    public partial class ExchangeRate : UserControl
    {
        public ExchangeRate()
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            _currencies = (model.Currency[]) GetCurrencyBO.GetInstance().DoRead();
            var currencyDate = GetData();
            DG1.DataContext = currencyDate;
        }

        private static model.Currency[] _currencies;

        private static ObservableCollection<model.Currency> GetData()
        {
            var currencyRates = new ObservableCollection<model.Currency>();
            foreach (var model in _currencies)
            {
                var currency = model;
                currencyRates.Add(currency);
            }

            return currencyRates;
        }

        private void EditCurrency_Click(object sender, RoutedEventArgs e)
        {
            var editCurrencyDialog = new AddNewOrEditCurrencyDialog {ExchangeRatePage = this};
            editCurrencyDialog.Show();
        }

        private void DeleteCurrency_OnClick(object sender, RoutedEventArgs e)
        {
            var deleteCurrencyDialog = new DeleteCurrencyDialog {ExchangeRatePage = this};
            deleteCurrencyDialog.Show();
        }
    }
}