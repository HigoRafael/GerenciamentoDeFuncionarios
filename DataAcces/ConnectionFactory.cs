using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAcces
{
    public abstract class ConnectionFactory
    {
        private const String serverDB = "10.57.64.203";
        private const String dataBase = "funcionarioscalcomp";
        private const String user = "root";
        private const String senha = "rootpass1234";
        private readonly string connectionString;

        public ConnectionFactory()
        {
            connectionString = $"server={serverDB}; database='{dataBase}'; uid='{user}';  password='{senha}'";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
