using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.product
{
    internal class ProductoCompraService
    {
        ProductoCompraDao prodCompraDao = new ProductoCompraDao();
        public Producto_Compra createProductoCompraService(Producto_Compra nuevoProductoCompra)
        {
            try
            {
                
                var productoCompra = prodCompraDao.createProductoCompraDao(nuevoProductoCompra);
                return productoCompra;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el producto: " + ex.Message +
                            (ex.InnerException != null ? " - Detalle: " + ex.InnerException.Message : ""));
            }
        }

        public Producto_Compra getProductoCompraService(int codigo)
        {
            try
            {
                var producto = prodCompraDao.getProductoCompraDao(codigo);
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar el producto: " + ex.Message);
            }
        }

        public List<Producto_Compra> getProductosCompraService(int codigo)
        {
            try
            {
                List<Producto_Compra> productos = prodCompraDao.getProductosCompraDao(codigo);
                return productos;
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar el producto: " + ex.Message);
            }
        }
    }
}
