﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestorDeVentas.api.cliente;
using SistemaGestorDeVentas.db;

namespace SistemaGestorDeVentas.api.proveedor
{
    internal class ProveedorServices
    {
        ProveedorDao proveedorDao = new ProveedorDao();

        public Proveedor createProveedor(Proveedor nuevoProveedor)
        {
            try
            {
                var proveedor = proveedorDao.createProveedorDao(nuevoProveedor);
                return proveedor;
            } catch (Exception ex)
            {
                throw new Exception("Error al crear un nuevo proveedor: " + ex.Message);
            }
        }

        public Proveedor updateProveedor(Proveedor proveedorActualizado)
        {
            try
            {
                var proveedor = proveedorDao.updateProveedorDao(proveedorActualizado);
                return proveedor;
            }catch(Exception ex) 
            { 
                throw new Exception("Erro al intentar modificar los datos del proveedor" + ex.Message); 
            }
        }

        public Proveedor deleteProveedor(int codigo)
        {
            try
            {
                var proveedorEliminado = proveedorDao.deleteProveedor(codigo);
                return proveedorEliminado;
            } catch(Exception ex)
            {
                throw new Exception("Error al intentar eliminar el proveedor: " + ex.Message);
            }
        }

        public Proveedor getProveedor(int codigo)
        {
            try
            {
                var proveedor = proveedorDao.getProveedorDao(codigo);
                return proveedor;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al intentar obtener el proveedor: " + ex.Message);
            }
        }

        public List<Proveedor> getProveedores()
        {
            try
            {
                List<Proveedor> proveedores = proveedorDao.getProveedoresDao();
                return proveedores;
            } catch (Exception ex)
            {
                throw new Exception("Error al intenat obtener todos los proveedores: " + ex.Message);
            }
        }

        public List<Proveedor> getProveedorByName(string name)
        {
            try
            {
                var proveedores = proveedorDao.getProveedorByNameDao(name);
                return proveedores;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar proveedores: " + ex.Message);
            }
        }
    }
}
