using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.Negocio
{
    internal class NegocioDao
    {
        /**
        public Negocio createNegocioDao(Negocio nuevoNegocio)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {

                    var negocio = context.Negocio.Add(nuevoNegocio);
                    context.SaveChanges();
                    return negocio;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar crear un nuevo cliente: "+ ex.Message);
            }
        }

        public Negocio updateNegocioDao(Negocio negocioActualizado)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var negocioExiste = context.Negocio.Find(negocioActualizado);
                }
            }
        }
        **/
        
    }
}
