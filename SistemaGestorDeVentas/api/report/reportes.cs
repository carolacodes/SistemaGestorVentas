﻿using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaGestorDeVentas.api.report
{
    internal class reportes
    {/*
        public List<Venta> filtrarVentasPorVendedorYFecha(string id_vendedor, DateTime fechaInicio, DateTime fechaFin)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var ventas = context.Venta
                .Where(v => v.DNI_usuario == id_vendedor && v.fecha_venta >= fechaInicio && v.fecha_venta <= fechaFin)
                .ToList();

                return ventas;
            }
        }

        public List<Venta> filtrarVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var ventas = context.Venta
                    .Include(v => v.Pago) // Incluye la entidad Pago para acceder al total
                    .Where(v => v.fecha_venta >= fechaInicio && v.fecha_venta <= fechaFin)
                    .ToList();

                return ventas;
            }
        }
        */

        public List<Venta> filtrarVentasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                return context.Venta
                    .Include(v => v.Pago) // Incluye la entidad Pago si tiene una relación
                    .Where(v => v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta)
                    .ToList();
            }
        }

        public List<Venta> filtrarVentasPorVendedorYFecha(string usuarioId, DateTime fechaDesde, DateTime fechaHasta)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                return context.Venta
                    .Include(v => v.Pago) // Incluye la entidad Pago si tiene una relación
                    .Where(v => v.DNI_usuario == usuarioId && v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta)
                    .ToList();
            }
        }
        public List<ProductoMasVendido> ObtenerProductosMasVendidos(int topN)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var productosMasVendidos = context.Producto_Venta
                    .GroupBy(pv => pv.id_producto)
                    .Select(g => new ProductoMasVendido
                    {
                        ProductoId = g.Key,
                        NombreProducto = g.FirstOrDefault().Producto.nombre, // Accede a la relación Producto
                        CantidadVendida = g.Sum(pv => pv.cantidad)
                    })
                    .OrderByDescending(p => p.CantidadVendida)
                    .Take(topN)
                    .ToList();

                return productosMasVendidos;
            }
        }


        // Clase auxiliar para almacenar los productos más vendidos
        public class ProductoMasVendido
        {
            public int ProductoId { get; set; }
            public string NombreProducto { get; set; }
            public int CantidadVendida { get; set; }
        }

        public List<ProductoMasVendido> ObtenerProductosMasVendidosPorFecha(DateTime fechaInicio, DateTime fechaFin, int topN)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var productosMasVendidos = context.Producto_Venta
                    .Where(pv => pv.Venta.fecha_venta >= fechaInicio && pv.Venta.fecha_venta <= fechaFin) // Filtro de fechas
                    .GroupBy(pv => pv.id_producto)
                    .Select(g => new ProductoMasVendido
                    {
                        ProductoId = g.Key,
                        NombreProducto = g.FirstOrDefault().Producto.nombre, // Accede a la relación Producto
                        CantidadVendida = g.Sum(pv => pv.cantidad)
                    })
                    .OrderByDescending(p => p.CantidadVendida)
                    .Take(topN)
                    .ToList();

                return productosMasVendidos;
            }
        }

        public List<CategoriaMasVendida> ObtenerCategoriasMasVendidas(int topN)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var categoriasMasVendidas = context.Producto_Venta
                    .GroupBy(pv => pv.Producto.id_categoria)
                    .Select(g => new CategoriaMasVendida
                    {
                        CategoriaId = g.Key,
                        NombreCategoria = g.FirstOrDefault().Producto.Categoria.nombre, // Accede a la relación Categoria
                        CantidadVendida = g.Sum(pv => pv.cantidad)
                    })
                    .OrderByDescending(c => c.CantidadVendida)
                    .Take(topN)
                    .ToList();

                return categoriasMasVendidas;
            }
        }

        public List<CategoriaMasVendida> ObtenerCategoriasMasVendidasPorFecha(DateTime fechaInicio, DateTime fechaFin, int topN)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var categoriasMasVendidas = context.Producto_Venta
                    .Where(pv => pv.Venta.fecha_venta >= fechaInicio && pv.Venta.fecha_venta <= fechaFin) // Filtro de fechas
                    .GroupBy(pv => pv.Producto.id_categoria)
                    .Select(g => new CategoriaMasVendida
                    {
                        CategoriaId = g.Key,
                        NombreCategoria = g.FirstOrDefault().Producto.Categoria.nombre, // Accede a la relación Categoria
                        CantidadVendida = g.Sum(pv => pv.cantidad)
                    })
                    .OrderByDescending(c => c.CantidadVendida)
                    .Take(topN)
                    .ToList();

                return categoriasMasVendidas;
            }
        }
        public class CategoriaMasVendida
        {
            public int CategoriaId { get; set; }
            public string NombreCategoria { get; set; }
            public int CantidadVendida { get; set; }
        }

        public List<VentasPorVendedor> ObtenerCantidadVentasPorVendedor()
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var ventasPorVendedor = context.Venta
                    .GroupBy(v => new { v.DNI_usuario, v.Usuario.nombre })
                    .Select(g => new VentasPorVendedor
                    {
                        VendedorId = g.Key.DNI_usuario,             // Aquí será el DNI_usuario como string
                        NombreVendedor = g.Key.nombre,
                        CantidadVentas = g.Count()
                    })
                    .OrderByDescending(v => v.CantidadVentas)
                    .ToList();

                return ventasPorVendedor;
            }
        }

        public List<VentasPorVendedor> ObtenerCantidadVentasPorVendedorPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var ventasPorVendedor = context.Venta
                    .Where(v => v.fecha_venta >= fechaInicio && v.fecha_venta <= fechaFin)
                    .GroupBy(v => new { v.DNI_usuario, v.Usuario.nombre })  // Agrupar por el vendedor (DNI_usuario como string)
                    .Select(g => new VentasPorVendedor
                    {
                        VendedorId = g.Key.DNI_usuario,             // Aquí será el DNI_usuario como string
                        NombreVendedor = g.Key.nombre,
                        CantidadVentas = g.Count()      // Contar la cantidad de ventas para cada vendedor
                    })
                    .OrderByDescending(v => v.CantidadVentas)
                    .ToList();

                return ventasPorVendedor;
            }
        }

        public class VentasPorVendedor
        {
            public string VendedorId { get; set; }   // Asegúrate de que sea de tipo string
            public string NombreVendedor { get; set; }
            public int CantidadVentas { get; set; }
        }

        /*
        public List<KeyValuePair<int, decimal>> ObtenerVentasMensuales(int anio)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                return context.Venta
                    .Where(v => v.fecha_venta.Year == anio)
                    .GroupBy(v => v.fecha_venta.Month)
                    .Select(g => new KeyValuePair<int, decimal>(g.Key, g.Sum(v => v.Pago.total)))
                    .OrderBy(g => g.Key)
                    .ToList();
            }
        }
        */

        public List<KeyValuePair<int, decimal>> ObtenerVentasMensuales(int anio)
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var ventasMensuales = context.Venta
                    .Where(v => v.fecha_venta.Year == anio)
                    .GroupBy(v => v.fecha_venta.Month)
                    .Select(g => new { Mes = g.Key, Total = g.Sum(v => v.Pago.total) }) // Consulta en base de datos
                    .ToList() // Trae los datos a memoria
                    .Select(g => new KeyValuePair<int, decimal>(g.Mes, g.Total)) // Conversión en memoria
                    .OrderBy(g => g.Key)
                    .ToList();

                return ventasMensuales;
            }
        }

        /*
        public List<KeyValuePair<int, decimal>> ObtenerVentasAnuales()
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                return context.Venta
                    .GroupBy(v => v.fecha_venta.Year)
                    .Select(g => new KeyValuePair<int, decimal>(g.Key, g.Sum(v => v.Pago.total)))
                    .OrderBy(g => g.Key)
                    .ToList();
            }
        }

        */

        public List<KeyValuePair<int, decimal>> ObtenerVentasAnuales()
        {
            using (var context = new sistema_de_ventas_taller_Entities())
            {
                var ventasAnuales = context.Venta
                    .GroupBy(v => v.fecha_venta.Year)
                    .Select(g => new { Anio = g.Key, Total = g.Sum(v => v.Pago.total) }) // Proyección intermedia soportada
                    .ToList() // Trae los datos a memoria
                    .Select(g => new KeyValuePair<int, decimal>(g.Anio, g.Total)) // Conversión en memoria
                    .OrderBy(g => g.Key)
                    .ToList();

                return ventasAnuales;
            }
        }
    }
}
