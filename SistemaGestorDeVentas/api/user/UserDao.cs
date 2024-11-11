using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.user
{
    internal class UserDao
    {
        public Usuario createUserDao(Usuario nuevoUsuario)
        {   
            try{
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                var usuario = context.Usuario.Add(nuevoUsuario);
                context.SaveChanges();
                return usuario;
                }
            } catch(Exception ex) {
                throw new Exception("error al crear usuario: " + ex.Message);
            }

        }

        public Usuario getUserDao(string dni)
        {
            try{
                using (var context = new sistema_de_ventas_taller_Entities())
            {
                var usuario = context.Usuario.Find(dni);
                return usuario;
            }
            }catch(Exception ex)
            {
                throw new Exception("error al buscar el usuario: " + ex.Message);
            }
        }

        public List<Usuario> getUsersDao()
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
            {
                return context.Usuario.ToList();
            }
            }catch(Exception ex)
            {
                throw new Exception("error al obtener los usuarios: " + ex.Message);
            }
        }

        public Usuario updateUserDao(Usuario userActualizado)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
            {
                var user = context.Usuario.Find(userActualizado.DNI_usuario);
                if(user != null)
                {
                    user.email = userActualizado.email;
                    user.id_estado = userActualizado.id_estado;
                    user.nombre = userActualizado.nombre;
                    user.pass = userActualizado.pass;
                    user.id_rol = userActualizado.id_rol;

                }
                return user;
            }
            }catch(Exception ex) {
                throw new Exception("error al actualizar el usuario: " + ex.Message);
            }
        }


        public Usuario deleteUserDao(string dni)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
            {
                    var usuario = context.Usuario.Find(dni);
                    if (usuario != null)
                    {
                        usuario.id_estado = 0;
                        // 0 = 'inactivo'
                        context.SaveChanges();

                    }

                    return usuario;
                }
            }catch(Exception ex)
            {
                throw new Exception("error al eliminar el usuario: " + ex.Message);
            }
        }

        public List<Usuario> getUserByNameDao(string name)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    return context.Usuario
                    .Where(u => u.nombre.Contains(name))
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("no se encuentran usuarios: " + ex.Message);
            }
        }
    }
}
