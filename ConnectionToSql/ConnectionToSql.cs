using System;
using MySql.Data.MySqlClient;


namespace DataAcsses
{
    public abstract class ConnectionToSql
    {
        const String serverDB = "localhost";
        const String dataBase = "empresa";
        const String user = "root";
        const String senha = "";
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = $"server={serverDB}; database='{dataBase}'; uid='{user}';  password='{senha}'";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

