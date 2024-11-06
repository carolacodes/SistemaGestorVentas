using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaGestorDeVentas.api.product
{
    internal class ProductDao
    {
        private string connectionString = "tu_cadena_de_conexion"; // Especifica tu cadena de conexión aquí

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

        public Producto deleteProductDao(int codigo)
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
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

        public List<Producto> getProductByName(string name)
        {
            var productos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Nombre, Precio FROM Productos WHERE Nombre LIKE @name";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", "%" + name + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var producto = new Producto
                            {
                                id_producto = reader.GetInt32(0),
                                nombre = reader.GetString(1),
                                precio_venta = reader.GetFloat(2)
                            };
                            productos.Add(producto);
                        }
                    }
                }
            }
            return productos;
        }
    }
}

