using System;
using CurrencyExchanger.packages.Models;

namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractReadBO: AbstractBO
    {
        public abstract Report[] DoRead();
    }
}