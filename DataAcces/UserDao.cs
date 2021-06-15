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

        public DataTable CarregarDadosPorMatricula(int numMat)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = $"SELECT DISTINCT * FROM funcionarios WHERE cardNO = '{numMat}' ORDER BY nome ASC";
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable result = new DataTable();
                    result.Load(reader);
                    return result;
                }
            }
        }

        public void InserirDados(string departamento, string setor, string funcao, string matricula, int cardNo, string nome, string remark, string bloco, string foto, int numArmario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "insert into funcionarios (departamento, setor, funcao, matricula, cardNo, nome, remark, bloco, foto, numArmario)" +
                        $"values ('{departamento}', '{setor}', '{funcao}', '{matricula}', '{cardNo}', '{nome}', '{remark}','{bloco}', '{foto}', '{numArmario}');";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarDados(int id, string departamento, string setor, string funcao, string matricula, int cardNo, string nome, string remark, string bloco, string foto, int numArmario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = $"update funcionarios set departamento = '{departamento}', setor = '{setor}', funcao = '{funcao}', matricula = '{matricula}', cardNo = '{cardNo}', nome = '{nome}'," +
                        $"remark = '{remark}', bloco = '{bloco}', foto = '{foto}', numArmario = '{numArmario}' where id = '{id}'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = $"DELETE FROM FUNCIONARIOS WHERE ID = '{id}'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
