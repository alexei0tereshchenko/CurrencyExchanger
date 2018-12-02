using System;
using System.Collections.Generic;

namespace CurrencyExchanger.packages.model
{
    public partial class Report:Model
    {
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public int PersonId { get; set; }
        public int CurrencyId { get; set; }
        public double IncomAmount { get; set; }
        public double OutcomeAmount { get; set; }
        public DateTime Date { get; set; }

        public Currency Currency { get; set; }
        public Person Person { get; set; }
        public User User { get; set; }
    }
}
