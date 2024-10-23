using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.product
{
    internal class ProductDao
    {
        public Producto createProductDao(Producto nuevoProducto)
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {
                    var producto = context.Producto.Add(nuevoProducto);
                    context.SaveChanges();
                    return producto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al crear el producto: " + ex.Message);
            }
        }

        public Producto getProductDao(int codigo)
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {
                    var producto = context.Producto.Find(codigo);
                    return producto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar el producto: " + ex.Message);
            }
        }

        public List<Producto> getProductsDao()
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {
                    return context.Producto.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al obtener los productos: " + ex.Message);
            }
        }

        public Producto updateProductDao(Producto productoActualizado)
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {
                    var producto = context.Producto.Find(productoActualizado.id_producto);
                    if (producto != null)
                    {
                        producto.nombre = productoActualizado.nombre;
                        producto.descripcion = productoActualizado.descripcion;
                        producto.id_categoria = productoActualizado.id_categoria;
                        producto.precio_compra = productoActualizado.precio_compra;
                        producto.precio_venta = productoActualizado.precio_venta;
                        producto.stock = productoActualizado.stock;
                        producto.Estado = productoActualizado.Estado;
                    }
                    return producto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al actualizar el producto: " + ex.Message);
            }
        }

        public Producto deleteProductDao(int codigo)
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {
                    var producto = context.Producto.Find(codigo);
                    if (codigo != null)
                    {
                       producto.id_estado = 0;
                        // 0 = 'inactivo'
                        context.SaveChanges();

                    }

                    return producto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al eliminar el producto: " + ex.Message);
            }
        }


    }
}
