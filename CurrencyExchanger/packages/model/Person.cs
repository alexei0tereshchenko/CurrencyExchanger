using System;
using System.Collections.Generic;

namespace CurrencyExchanger.packages.model
{
    public partial class Person:IModel
    {
        public Person()
        {
            Report = new HashSet<Report>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PassportSeries { get; set; }
        public string PassportId { get; set; }

        public ICollection<Report> Report { get; set; }
    }
}
