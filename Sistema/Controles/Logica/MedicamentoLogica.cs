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
    public class MedicamentoLogica
    {
        // Obtener cantidad total de medicamentos
        public int GetTotalMedicinesCount()
        {
            using (var db = new PharmacyDbContext())
            {
                int medicines = db.MedicamentosModel.Count();
                return medicines;
            }
        }

        // Agregar un nuevo medicamento
        public bool AddMedicine(MedicamentosModel medicine)
        {
            try
            {
                using (var db = new PharmacyDbContext())
                {
                    db.MedicamentosModel.Add(medicine);
                    db.Entry(medicine).State = EntityState.Added;
                    db.SaveChanges();
                    return true;
                }

            }
            catch (SqlException)
            {
                return false;
                throw;
            }
        }

        // Obtener todos los medicamentos para cargar el DatagridView utilizando view MedicamentoDetalle
        /*public List<MedicamentosDetalle> GetAllMedicineDetails()
        {
            using (var db = new PharmacyDbContext())
            {
                var medicines = db.MedicamentosDetalle.ToList();
                return medicines;
            }
        }*/


    }
}
