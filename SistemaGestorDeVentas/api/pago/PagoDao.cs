using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.pago
{
    internal class PagoDao
    {
        public Pago createPagoDao(Pago pagoNuevo)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var pago = context.Pago.Add(pagoNuevo);
                    context.SaveChanges();
                    return pago;
                }
            } catch (Exception ex)
            {
                throw new Exception("error al intentar crear el pago: "+ ex.Message);
            }
        }

        public Pago getPagoDao(int id_pago)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var pagoEncontrado = context.Pago.Find(id_pago);
                    if(pagoEncontrado != null)
                    {
                        return pagoEncontrado;
                    }
                    else
                    {
                        return null;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al intentar obtener el pago: " + ex.Message);
            }
        }

        public List<Pago> getPagosDao()
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    List<Pago> pagos = context.Pago.ToList();
                    if (pagos!= null)
                    {
                        return pagos;
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al intentar obtener los pagos: " + ex.Message);
            }
        }

    }
}
