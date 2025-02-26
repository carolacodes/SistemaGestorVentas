﻿using SistemaGestorDeVentas.api.user;
using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaGestorDeVentas.api.product
{
    internal class ProductService
    {
        ProductDao productDao = new ProductDao();

        public Producto createProductService(Producto nuevoProducto)
        {
            try
            {
                var producto = productDao.createProductDao(nuevoProducto);
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("error al crear el producto: " + ex.Message);
            }
        }

        public Producto getProductService(int codigo)
        {
            try
            {
                var producto = productDao.getProductDao(codigo);
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar el producto: " + ex.Message);
            }
        }

        public bool updateProductoCompraService(int codigo, decimal nuevoPrecio)
        {
            try
            {
                return productDao.updateProductoCompraDao(codigo, nuevoPrecio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la actualización del precio de compra: " + ex.Message);
            }
        }

        public Producto getProductServiceByName(string nombre)
        {
            try
            {
                Producto producto = productDao.getProductByName(nombre);
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("error al buscar el producto: " + ex.Message);
            }
        }

        public List<Producto> getProductsService()
        {
            try
            {
                var products = productDao.getProductsDao();
                return products;
            } catch (Exception ex)
            {
                throw new Exception("error al buscar los productos: " + ex.Message);
            }
        }

        public Producto updateProductService(Producto productoActualizado)
        {
            try
            {
                //productoActualizado.precio_venta = productoActualizado.precio_venta;
                var producto = productDao.updateProductDao(productoActualizado);
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("error al actualizar el producto: " + ex.Message);
            }
        }
        
    

        public Producto deleteProductService(int codigo)
        {
            try
            {
                var producto = productDao.deleteProductDao(codigo);
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("error al eliminar el producto: " + ex.Message);
            }
        }

        public List<Producto> getProductByCategory(string category)
        {
            try
            {
                var producto = productDao.getProductByCategoryDao(category);
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("error al encontrar el productos: " + ex.Message);
            }
        }

        public List<Producto> getProductByName(string name)
        {
            try
            {
                var producto = productDao.getProductByNameDao(name);
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("error al encontrar el productos: " + ex.Message);
            }
        }

        public List<Producto> getProductByCode(int codigo)
        {
            try
            {
                var producto = productDao.getProductByCodeDao(codigo);
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("error al encontrar el productos: " + ex.Message);
            }
        }

        public int GenerateNewProductCode()
        {
            return productDao.GenerateNewProductCode();
        }

    }
}
