//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaGestorDeVentas.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Historial_Estado
    {
        public System.DateTime fecha_estado { get; set; }
        public int id_estado_compra { get; set; }
        public int id_compra { get; set; }
    
        public virtual Compra Compra { get; set; }
        public virtual Estado_Compra Estado_Compra { get; set; }
    }
}
