using MySql.Data.MySqlClient;

namespace CurrencyExchanger.packages.dao
{
    public class DBUtils
    {
        public static MySqlConnection GetDBConnection( )
        {
            string host = "localhost";
            int port = 3306;
            string database = "currencyexchanger";
            string username = "root";
            string password = "admin";
 
            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}