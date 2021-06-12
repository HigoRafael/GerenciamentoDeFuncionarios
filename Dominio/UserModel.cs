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
    }
}
