using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.proveedor
{
    internal class ProveedorDao
    {
        public Proveedor CreateProveedorDao(Proveedor nuevoProveedor)
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {

                    var proveedor = context.Proveedor.Add(nuevoProveedor);
                    context.SaveChanges();
                    return proveedor;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar crear un nuevo proveedor: "+ ex.Message);
            }
        }
    }
}
