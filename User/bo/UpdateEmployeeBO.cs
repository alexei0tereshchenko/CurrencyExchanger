using System;
using System.Collections.Generic;
using Abstract.bo.@abstract;

namespace User.bo
{
    public class UpdateEmployeeBO:AbstractUpdateBO
    {
        public override void DoUpdate(int userId, Dictionary<string, object> parameters)
        {
           var user = new Abstract.model.User{UserId = userId};
            foreach (var row in parameters)
            {
                if (row.Key.Equals("FirstName"))
                {
                    user.FirstName = row.Value.ToString();
                }

                if (row.Key.Equals("LastName"))
                {
                    user.LastName = row.Value.ToString();
                }

                if (row.Key.Equals("Login"))
                {
                    user.Login = row.Value.ToString();
                }

                if (row.Key.Equals("Password"))
                {
                    user.Password = row.Value.ToString();
                }

                if (row.Key.Equals("Address"))
                {
                    user.Address = row.Value.ToString();
                }

                if (row.Key.Equals("City"))
                {
                    user.City = row.Value.ToString();
                }

                if (row.Key.Equals("ZipCode"))
                {
                    user.ZipCode = row.Value.ToString();
                }

                if (row.Key.Equals("BirthDate"))
                {
                    user.BirthDate = (DateTime?) row.Value;
                }

                if (row.Key.Equals("State"))
                {
                    user.State = row.Value.ToString();
                }

                if (row.Key.Equals("Gender"))
                {
                    user.Gender = row.Value.ToString();
                }

                if (row.Key.Equals("Email"))
                {
                    user.EMail = row.Value.ToString();
                }
            }

            GetCurrencyExchangerContext().User.Update(user);
            GetCurrencyExchangerContext().SaveChanges();
        }

        public static void UpdateUser(Abstract.model.User user)
        {
            GetCurrencyExchangerContext().User.Update(user);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}