using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.compra
{
    internal class CompraService
    {
        CompraDao compraDao = new CompraDao();

        public Compra crearCompra(Compra compraNueva)
        {
            try
            {
                var nuevaCompra = compraDao.crearCompraDao(compraNueva);
                return nuevaCompra;
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar crear una nueva compra: " + ex.Message);
            }
        }

        public Compra updateCompra(Compra compraActualizada)
        {
            try
            {
                var compra = compraDao.updateCompraDao(compraActualizada);
                return compra;
            } catch (Exception ex)
            {
                throw new Exception("Error al intentar modificar la compra: "+ ex.Message);
            }
        }
        
        public Compra deleteCompra(int id_compra)
        {
            try
            {
                var compra = compraDao.deleteCompraDao(id_compra);
                return compra;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar Eliminar la compra: " + ex.Message);
            }
        }

        public Compra GetCompra(int id_compra)
        {
            try
            {
                var compra = compraDao.getCompraDao(id_compra);
                return compra;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener la compra: " + ex.Message);
            }
        }

        public List<Compra> getCompras()
        {
            try
            {
                List<Compra> compras = compraDao.getComprasDao();
                return compras;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener las compra: " + ex.Message);
            }
        }
    }
}
