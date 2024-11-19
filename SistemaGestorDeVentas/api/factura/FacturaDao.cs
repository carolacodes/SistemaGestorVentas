using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.factura
{
    internal class FacturaDao
    {
        public Factura crearFacturaDao(Factura nuevaFactura)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                try
                {
                    var factura = context.Factura.Add(nuevaFactura);
                    context.SaveChanges();
                    return factura;
                }catch (Exception ex)
                {
                    throw new Exception("Error al intentar crear la factura: " + ex.Message);
                }
            }
        }

        public Factura getFacturaDao(int nro_factura)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                try
                {
                    var facturaExiste = context.Factura.Find(nro_factura);
                    if(facturaExiste != null)
                    {
                        return facturaExiste;
                    }else
                    {
                        return null;
                    }
                }catch (Exception ex)
                {
                    throw new Exception("Error al intentar obtener la factura" + ex.Message);
                }
            }
        }

        public List<Factura> getFacturasDao()
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                try
                {
                    List<Factura> facturas = context.Factura.ToList();
                    return facturas;
                }catch(Exception ex)
                {
                    throw new Exception("Error al intentar obtener todas las facturas" + ex.Message);
                }
            }
        }

        public Factura getFacturaPorNumeroVenta(int numeroVenta)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                try
                {
                    // Busca la factura por el número de venta
                    var facturaExiste = context.Factura.FirstOrDefault(f => f.cod_venta == numeroVenta);
                    if (facturaExiste != null)
                    {
                        return facturaExiste;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al intentar obtener la factura por número de venta: " + ex.Message);
                }
            }
        }

    }
}
