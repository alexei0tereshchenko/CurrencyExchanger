namespace CurrencyExchanger.packages.model
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public float Sell { get; set; }
        public float Purchase { get; set; }
    }
}