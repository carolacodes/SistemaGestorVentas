using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.pago
{
    internal class PagoService
    {
        PagoDao pagoDao = new PagoDao();
        public Pago crearPago(Pago pagoNuevo)
        {
            try
            {
                var pago = pagoDao.createPagoDao(pagoNuevo);
                return pago;
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar crear el pago" + ex.Message);
            }
        }

        public Pago getPago(int id_pago)
        {
            try
            {
                var pago = pagoDao.getPagoDao(id_pago);
                return pago;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener el pago" + ex.Message);
            }
        }

        public List<Pago> getPagos()
        {
            try
            {
                List<Pago> pagos = pagoDao.getPagosDao();
                return pagos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener los pagos" + ex.Message);
            }
        }
    }
}
