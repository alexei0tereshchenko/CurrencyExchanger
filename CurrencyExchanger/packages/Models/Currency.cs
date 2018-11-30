using System;
using System.Collections.Generic;

namespace CurrencyExchanger.packages.Models
{
    public partial class Currency: Model
    {
        public Currency()
        {
            Report = new HashSet<Report>();
        }

        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public double Sell { get; set; }
        public double Purchase { get; set; }

        public ICollection<Report> Report { get; set; }
    }
}
