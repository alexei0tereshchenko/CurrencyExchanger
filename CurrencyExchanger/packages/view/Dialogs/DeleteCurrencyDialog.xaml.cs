﻿using FirstFloor.ModernUI.Windows.Controls;
using System.Windows;
using System.Windows.Controls;
using CurrencyExchanger.packages.bo.currency;
using CurrencyExchanger.packages.model;
using CurrencyExchanger.packages.view.Pages;

namespace CurrencyExchanger.packages.view.Dialogs
{
    public partial class DeleteCurrencyDialog : ModernDialog
    {
        private static Currency[] Currencies { get; set; }

        public ExchangeRate ExchangeRatePage { private get; set; }

        public DeleteCurrencyDialog()
        {
            InitializeComponent();
            CloseButton.Visibility = Visibility.Hidden;
            ReloadContent();
        }

        private void ReloadContent()
        {
            CurrencyBox.Items.Clear();
            Currencies = (Currency[]) GetCurrencyBO.GetInstance().DoRead();
            foreach (var currency in Currencies)
            {
                CurrencyBox.Items.Add(new ComboBoxItem {Content = currency.CurrencyName});
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (string.Empty == CurrencyBox.Text)
            {
                return;
            }

            DeleteCurrencyBO.GetInstance().DeleteCurrencyByName(CurrencyBox.Text);
            ExchangeRatePage.Reload();
            ReloadContent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}