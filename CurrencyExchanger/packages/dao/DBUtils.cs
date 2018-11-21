using System.Data;
using MySql.Data.MySqlClient;

namespace CurrencyExchanger.packages.dao
{
    public class DBUtils
    {
        private static DBUtils _instance;

        private DBUtils()
        {
        }

        public static DBUtils GetInstance()
        {
            if (_instance.Equals(null))
            {
                _instance = new DBUtils();
            }

            if (_instance.Connection.State.Equals(ConnectionState.Broken) ||
                _instance.Connection.State.Equals(ConnectionState.Closed))
                _instance.Connection = GetDBConnection();
            if (_instance.Connection.State.Equals(ConnectionState.Closed))
            {
                System.Console.Write(@"Cannot access DB, please check DB credentials");                
            }
            return _instance;
        }

        public MySqlConnection Connection { get; private set; }

        private static MySqlConnection GetDBConnection()
        {
            const string host = "localhost";
            const int port = 3306;
            const string database = "currencyexchanger";
            const string username = "root";
            const string password = "admin";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}