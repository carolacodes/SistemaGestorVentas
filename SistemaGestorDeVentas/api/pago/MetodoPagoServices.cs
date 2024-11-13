using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.pago
{
    internal class MetodoPagoServices
    {
        MetodoPagoDao metodoPagoDao = new MetodoPagoDao();
        public List<Metodo_Pago> getMetodosPago()
        {
            try
            {
                List<Metodo_Pago> metodos = metodoPagoDao.getMetodosPagoDao();
                return metodos;
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener los metodos de pago: " + ex.Message);
            }
        }

        public Metodo_Pago getMetodoPago(int id_metodo)
        {
            try
            {
                var metodo = metodoPagoDao.getMetodoPagoDao(id_metodo);
                return metodo;
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener un metodo de pago" + ex.Message);
            }
        }

        public Metodo_Pago getMetodoPagoByName(string nomre_metodo)
        {
            try
            {
                var metodo = metodoPagoDao.getMetodoPagoDaoByName(nombre_metodo);
                return metodo;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener un metodo de pago" + ex.Message);
            }
        }
    }
}
