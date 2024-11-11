using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SistemaGestorDeVentas.db;



namespace SistemaGestorDeVentas.api.cliente
{

    internal class ClienteService
    {
        ClienteDao clienteDao = new ClienteDao();

        public Cliente createCliente(Cliente nuevoCliente) {
            try
            {
                var cliente = clienteDao.createClienteDao(nuevoCliente);
                return cliente;
            }catch(Exception ex)
            {
                throw new Exception("Error al crear el cliente: " + ex.Message);
            }
        }

        public Cliente updateCliente(Cliente clienteActualizado)
        {
            try
            {
                var cliente = clienteDao.updateClienteDao(clienteActualizado);
                return cliente;
            }catch(Exception ex)
            {
                throw new Exception("Error al modificar los datos del cliente: " + ex.Message);
            }
        }

        public Cliente deleteCliente(string dni) {
            try
            {
                var cliente = clienteDao.deleteClienteDao(dni);
                return cliente;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al intentar eliminar el cliente: " + ex.Message);
            }
        }

        public List<Cliente> getClientes() {
            try
            {
                List<Cliente> clientes = clienteDao.getClientesDao();
                return clientes;
            }catch(Exception ex)
            {
                throw new Exception("Error al intentar obtener todos los clientes: " + ex.Message);
            }
        }

        public Cliente getCliente(string dni) {
            try
            {
                var cliente = clienteDao.getClienteDao(dni);
                return cliente;
            }catch(Exception ex)
            {
                throw new Exception("Error al intentar obtener el cliente: " + ex.Message);
            }
        }

        public List<Cliente> getClienteByName(string name)
        {
            try
            {
                var clientes = clienteDao.getClienteByNameDao(name);
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar clientes: " + ex.Message);
            }
        }
    }
}
