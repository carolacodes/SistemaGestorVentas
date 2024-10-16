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
            using (var context = new sistema_de_ventas_Entities())
            {
                var usuario = context.Usuario.Add(nuevoUsuario);
                context.SaveChanges();
                return usuario;
            }
        }

        public Usuario getUserDao(string dni)
        {
            using (var context = new sistema_de_ventas_Entities())
            {
                var usuario = context.Usuario.Find(dni);
                return usuario;
            }
        }

        public List<Usuario> getUsersDao()
        {
            using (var context = new sistema_de_ventas_Entities())
            {
                return context.Usuario.ToList();
            }
        }

        public Usuario updateUserDao(Usuario userActualizado)
        {
            using (var context = new sistema_de_ventas_Entities())
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
        }

        public Usuario deleteUserDao(string dni)
        {
            using (var context = new sistema_de_ventas_Entities())
            {
            }
        }


    }

}
