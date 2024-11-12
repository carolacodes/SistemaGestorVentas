using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.cart
{
    internal class VentaDao
    {
        public Venta crearVenta(Venta nuevaVenta) {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var venta = context.Venta.Add(nuevaVenta);
                    context.SaveChanges();
                    return venta;
                }
            }
            catch (Exception ex) {
                throw new Exception("Error al insertar la venta: " + ex.Message)
            }
        }

        public Venta getVenta(int codigo_venta)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var venta = context.Venta.Find(codigo_venta);
                    return venta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la venta: " + ex.Message);
            }
        }

        public List<Venta> getVentas() {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var ventas = context.Venta.ToList();
                    return ventas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la venta: " + ex.Message);
            }
        }
    }
}