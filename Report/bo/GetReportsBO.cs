using System.Linq;
using Abstract.bo.@abstract;
using Abstract.model;

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