using Abstract.bo.@abstract;
using Abstract.model;

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
            GetCurrencyExchangerContext().User.Remove((Abstract.model.User)user);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}