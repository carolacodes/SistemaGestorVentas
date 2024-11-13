using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.pago
{
    internal class MetodoPagoDao
    {
        public List<Metodo_Pago> getMetodosPagoDao()
        {
            try
            {
                using (var contex = new sistema_de_ventas_taller_Entities())
                {
                    List<Metodo_Pago> metodos = contex.Metodo_Pago.ToList();
                    return metodos;
                }
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener los metodos de pago: "+ ex.Message);
            }
        }

        public Metodo_Pago getMetodoPagoDao(int id_metodo)
        {
            try
            {
                using(var context = new sistema_de_ventas_taller_Entities())
                {
                    var metodoExiste = context.Metodo_Pago.Find(id_metodo);
                    if (metodoExiste != null)
                    {
                        return metodoExiste;
                    } else
                    {
                        return null;
                    }
                }
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener el metodo de pago: " + ex.Message);
            }
        }

        public Metodo_Pago getMetodoPagoDaoByName(string nombre_metodo)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    // Utilizamos FirstOrDefault para obtener un solo resultado o null si no encuentra coincidencias
                    var metodoExiste = context.Metodo_Pago.FirstOrDefault(p => p.nombre.Contains(nombre_metodo));
                    return metodoExiste;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener el método de pago: " + ex.Message);
            }
        }

        
    }
}
