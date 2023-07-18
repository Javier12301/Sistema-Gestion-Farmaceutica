using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Database.Modelo
{
    public class Lote
    {
        public int LoteID { get; set; }
        public int Stock { get; set; }
        public string NombreMedicamento { get; set; }
        public DateTime Vencimiento { get; set; }
    }
}
