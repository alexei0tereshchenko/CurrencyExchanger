namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractUpdateBO: AbstractBO
    {
        public abstract void DoUpdate(int id, object[] parameters);
    }
}