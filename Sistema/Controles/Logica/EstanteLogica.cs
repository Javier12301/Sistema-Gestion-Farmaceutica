using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Models;
using System.Data.Entity;
using System.Data;
using System.Windows.Forms;

namespace Sistema.Controles.Logica
{
    public class EstanteLogica
    {
        MedicamentoLogica medicineLogic = new MedicamentoLogica();
        // Obtener cantidad total de estantes
        public int GetTotalShelvesCount()
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                // Obtenemos la cantidad de estantes e ignoramos el estante 0 que es el estante por defecto.
                int shelves = db.EstantesModel.Where(x => x.EstanteID != 0).Count();
                return shelves;
            }
        }

        // Obtener lista de Estantes
        public List<EstantesModel> GetShelves()
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                // Obtenemos la lista de estantes pero solo los campos que necesitamos
                var shelves = db.EstantesModel.Where(shelf => shelf.EstanteID != 0).Select(shelf => new
                {
                    EstanteID = shelf.EstanteID,
                    Nombre = shelf.Nombre,
                    Numero_de_estante = shelf.Numero_de_estante,
                    Sector = shelf.Sector
                }).ToList();

                List<EstantesModel> shelvesList = shelves.Select(shelf => new EstantesModel
                {
                    EstanteID = shelf.EstanteID,
                    Nombre = shelf.Nombre,
                    Numero_de_estante = shelf.Numero_de_estante,
                    Sector = shelf.Sector
                }).ToList();

                return shelvesList;
            }
        }


        // Obtener estante por ID
        public EstantesModel GetShelf(int shelfID)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                // Obtenemos el estante por ID
                EstantesModel shelf = db.EstantesModel.Find(shelfID);
                return shelf;
            }
        }

        // Obtener 


        // Agregar Estantes
        public bool AddShelf(EstantesModel shelf)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                db.EstantesModel.Add(shelf);
                db.Entry(shelf).State = EntityState.Added;
                db.SaveChanges();
                return true;
            }

        }

        // Modificar Estante
        public bool ModifyShelf(EstantesModel shelf)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                EstantesModel originalShelf = db.EstantesModel.Find(shelf.EstanteID);

                if (originalShelf != null)
                {
                    // Modificamos los campos
                    originalShelf.Nombre = shelf.Nombre;
                    originalShelf.Numero_de_estante = shelf.Numero_de_estante;
                    originalShelf.Sector = shelf.Sector;

                    // Establecemos el estado de la entidad como modificada y guardamos los cambios
                    db.Entry(originalShelf).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //// Eliminar Estante
        //public bool DeleteShelf(int shelfID)
        //{
        //    using (var db = new SistemaGestionFarmaceuticaEntities())
        //    {
        //        // Buscamos el estante que queremos eliminar
        //        EstantesModel shelf = db.EstantesModel.Find(shelfID);
        //        if (shelf != null)
        //        {
        //            db.EstantesModel.Remove(shelf);
        //            db.Entry(shelf).State = EntityState.Deleted;
        //            db.SaveChanges();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

        public bool DeleteShelf(int shelfID)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                // Buscamos la estante por ID
                EstantesModel shelf = db.EstantesModel.Find(shelfID);
                if (shelf != null)
                {
                    bool hasAssociatedMedicine = medicineLogic.HasMedicineShelfAssociated(db, shelfID);

                    if (hasAssociatedMedicine)
                    {
                        string shelfName = GetShelf(shelfID).Nombre;
                        string confirmationMessage = "Existen medicamentos asociados al estante: \"" + shelfName + "\". ¿Está seguro de que desea eliminar el estante y reasignar los medicamentos como \"sin estante\"?";
                        DialogResult userConfirmation = MessageBox.Show(confirmationMessage, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (userConfirmation == DialogResult.Yes)
                        {
                            medicineLogic.ReassignDefaultShelfMedicine(db, shelfID);
                        }
                        else
                        {
                            return false; // Se cancela la eliminación
                        }
                    }

                    db.EstantesModel.Remove(shelf);
                    db.Entry(shelf).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false; // La estante no existe
                }
            }
        }
    }
}
