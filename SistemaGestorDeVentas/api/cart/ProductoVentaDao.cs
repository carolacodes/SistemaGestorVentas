using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.cart
{
    internal class ProductoVentaDao
    {

        public Producto_Venta crearProductoVentaDao(Producto_Venta prodVentaNuevo)
        {
            try
            {
                using(var context = new sistema_de_ventas_taller_Entities())
                {
                    Producto_Venta prodVenta = context.Producto_Venta.Add(prodVentaNuevo);
                    context.SaveChanges();
                    return prodVenta;
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Producto_Venta> getProductVenteByCodVenta(int cod_venta)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    List<Producto_Venta> prodVentas = context.Producto_Venta
                                                     .Where(p => p.cod_venta == cod_venta)
                                                     .ToList();
                    return prodVentas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
