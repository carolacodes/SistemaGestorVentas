using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.user
{
    internal class RolService
    {
        RolDao RolDao = new RolDao();
        public List<Rol> getRoles()
        {
            try
            {
                
                var roles = RolDao.getRoles();
                 return roles;
                
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar los roles : " + ex.Message);
            }
        }

        public Rol getRol(int id)
        {
            try
            {

                    var rol = RolDao.getRol(id);
                    return rol;
                
            }
            catch (Exception ex)
            {
                throw new Exception("error al encontrar el rol: " + ex.Message);
            }
        }

        public Rol GetRolByNombre(string nombreRol)
        {
            try
            {

                var rol = RolDao.GetRolByNombre(nombreRol);
                return rol;

            }
            catch (Exception ex)
            {
                throw new Exception("error al encontrar el rol: " + ex.Message);
            }
        }
    }
}
