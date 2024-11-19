using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.user
{
    internal class RolDao
    {
        public List<Rol> getRoles()
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var roles = context.Rol.ToList();
                    return roles;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar los roles : " + ex.Message);
            }
        }

        public Rol getRol(int id) {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var rol = context.Rol.Find(id);
                    return rol;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al encontrar el rol: " + ex.Message);
            }
        }

        public Rol GetRolByNombre(string nombreRol)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                // Buscar el estado por el nombre
                var rol = context.Rol
                                    .FirstOrDefault(e => e.nombre == nombreRol);

                // Retorna el id_estado si lo encuentra, o null si no.
                return rol;
            }
        }

    }
}
