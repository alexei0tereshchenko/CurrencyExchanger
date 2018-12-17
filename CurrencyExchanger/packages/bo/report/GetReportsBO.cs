using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace CurrencyExchanger.packages.bo.report
{
    public class GetReportsBO:AbstractReadBO
    {
        public override IModel[] DoRead()
        {
            return GetCurrencyExchangerContext().Report.ToArray();
        }
    }
}