using SistemaGestorDeVentas.api.product;
using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.cart
{
    internal class VentaService
    {
        VentaDao ventaDao = new VentaDao();
        ProductDao productoDao = new ProductDao();


        public Venta crearVenta(Venta nuevaVenta)
        {
            try
            {
                var venta = ventaDao.crearVenta(nuevaVenta);


                return venta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar crear una venta: " + ex.InnerException?.Message ?? ex.Message);
            }
        }

        public Venta crearVenta(Venta nuevaVenta, Producto producto, Producto_Venta productoVenta)
        {
            try
            {
                var productoModif = producto;
                    productoModif.stock = productoModif.stock - productoVenta.cantidad;
                productoDao.updateProductDao(productoModif);
                var venta = ventaDao.crearVenta(nuevaVenta);

                return venta;
            }catch(Exception ex)
            {
                throw new Exception("Error al intentar crear una venta" + ex.Message);
            }
        }
        public List<Venta> getVentas()
        {
            try
            {
                List < Venta > ventas = ventaDao.getVentas();
                return ventas;

            }catch(Exception ex)
            {
                throw new Exception("Error al intentar obtener las ventas" + ex.Message);
            }
        }

        public Venta getVenta(int nroVenta)
        {
            try
            {
                var venta = ventaDao.getVenta(nroVenta);
                return venta;
            }catch(Exception ex)
            {
                throw new Exception("Error al intentar obtener una venta" + ex.Message);
            }
        }

    }
}
