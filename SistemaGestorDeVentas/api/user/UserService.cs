using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestorDeVentas.api.user;

namespace SistemaGestorDeVentas.api.user
{
    internal class UserService
    {
        UserDao userDao = new UserDao();
        public Usuario createUser(Usuario user){
            var usuario = userDao.createUserDao(user);
            return usuario;
        }

        public Usuario getUser(string dni)
        {
            var user = userDao.getUserDao(dni);
            return user;
        }

        public List<Usuario> getUsers()
        {
            var users = userDao.getUsersDao();
            return users;
        }

        public Usuario updateUser(string dni)
        {
            var userUpdate = userDao.updateUserDao(dni);
            return userUpdate;
        }

        public Usuario deleteUser(Usuario user)
        {
            var userDelete = userDao.deleteUserDao(user);
            return userDelete;
        }
    }
}
