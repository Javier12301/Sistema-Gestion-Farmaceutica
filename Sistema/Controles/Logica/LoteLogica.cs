using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Modelo;
using System.Data.Entity;

namespace Sistema.Controles.Logica
{
    public class LoteLogica
    {
        // Obtener Lote por ID
        public LotesModel GetLote(int loteID)
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    var lote = db.LotesModel.Where(x => x.LoteID == loteID).FirstOrDefault();
                    return lote;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Agregar un nuevo lote
        public bool AddLote(LotesModel lote)
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    db.LotesModel.Add(lote);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
