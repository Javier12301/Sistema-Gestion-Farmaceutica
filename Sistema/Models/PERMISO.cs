//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERMISO
    {
        public int PermisoID { get; set; }
        public Nullable<int> RolID { get; set; }
        public string NombreMenu { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
    
        public virtual ROL ROL { get; set; }
    }
}