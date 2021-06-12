using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataAcces
{
    public class UserDao : ConnectionFactory
    {
        
        public bool Login(String user, String pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = $"select distinct * from usuarios where usuario = '{user}' and senha = '{pass}'";
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public DataTable CarregarDados()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT DISTINCT * FROM funcionarios ORDER BY nome ASC";
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable result = new DataTable();
                    result.Load(reader);
                    return result;
                }
            }
        }



    }
}
