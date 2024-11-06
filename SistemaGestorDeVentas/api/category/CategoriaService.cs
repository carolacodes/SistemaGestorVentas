using SistemaGestorDeVentas.api.cliente;
using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.category
{
    internal class CategoriaService
    {
        CategoriaDao categoriaDao = new CategoriaDao();
        public Categoria createCategoria(Categoria nuevaCategoria)
        {
            try
            {
                var categoria = categoriaDao.createCategoriaDao(nuevaCategoria);
                return categoria;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la categoria: " + ex.Message);
            }
        }

        public Categoria updateCateoria(Categoria categoriaActualizada)
        {
            try
            {
                var categoria = categoriaDao.updateCategoriaDao(categoriaActualizada);
                return categoria;
            }catch(Exception ex)
            {
                throw new Exception("Error al modificar la categoria: " + ex.Message);
            }
        }

        public Categoria getCategoria(int codigoCategoria)
        {
            try
            {
                var categoria = categoriaDao.getCategoriaDao(codigoCategoria);
                return categoria;
            } catch(Exception ex)
            {
                throw new Exception("Error al intentar obtener la categoria: " + ex.Message);
            }
        }

        public List<Categoria> getCategorias()
        {
            try{
                var categorias = categoriaDao.getCategoriasDao();
                return categorias;
            } catch(Exception ex)
            {
                throw new Exception("Error al intentar obtener todas las categorias: " + ex.Message)
            }
        }

    }
}
