using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.factura
{
    internal class FacturaService
    {
        FacturaDao facturaDao = new FacturaDao();

        public Factura crearFactura(Factura nuevaFactura)
        {
            try
            {
                var factura = facturaDao.crearFacturaDao(nuevaFactura);
                return factura;
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar crear la factura" + ex.Message);
            }
        }

        public Factura getFactura(int numero_factura)
        {
            try
            {
                var factura = facturaDao.getFacturaDao(numero_factura);
                return factura;
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener la factura" + ex.Message);
            }
        }


        public Factura getFacturaByNroVenta(int numero_venta)
        {
            try
            {
                var factura = facturaDao.getFacturaPorNumeroVenta(numero_venta);
                return factura;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener la factura" + ex.Message);
            }
        }


        public List<Factura> getFacturas()
        {
            try
            {
                List<Factura> facturas = facturaDao.getFacturasDao();
                return facturas;
            }catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener todas las facturas: " + ex.Message);
            }
        }
    }
}
