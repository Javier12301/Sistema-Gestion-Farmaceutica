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
    
    public partial class MedicamentosProveedoresModel
    {
        public int MedicamentoProveedorID { get; set; }
        public Nullable<int> MedicamentoID { get; set; }
        public Nullable<int> ProveedorID { get; set; }
    
        public virtual MedicamentosModel MedicamentosModel { get; set; }
        public virtual ProveedoresModel ProveedoresModel { get; set; }
    }
}
