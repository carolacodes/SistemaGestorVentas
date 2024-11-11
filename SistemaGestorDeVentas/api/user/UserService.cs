using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestorDeVentas.api.user;
using SistemaGestorDeVentas.api.cliente;

namespace SistemaGestorDeVentas.api.user
{
    internal class UserService
    {
        UserDao userDao = new UserDao();
        
        public Usuario createUser(Usuario user){
            try
            {
                var usuario = userDao.createUserDao(user);
            return usuario;
            } catch(Exception ex) {
                throw new Exception("error al crear usuario: " + ex.Message);
            }
        }

    public Usuario getUser(string dni)
        {
            try
            {
                var user = userDao.getUserDao(dni);
            return user;
            }
            catch (Exception ex)
            {
                throw new Exception("error al obtener el usuario: " + ex.Message);
            }
        }

        public List<Usuario> getUsers()
        {
            try
            {
                var users = userDao.getUsersDao();
            return users;
            }
            catch (Exception ex)
            {
                throw new Exception("error al obtener los usuarios: " + ex.Message);
            }
        }

        public Usuario updateUser(Usuario usuario)
        {
            try
            {
                var userUpdate = userDao.updateUserDao(usuario);
            return userUpdate;
            }
            catch (Exception ex)
            {
                throw new Exception("error al actualizar los usuarios: " + ex.Message);
            }
        }

        public Usuario deleteUser(string dni)
        {
            try
            {
                var userDelete = userDao.deleteUserDao(dni);
            return userDelete;
            }
            catch (Exception ex)
            {
                throw new Exception("error al eliminar los usuarios: " + ex.Message);
            }
        }

        public List<Usuario> getUserByName(string name)
        {
            try
            {
                var usuarios = userDao.getUserByNameDao(name);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar usuarios: " + ex.Message);
            }
        }
    }
}
