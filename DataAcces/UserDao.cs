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
                    cmd.CommandText = $"select distinct * from USUARIOS where usuario = '{user}' and senha = '{pass}'";
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
                    cmd.CommandText = "SELECT DISTINCT * FROM FUNCIONARIOS ORDER BY nome ASC";
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
                    cmd.CommandText = $"SELECT DISTINCT * FROM FUNCIONARIOS WHERE MATRICULA = '{numMat}' ORDER BY nome ASC";
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable result = new DataTable();
                    result.Load(reader);
                    return result;
                }
            }
        }

        public void InserirDados(string filial, int matricula, string matriculacc, string nome, string centroCusto, string descricao_departamento, string grupo, string cargo, string funcao, string descreicaoPosicao, string desFuncope, string blocoArmario, int numeroArmario, string foto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "insert into FUNCIONARIOS (FILIAL, MATRICULA, MATRICULACC, NOME, CENTRO_CUSTO, DESCRICAO_DEPARTAMENTO, GRUPO, CARGO, FUNCAO, DESCRICAO_POSICAO, DES_FUNC_OPE, BLOCO_ARMARIO, NUMERO_ARMARIO, FOTO)" +
                        $"values ('{filial}', '{matricula}', '{matriculacc}', '{nome}', '{centroCusto}', '{descricao_departamento}', '{grupo}','{cargo}', '{funcao}', '{descreicaoPosicao}', '{desFuncope}', '{blocoArmario}', '{numeroArmario}', '{foto.Replace("\\", "/")}');";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarDados(int id, string filial, int matricula, string matriculacc, string nome, string centroCusto, string descricao_departamento, string grupo, string cargo, string funcao, string descreicaoPosicao, string desFuncope, string blocoArmario, int numeroArmario, string foto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = $"update FUNCIONARIOS set FILIAL = '{filial}', MATRICULA = '{matricula}', MATRICULACC = '{matriculacc}', NOME = '{nome}', CENTRO_CUSTO = '{centroCusto}', DESCRICAO_DEPARTAMENTO = '{descricao_departamento}'," +
                        $"GRUPO = '{grupo}', CARGO = '{cargo}', FUNCAO = '{funcao}', DESCRICAO_POSICAO = '{descreicaoPosicao}', DESC_FUNC_OPE = '{desFuncope}', BLOCO_ARMARIO = '{blocoArmario}', NUMERO_ARMARIO = '{numeroArmario}', FOTO = '{foto.Replace("\\", "/")}' where ID = '{id}'";
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
