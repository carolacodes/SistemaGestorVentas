using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.compra
{
    internal class CompraDao
    {
        public Compra crearCompraDao(Compra compraNueva)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                try
                {
                    var compra = context.Compra.Add(compraNueva);
                    context.SaveChanges();
                    return compra;
                }catch (Exception ex)
                {
                    throw new Exception("Error al intentar crear una compra: " + ex.Message);
                }
            }
        }

        public Compra updateCompraDao(Compra compraActualizada)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                try
                {
                    var compraExiste = context.Compra.Find(compraActualizada.id_compra);
                    if(compraExiste != null)
                    {
                        compraExiste.fecha = compraActualizada.fecha;
                        compraExiste.DNI_usuario = compraActualizada.DNI_usuario;
                        context.SaveChanges();
                        return compraExiste;
                    }
                    return null; //agregar un mensaje en la interfaz if null ...
                }catch (Exception ex)
                {
                    throw new Exception("Error al intentar modificar la compra"+ex.Message);
                }
            }
        }

        public List<Compra> getComprasDao()
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                try
                {
                    List<Compra> compras = context.Compra.ToList();
                    return compras;
                } catch(Exception ex)
                {
                    throw new Exception ("Error al intentar obtener todos las compras: "+ ex.Message)
                }
            }
        }

        public Compra getCompraDao(int id_compra)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                try
                {
                    var compra = context.Compra.Find(id_compra);
                    if (compra != null)
                    {
                        return compra;
                    }
                    return null; // agregar un mensaje en la interfaz if null...
                }catch(Exception ex)
                {
                    throw new Exception("Error al intentar obtener la compra: " + ex.Message);
                }
            }
        }


    }
}
