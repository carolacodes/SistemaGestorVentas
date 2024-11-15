using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.product
{
    internal class ProductoCompraDao
    {
        public Producto_Compra createProductoCompraDao(Producto_Compra nuevoProductoCompra)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var productoCompra = context.Producto_Compra.Add(nuevoProductoCompra);
                    context.SaveChanges();
                    return productoCompra;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al crear el producto: " + ex.Message);
            }
        }
    }
}
