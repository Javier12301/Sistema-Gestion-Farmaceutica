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
            using (var db = new FarmaciaDBEntities())
            {
                // Obtenemos la cantidad de estantes e ignoramos el estante 0 que es el estante por defecto.
                int shelves = db.ESTANTE.Where(e => e.EstanteID > 0).Count();
                return shelves;
            }
        }

        // Obtener lista de Estantes
        public List<ESTANTE> GetShelves(bool includeDefaultShelf)
        {
            using (var db = new FarmaciaDBEntities())
            {
               if(includeDefaultShelf)
                {
                    // Obtendremos todo los estantes incluido el estante por defecto
                    List<ESTANTE> shelves = db.ESTANTE.ToList();
                    return shelves;
                }
                else
                {
                    List<ESTANTE> shelves = db.ESTANTE.Where(shelf => shelf.EstanteID != 0).ToList();
                    return shelves;
                }
            }
        }


        // Obtener estante por ID
        public ESTANTE GetShelf(int shelfID)
        {
            using (var db = new FarmaciaDBEntities())
            {
                // Obtenemos el estante por ID
                ESTANTE shelf = db.ESTANTE.Find(shelfID);
                return shelf;
            }
        }

        // Obtener 


        // Agregar Estantes
        public bool AddShelf(ESTANTE shelf)
        {
            using (var db = new FarmaciaDBEntities())
            {
                try
                {
                    db.ESTANTE.Add(shelf);
                    db.Entry(shelf).State = EntityState.Added;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        // Modificar Estante
        public bool ModifyShelf(ESTANTE shelf)
        {
            using (var db = new FarmaciaDBEntities())
            {
                ESTANTE originalShelf = GetShelf(shelf.EstanteID);

                if (originalShelf != null)
                {
                    // Modificamos los campos
                    originalShelf.Nombre = shelf.Nombre;
                    originalShelf.Numero = shelf.Numero;
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

        

        public bool DeleteShelf(int shelfID)
        {
            using (var db = new FarmaciaDBEntities())
            {
                // Buscamos la estante por ID
                ESTANTE shelf = db.ESTANTE.Find(shelfID);
                if (shelf != null)
                {
                    bool hasAssociatedMedicine = medicineLogic.HasMedicineShelfAssociated(db, shelfID);

                    if (hasAssociatedMedicine)
                    {
                        string shelfName = GetShelf(shelfID).Nombre;
                        string confirmationMessage = $"Existen medicamentos asociados al estante: \"{shelfName}\". ¿Desea reasignar los medicamentos como \"sin estante\" o cancelar la operación?";
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

                    db.ESTANTE.Remove(shelf);
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
