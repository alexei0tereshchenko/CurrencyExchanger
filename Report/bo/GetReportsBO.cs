using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;
using CurrencyExchanger.packages.model;

namespace Report.bo
{
    public class GetReportsBO : AbstractReadBO
    {
        private static GetReportsBO _instance;

        private GetReportsBO()
        {
        }

        public static GetReportsBO GetInstance()
        {
            return _instance ?? (_instance = new GetReportsBO());
        }

        public override IModel[] DoRead()
        {
            return GetCurrencyExchangerContext().Report.ToArray();
        }
    }
}