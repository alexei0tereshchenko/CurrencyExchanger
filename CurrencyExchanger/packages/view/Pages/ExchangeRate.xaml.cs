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
using System.Collections.ObjectModel;
using System.Windows.Shapes;
using CurrencyExchanger.packages.bo.currency;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.Pages
{
    /// <summary>
    /// Interaction logic for ExchangeRate.xaml
    /// </summary>
    public partial class ExchangeRate : UserControl
    {
        public ExchangeRate()
        {
            InitializeComponent();
            var currencyDate = GetData();
            DG1.DataContext = currencyDate;
        }

        private static ObservableCollection<Currency> GetData()
        {
            var currencyRates = new ObservableCollection<Currency>();
            foreach (Currency currency in GetCurrencyBO.GetInstance().DoRead())
            {
                currencyRates.Add(currency);
            }
            return currencyRates;
        }
    }
}