using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Database.Modelo
{
    public class Medicamento
    {
        // Propiedades de la tabla Medicamentos
        public int LoteID { get; set; }
        public int CategoriaID { get; set; }
        public int EstanteID { get; set; }
        public decimal PrecioUnitario { get; set; }

        // Propiedades relacionadas con el estante
        public string Nombre_Medicamento { get; set; }
        public int Stock { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string CategoriaNombre { get; set; }
        public string Nombre_Estante { get; set; }
        public string Sector { get; set; }
        public int Numero_Estante { get; set; }
    }
}
