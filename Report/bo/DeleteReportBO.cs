using Abstract.bo.@abstract;
using Abstract.model;

namespace Report.bo
{
    public class DeleteReportBO : AbstractDeleteBO
    {
        private static DeleteReportBO _instance;

        private DeleteReportBO()
        {
        }

        public static DeleteReportBO GetInstance()
        {
            return _instance ?? (_instance = new DeleteReportBO());
        }

        public override void Delete(IModel report)
        {
            GetCurrencyExchangerContext().Report.Remove((Abstract.model.Report)report);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}