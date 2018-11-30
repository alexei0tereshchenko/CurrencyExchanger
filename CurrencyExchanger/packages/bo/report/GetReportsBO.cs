using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.Models;

namespace CurrencyExchanger.packages.bo.report
{
    public class GetReportsBO:AbstractReadBO
    {
        public override Model[] DoRead()
        {
            return GetCurrencyexchangerContext().Report.ToArray();
        }
    }
}