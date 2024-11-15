using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.cart
{
    internal class ProductoVentaService
    {
        ProductoVentaDao productoVentaDao = new ProductoVentaDao();
        public List<Producto_Venta> getProductVentaByCodVenta(int cod_venta)
        {
            try
            {
                List<Producto_Venta> productosVenta = productoVentaDao.getProductVenteByCodVenta(cod_venta);
                return productosVenta;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
