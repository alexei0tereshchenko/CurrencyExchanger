using System;
using System.Collections.Generic;
using CurrencyExchanger.packages.Models;

namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractReadBO: AbstractBO
    {
        public abstract Model[] DoRead();
    }
}