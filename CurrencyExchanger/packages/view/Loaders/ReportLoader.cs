using CurrencyExchanger.Content;
using FirstFloor.ModernUI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
