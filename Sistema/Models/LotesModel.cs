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
    
    public partial class LotesModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LotesModel()
        {
            this.MedicamentosLotesModel = new HashSet<MedicamentosLotesModel>();
        }
    
        public int LoteID { get; set; }
        public string Numero_Lote { get; set; }
        public int Stock { get; set; }
        public string Nombre_Medicamento { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicamentosLotesModel> MedicamentosLotesModel { get; set; }
    }
}