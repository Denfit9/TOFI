using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOFIiBank
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            /*string host = "127.0.0.1";
            int port = 3306;
            string database = "bankDB";
            string username = "root";
            string password = "Deniskarachun9";*/
            

            string host = "mysql-157379-0.cloudclusters.net";
            int port = 16547;
            string database = "BankDB";
            string username = "admin";
            string password = "3K7ju2NF";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password); 
        }

    }
}
