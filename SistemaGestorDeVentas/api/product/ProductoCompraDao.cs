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

        public Producto_Compra getProductoCompraDao(int codigo)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var producto = context.Producto_Compra.Find(codigo);
                    return producto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar el producto: " + ex.Message);
            }
        }

        public List<Producto_Compra> getProductosCompraDao(int idCompra)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    // Consulta para obtener todos los productos asociados al id_compra especificado
                    var productosCompra = context.Producto_Compra
                                                 .Where(pc => pc.id_compra == idCompra)
                                                 .ToList();
                    return productosCompra;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar los productos de la compra: " + ex.Message);
            }
        }
    }
}
