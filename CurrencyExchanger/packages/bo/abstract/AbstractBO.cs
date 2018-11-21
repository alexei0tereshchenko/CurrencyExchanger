using CurrencyExchanger.packages.dao;
using MySql.Data.MySqlClient;

namespace CurrencyExchanger.packages.bo.@abstract
{
    public abstract class AbstractBO
    {
        private static readonly MySqlConnection Connection = DBUtils.GetInstance().Connection;

        public MySqlConnection GetConnection()
        {
            return Connection;
        }
    }
}