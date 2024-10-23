using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.cliente
{
    internal class ClienteDao
    {
        public Cliente CreateClienteDao(Cliente nuevoCliente)
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {

                    var cliente = context.Cliente.Add(nuevoCliente);
                    context.SaveChanges();
                    return cliente;
                }
            } catch(Exception ex)
            {
                throw new Exception("Error al intentar crear un nuevo cliente: "ex.Message);
            }
        }

        public Cliente updateClienteDao(Cliente clienteActualizado)
        {
            try
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
                        return clienteExistente;
                    }
                    // agregar un mensaje que diga que no se encuentra el cliente
                    return clienteExistente;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al actualizar al cliente: " + ex.Message);
            }
        }

        public Cliente deleteClienteDao(string DNI_cliente)
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {

                    var cliente = context.Cliente.Find(DNI_cliente);
                    if (cliente != null)
                    {
                        cliente.id_estado = 0;
                        // 0 = 'inactivo'
                        context.SaveChanges();
                        return cliente;
                    }
                    // Agregar mensaje de no se encontro cliente
                    return cliente;

                }
            }catch(Exception ex)
            {
                throw new Exception("Error al intentar eliminar el cliente: " + ex.Message);
            }
        }

        public List<Cliente> getClientesDao()
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {
                    return context.Cliente.ToList();
                }
            }catch(Exception ex)
            {
                throw new Exception("Error al intentar obtener todos los clentes: " + ex.Message);
            }
        }

        public Cliente getClienteDao(string dni)
        {
            try
            {
                using (var context = new sistema_de_ventas_Entities())
                {
                    var cliente = context.Cliente.Find(dni);
                    return cliente;
                }
            }catch(Exception ex){
                throw new Exception("Error al intentar obtener un cliente: " + ex.Message);
            }
        }
    }
}
