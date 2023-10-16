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
            using (var db = new SistemaGestionFarmaceuticaEntities())
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
                using (var db = new SistemaGestionFarmaceuticaEntities())
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

        // // // MANEJO DE LÓGICA DE CATEGORÍAS EN MEDICAMENTOS // // //
        // Lógica para obtener medicamentos pertenecientes a una categoría
        public bool HasMedicineCategoryAssociated(SistemaGestionFarmaceuticaEntities db, int categoryID)
        {
            return db.MedicamentosModel.Any(m => m.CategoriaID == categoryID);
        }

        // Lógica para reasignar medicamentos a una categoría predeterminada
        public void ReassignDefaultCategoryMedicine(SistemaGestionFarmaceuticaEntities db, int categoryID)
        {
            int defaultCategoryID = 0; // ID de la categoría predeterminada
            var medicineToReassing = db.MedicamentosModel.Where(m => m.CategoriaID == categoryID);

            foreach (var medicine in medicineToReassing)
            {
                medicine.CategoriaID = defaultCategoryID;
                db.Entry(medicine).State = EntityState.Modified;
            }
        }
        // // // FIN MANEJO DE LÓGICA DE CATEGORÍAS EN MEDICAMENTOS // // //

        // // // MANEJO DE LÓGICA DE ESTANTES EN MEDICAMENTOS // // //
        // Lógica para obtener medicamentos pertenecientes a una categoría
        public bool HasMedicineShelfAssociated(SistemaGestionFarmaceuticaEntities db, int shelfID)
        {
            return db.MedicamentosModel.Any(m => m.EstanteID == shelfID);
        }

        // Lógica para reasignar medicamentos a una categoría predeterminada
        public void ReassignDefaultShelfMedicine(SistemaGestionFarmaceuticaEntities db, int shelfID)
        {
            int defaultShelfID = 0; // ID de la categoría predeterminada
            var medicineToReassing = db.MedicamentosModel.Where(m => m.EstanteID == shelfID);

            foreach (var medicine in medicineToReassing)
            {
                medicine.EstanteID = defaultShelfID;
                db.Entry(medicine).State = EntityState.Modified;
            }
        }

        // // // FIN MANEJO DE LÓGICA DE ESTANTES EN MEDICAMENTOS // // //


        // Obtener todos los medicamentos para cargar el DatagridView utilizando view MedicamentoDetalle
        /*public List<MedicamentosDetalle> GetAllMedicineDetails()
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                var medicines = db.MedicamentosDetalle.ToList();
                return medicines;
            }
        }*/

        // Agregar a estantes por defecto
        /*
          using (var db = new SistemaGestionFarmaceuticaEntities())
                        {
                            if (hasMedicine)
                            {
                                userConfirmation = MessageBox.Show("Existen medicamentos asociados al estante: " + shelfLogic.GetShelf(selectedShelfID).Nombre + "\n¿Está seguro que desea eliminar el estante y reasignar los medicamentos al estante predeterminado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                // TERMINAR ELIMINAR
                                if (userConfirmation == DialogResult.Yes)
                                {
                                    // Reasignar medicamentos al estante predeterminado
                                    int defaultShelfID = 0; // ID del estante predeterminado "Sin Estante"
                                    db.MedicamentosModel
                                        .Where(m => m.EstanteID == selectedShelfID)
                                        .ToList()
                                        .ForEach(m => m.EstanteID = defaultShelfID);

                                    db.SaveChanges();
                                }
                                else
                                {
                                    return; // Cancelar la eliminación
                                }
                            }
                        }*/

    }
}
