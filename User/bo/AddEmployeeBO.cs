using System;
using System.Collections.Generic;
using System.Linq;
using CurrencyExchanger.packages.bo.@abstract;

namespace User.bo
{
    public class AddEmployeeBO : AbstractCreateBO
    {
        public override void DoCreate(Dictionary<string, object> parameters)
        {
            var user = new CurrencyExchanger.packages.model.User();

            foreach (var row in parameters)
            {
                if (row.Key.Equals("FirstName")) //commit test
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

            GetCurrencyExchangerContext().User.Add(user);
            GetCurrencyExchangerContext().SaveChanges();
        }

        public static void CreateUser(CurrencyExchanger.packages.model.User user)
        {
            user.UserId = 1;
            var users = GetCurrencyExchangerContext().User.ToArray();

            foreach (var u in users)
            {
                if (u.UserId == user.UserId)
                {
                    user.UserId = u.UserId + 1;
                }
            }

            GetCurrencyExchangerContext().User.Add(user);
            GetCurrencyExchangerContext().SaveChanges();
        }
    }
}