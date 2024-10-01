using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestorDeVentas.db;



namespace SistemaGestorDeVentas.api.cliente
{   

    internal class ClienteService
    {
        public void CreateCliente(Cliente nuevoCliente)
        {
            using (var context = new sistema_de_ventas_Entities())
            {
                context.Cliente.Add(nuevoCliente);
                context.SaveChanges();
            }
        }

        public void updateCliente(Cliente clienteActualizado)
        {
            using (var context = new sistema_de_ventas_Entities())
            {
                var clienteExistente = context.Cliente.Find(clienteActualizado.DNI_cliente);
                if (clienteExistente != null)
                {
                    clienteExistente.nombre = clienteActualizado.nombre;
                    clienteExistente.correo = clienteActualizado.correo;
                    clienteExistente.telefono = clienteActualizado.telefono;
                    clienteExistente.id_estado = clienteActualizado.id_estado;
                    context.SaveChanges();
                }
            }
        }

        public Cliente deleteCliente(string DNI_cliente)
        {
            using (var context = new sistema_de_ventas_Entities())
            {
                var cliente = context.Cliente.Find(DNI_cliente);
                if (cliente != null)
                {
                    cliente.id_estado = 0;
                    // 0 = 'inactivo'
                    context.SaveChanges();
                }
                return cliente;
            }
        }

        public List<Cliente> getClientes()
        {
            using (var context = new sistema_de_ventas_Entities())
            {
                return context.Cliente.ToList();
            }
        }

        public Cliente getCliente(string dni)
        {
            using (var context = new sistema_de_ventas_Entities())
            {
                var cliente = context.Cliente.Find(dni);
                return cliente;
            }
        }

    }
}
