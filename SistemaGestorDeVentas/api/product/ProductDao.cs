using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaGestorDeVentas.api.category;
using System.Runtime.Remoting.Contexts;

namespace SistemaGestorDeVentas.api.product
{
    internal class ProductDao
    {
        private string connectionString = "tu_cadena_de_conexion"; // Especifica tu cadena de conexión aquí

        public Producto createProductDao(Producto nuevoProducto)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
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
                using (var context = new sistema_de_ventas_taller_Entities())
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
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    return context.Producto.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al obtener los productos: " + ex.Message);
            }
        }
        /*
                public Producto updateProductDao(Producto productoActualizado)
                {
                    try
                    {
                        using (var context = new sistema_de_ventas_taller_Entities())
                        {
                            var producto = context.Producto.Find(productoActualizado.codigo_producto);
                            if (producto != null)
                            {
                                producto.nombre = productoActualizado.nombre;
                                producto.descripcion = productoActualizado.descripcion;
                                producto.id_categoria = productoActualizado.id_categoria;
                                producto.precio_compra = productoActualizado.precio_compra;
                                producto.precio_venta = productoActualizado.precio_venta;
                                producto.stock = productoActualizado.stock;
                                producto.Estado = productoActualizado.Estado;
                                context.SaveChanges();
                                return producto;
                            }
                            return producto;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error al actualizar el producto: " + ex.Message);
                    }
                }
                */

        public Producto updateProductDao(Producto productoActualizado)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    // Deshabilitar carga diferida
                    context.Configuration.LazyLoadingEnabled = false;

                    var producto = context.Producto.Find(productoActualizado.codigo_producto);
                    if (producto != null)
                    {
                        producto.nombre = productoActualizado.nombre;
                        producto.descripcion = productoActualizado.descripcion;
                        producto.id_categoria = productoActualizado.id_categoria;
                        producto.precio_compra = productoActualizado.precio_compra;
                        producto.precio_venta = productoActualizado.precio_venta;
                        producto.stock = productoActualizado.stock;
                        producto.id_estado = productoActualizado.id_estado;

                        context.SaveChanges();
                    }

                    // Devolver el producto actualizado
                    return producto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el producto: " + ex.Message);
            }
        }
        public Producto deleteProductDao(int codigo)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var producto = context.Producto.Find(codigo);
                    if (producto != null)
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

        public List<Producto> getProductByNameDao(string name)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    return context.Producto
                    .Where(p => p.nombre.Contains(name))
                    .ToList();
                }
            }
            catch (Exception ex) {
                throw new Exception("no se encuentran productos: " + ex.Message);
            }

        }

        public List<Producto> getProductByCodeDao(int codigo)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    return context.Producto
                    .Where(p => p.codigo_producto.ToString().Contains(codigo.ToString()))
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("no se encuentran productos: " + ex.Message);
            }
        }

        public List<Producto> getProductByCategoryDao(string category)
        {
            try
            {
                CategoriaDao categoriaDao = new CategoriaDao();
                
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var categoria = categoriaDao.getCategoriaByNameDao(category);
                    int idCategoria = categoria.id_categoria;
                    return context.Producto
                    .Where(p => p.id_categoria == idCategoria)
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("no se encuentran productos: " + ex.Message);
            }
        }


        public Producto getProductByName(string nombreProducto)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    // Utilizamos LINQ para buscar el producto por nombre
                    Producto producto = context.Producto.FirstOrDefault(p => p.nombre == nombreProducto);
                    return producto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto por nombre: " + ex.Message);
            }
        }

        public int GenerateNewProductCode()
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                // Obtener el código más alto existente
                int? maxCode = context.Producto.Max(p => (int?)p.codigo_producto);

                // Si no hay productos, comienza en 1; de lo contrario, suma 1 al código más alto
                return (maxCode ?? 0) + 1;
            }
        }

    }
}

