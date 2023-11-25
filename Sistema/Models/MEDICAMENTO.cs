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
    
    public partial class MEDICAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICAMENTO()
        {
            this.DETALLE_VENTA = new HashSet<DETALLE_VENTA>();
        }
    
        public int MedicamentoID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> CategoriaID { get; set; }
        public Nullable<int> EstanteID { get; set; }
        public Nullable<int> ProveedorID { get; set; }
        public int Stock { get; set; }
        public Nullable<decimal> PrecioCompra { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<bool> Refrigerado { get; set; }
        public Nullable<bool> BajoReceta { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_VENTA> DETALLE_VENTA { get; set; }
        public virtual ESTANTE ESTANTE { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
