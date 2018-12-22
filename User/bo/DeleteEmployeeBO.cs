using System.Linq;
using Abstract.bo.@abstract;
using Abstract.model;
using Report.bo;

namespace User.bo
{
    public class DeleteEmployeeBO:AbstractDeleteBO
    {
        private static DeleteEmployeeBO _instance;

        private DeleteEmployeeBO()
        {
        }

        public static DeleteEmployeeBO GetInstance()
        {
            return _instance ?? (_instance = new DeleteEmployeeBO());
        }

        public override void Delete(IModel user)
        {
            var reports = GetCurrencyExchangerContext().Report
                .Where(report => report.UserId.Equals(((Abstract.model.User) user).UserId));
            foreach (var report in reports)
            {
                DeleteReportBO.GetInstance().Delete(report);
                GetCurrencyExchangerContext().SaveChanges();
            }
            GetCurrencyExchangerContext().User.Remove((Abstract.model.User)user);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}