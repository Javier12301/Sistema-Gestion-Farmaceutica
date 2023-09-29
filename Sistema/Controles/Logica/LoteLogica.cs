using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Models;
using System.Data.Entity;
using System.Data.SqlClient;

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

        // Obtener lista de Lotes
        public List<LotesModel> GetLotesList()
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    var lotes = db.LotesModel.Select(lote => new
                    {
                        LoteID = lote.LoteID,
                        Nombre_Medicamento = lote.Nombre_Medicamento,
                        Stock = lote.Stock,
                        FechaVencimiento = lote.FechaVencimiento
                    }).ToList();

                    List<LotesModel> lotesList = lotes.Select(lote => new LotesModel
                    {
                        LoteID = lote.LoteID,
                        Nombre_Medicamento = lote.Nombre_Medicamento,
                        Stock = lote.Stock,
                        FechaVencimiento = lote.FechaVencimiento
                    }).ToList();

                    return lotesList;
                }
            }
            catch (SqlException)
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
                    db.Entry(lote).State = EntityState.Added;
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
