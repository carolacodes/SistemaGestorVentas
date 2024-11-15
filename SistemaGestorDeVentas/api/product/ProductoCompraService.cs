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
                throw new Exception("error al crear el producto: " + ex.Message);
            }
        }

    }
}
