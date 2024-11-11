using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.middleware
{
    internal class EstadoService
    {
        public List<Estado> getEstados()
        {
            using(var Context = new sistema_de_ventas_taller_Entities())
            {
                return Context.Estado.ToList();
            }
        }

        public Estado getEstado(int id)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                return context.Estado.Find(id);
            }
        }

        public int? GetEstadoIdByNombre(string nombreEstado)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                // Buscar el estado por el nombre
                var estado = context.Estado
                                    .FirstOrDefault(e => e.nombre == nombreEstado);

                // Retorna el id_estado si lo encuentra, o null si no.
                return estado?.id_estado;
            }
        }

    }
}
