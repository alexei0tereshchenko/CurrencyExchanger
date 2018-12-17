using System;
using System.Collections.Generic;

namespace CurrencyExchanger.packages.model
{
    public partial class User:IModel
    {
        public User()
        {
            Report = new HashSet<Report>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Gender { get; set; }

        public ICollection<Report> Report { get; set; }
    }
}
