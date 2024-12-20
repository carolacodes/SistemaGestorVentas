﻿using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.category
{
    internal class CategoriaDao
    {
        public Categoria createCategoriaDao(Categoria nuevaCategoria)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var categoria = context.Categoria.Add(nuevaCategoria);
                    context.SaveChanges();
                    return categoria;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al crear la categoria: " + ex.Message);
            }
        }

        public Categoria getCategoriaDao(int codigoCategoria)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var categoria = context.Categoria.Find(codigoCategoria);
                    return categoria;
                }
            }catch(Exception ex)
            {
                throw new Exception("error al buscar la categoria: " + ex.Message);
            }
        }

        public List<Categoria> getCategoriasDao()
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    return context.Categoria.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al obtener las categorias: " + ex.Message);
            }
        }

        public Categoria updateCategoriaDao(Categoria categoriaActualizada)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var categoria = context.Categoria.Find(categoriaActualizada.id_categoria);
                    if (categoria != null)
                    {
                        categoria.nombre = categoriaActualizada.nombre;
                        context.SaveChanges();
                    }
                    return categoria;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error al actualizar la categoria: " + ex.Message);
            }
        }

        public Categoria getCategoriaByNameDao(string name)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var categoria = context.Categoria.FirstOrDefault(c=> c.nombre.Contains(name));

                    if (categoria == null)
                    {
                        throw new Exception("La categoría no existe.");
                    }
                    else { 
                        return categoria;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("no se encuentra la categoria: " + ex.Message);
            }
        }

        public Categoria getCategoriaPorNombreDao(string nombreCategoria)
        {
            try
            {
                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var categoria = context.Categoria
                                            .FirstOrDefault(c => c.nombre == nombreCategoria);
                    return categoria;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la categoría por nombre: " + ex.Message);
            }
        }
    }
}
