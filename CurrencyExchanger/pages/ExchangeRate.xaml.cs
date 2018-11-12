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

namespace CurrencyExchanger.Pages
{
    /// <summary>
    /// Interaction logic for ExchangeRate.xaml
    /// </summary>
    public partial class ExchangeRate : UserControl
    {
        //TODO: needs to create own class of this entity and remove from here
        public class Currency
        {
            public string Name { get; set; }
            public double Purchase { get; set; }
            public double Selling { get; set; }

        }
        public ExchangeRate()
        {
            InitializeComponent();
            ObservableCollection<Currency> currencyDate = GetData();
            DG1.DataContext = currencyDate;
        }

        private ObservableCollection<Currency> GetData()
        {
            var currencyRates = new ObservableCollection<Currency>();
            currencyRates.Add(new Currency { Name = "USD", Purchase = 2.10, Selling = 2.20 });
            currencyRates.Add(new Currency { Name = "EUR", Purchase = 100.16, Selling = 105.63 });
            currencyRates.Add(new Currency { Name = "GBP", Purchase = 67.10, Selling = 67.20 });
            currencyRates.Add(new Currency { Name = "INR", Purchase = 3.67, Selling = 3.68 });
            currencyRates.Add(new Currency { Name = "AUD", Purchase = 30.01, Selling = 29.98 });
            currencyRates.Add(new Currency { Name = "CAD", Purchase = 156.14, Selling = 155.98 });
            currencyRates.Add(new Currency { Name = "SGD", Purchase = 0.38, Selling = 0.41 });
            currencyRates.Add(new Currency { Name = "BYU", Purchase = 12.66, Selling = 13.00 });
            return currencyRates;
        }
    }
}
