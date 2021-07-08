using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces;
using System.Data;

namespace Dominio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public DataTable CarregarDados()
        {
            DataTable resulta = new DataTable();
            resulta = userDao.CarregarDados();
            return resulta;
        }

        public DataTable CarregarDadosMatricula(int numMat)
        {
            DataTable resulta = new DataTable();
            resulta = userDao.CarregarDadosPorMatricula(numMat);
            return resulta;
        }

        public void Inserir(string filial, int matricula, string matriculacc, string nome, string centroCusto, string descricao_departamento, string grupo, string cargo, string funcao, string descreicaoPosicao, string desFuncope, string blocoArmario, int numeroArmario, string foto)
        {
            userDao.InserirDados(filial, matricula, matriculacc, nome, centroCusto, descricao_departamento, grupo, cargo, funcao, descreicaoPosicao, desFuncope, blocoArmario, numeroArmario, foto);
        }

        public void Editar(int id, string filial, int matricula, string matriculacc, string nome, string centroCusto, string descricao_departamento, string grupo, string cargo, string funcao, string descreicaoPosicao, string desFuncope, string blocoArmario, int numeroArmario, string foto)
        {
            userDao.EditarDados(id, filial, matricula, matriculacc, nome, centroCusto, descricao_departamento, grupo, cargo, funcao, descreicaoPosicao, desFuncope, blocoArmario, numeroArmario, foto);
        }

        public void Deletar(int id)
        {
            userDao.Deletar(id);
        }
    }
}
