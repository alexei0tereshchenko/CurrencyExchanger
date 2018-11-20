using System;

namespace CurrencyExchanger.packages.model
{
    public class Report
    {
        public int ReportId { get; set; }
        public User User{ get; set; }
        public Person Person { get; set; }
        public Currency Currency { get; set; }
        public float IncomeAmount { get; set; }
        public float OutcomeAmount { get; set; }
        public DateTime Date { get; set; }
    }
}