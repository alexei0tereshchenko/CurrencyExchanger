using CurrencyExchanger.Content;
using FirstFloor.ModernUI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    class EmployeeLoader: DefaultContentLoader
    {
        protected override object LoadContent(Uri uri)
        {
            // return a new Employee user control instance no matter the uri
            return new Employee();
        }
    }
}
