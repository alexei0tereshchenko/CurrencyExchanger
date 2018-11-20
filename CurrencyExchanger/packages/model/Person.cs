using System;

namespace CurrencyExchanger.packages.model
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PassportSeries { get; set; }
        public int PassportId { get; set; }
    }
}