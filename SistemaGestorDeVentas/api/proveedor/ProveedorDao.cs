using SistemaGestorDeVentas.api.cliente;
using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.proveedor
{
    internal class ProveedorDao
    {
        public Proveedor createProveedorDao(Proveedor nuevoProveedor)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
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
        public int? GetProveedorIdByName(string nombreProveedor)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                // Busca el proveedor por nombre
                var proveedor = context.Proveedor.FirstOrDefault(p => p.nombre == nombreProveedor);

                // Si encuentra el proveedor, devuelve su ID; de lo contrario, devuelve null
                return proveedor?.id_proveedor;
            }
        }
        public Proveedor getProveedorDao(int codigo)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var proveedor = context.Proveedor.Find(codigo);
                    return proveedor;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener un proveedor: " + ex.Message);
            }
        }

        public Proveedor updateProveedorDao(Proveedor proveedorActualizado)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var proveedorExistente = context.Proveedor.Find(proveedorActualizado.id_proveedor);
                    if (proveedorExistente != null)
                    {
                        proveedorExistente.email = proveedorActualizado.email;
                        proveedorExistente.telefono = proveedorActualizado.telefono;
                        proveedorExistente.direccion = proveedorActualizado.direccion;
                        proveedorExistente.web = proveedorActualizado.web;
                        proveedorExistente.id_estado = proveedorActualizado.id_estado;
                        context.SaveChanges();
                        return proveedorExistente;
                    }
                    // agregar un mensaje que diga que no se encuentra el cliente
                    return proveedorExistente;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al actualizar al cliente: " + ex.Message);
            }
        }

        public List<Proveedor> getProveedoresDao()
        {

            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    return context.Proveedor.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener todos los proveedores: " + ex.Message);
            }
        }

        public Proveedor deleteProveedor(string codigo)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {

                    var proveedor = context.Proveedor.Find(codigo);
                    if (proveedor != null)
                    {
                        proveedor.id_estado = 0;
                        // 0 = 'inactivo'
                        context.SaveChanges();
                        return proveedor;
                    }
                    // Agregar mensaje de no se encontro cliente
                    return proveedor;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar eliminar el proveedor: " + ex.Message);
            }
        }

        public List<Proveedor> getProveedorByNameDao(string name)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    return context.Proveedor
                    .Where(p => p.nombre.Contains(name))
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("no se encuentran clientes: " + ex.Message);
            }
        }
    }
}
