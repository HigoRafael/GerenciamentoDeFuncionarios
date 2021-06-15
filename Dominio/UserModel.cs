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

        public void Inserir(string depart, string setor, string func, string mat, int carNo, string nom, string rema, string bloc, string foto, int numAr)
        {
            userDao.InserirDados(depart, setor, func, mat, carNo, nom, rema, bloc, foto, numAr);
        }

        public void Editar(int id, string depart, string setor, string func, string mat, int carNo, string nom, string rema, string bloc, string foto, int numAr)
        {
            userDao.EditarDados(id, depart, setor, func, mat, carNo, nom, rema, bloc, foto, numAr);
        }

        public void Deletar(int id)
        {
            userDao.Deletar(id);
        }
    }
}
