using CurrencyExchanger.Content;
using FirstFloor.ModernUI.Windows;
using System;

namespace CurrencyExchanger
{
    class ReportLoaderDefaultContentLoader : DefaultContentLoader
    {
        protected override object LoadContent(Uri uri)
        {
            // return a new Report user control instance no matter the uri
            return new Report();
        }
    }
}
