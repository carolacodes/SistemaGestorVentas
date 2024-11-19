using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.negocio
{
    internal class NegocioDao
    {

        public Negocio crearNegocio(Negocio negocioNuevo)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var negocio = context.Negocio.Add(negocioNuevo);
                    context.SaveChanges();
                    return negocio;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar crear un nuevo cliente: " + ex.Message);
            }
        }

        public Negocio getNegocio(int id_negocio)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    Negocio negocioEncontrado = context.Negocio.Find(id_negocio);
                    if (negocioEncontrado != null)
                    {
                        return negocioEncontrado;
                    }
                    else
                    {
                        return null;
                    }
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Negocio updateNegocio(Negocio negocioActualizado)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    Negocio negocioEncontrado = context.Negocio.Find(negocioActualizado.id_negocio);
                    if(negocioEncontrado != null)
                    {
                        negocioEncontrado.nombre = negocioActualizado.nombre;
                        negocioEncontrado.rut = negocioActualizado.rut;
                        negocioEncontrado.direccion = negocioActualizado.direccion;
                        negocioEncontrado.imagen = negocioActualizado.imagen;
                        
                        return negocioEncontrado;
                    }
                    else
                    {
                        return null;
                    }
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Negocio getNegocioByName(string nombre_negocio)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    // Buscar el negocio por su nombre en la base de datos
                    Negocio negocioEncontrado = context.Negocio
                        .FirstOrDefault(n => n.nombre == nombre_negocio);

                    return negocioEncontrado; // Retorna el negocio si se encuentra o null si no
                }
            }
            catch (Exception ex)
            {
                // Lanza una excepción con el mensaje del error
                throw new Exception("Error al buscar el negocio por nombre: " + ex.Message);
            }
        }
    }
}
