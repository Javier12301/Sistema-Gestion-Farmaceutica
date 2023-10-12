using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Models;
using System.Data.Entity;
using System.Data;

namespace Sistema.Controles.Logica
{
    public class EstanteLogica
    {
        // Obtener cantidad total de estantes
        public int GetTotalShelvesCount()
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Obtenemos la cantidad de estantes e ignoramos el estante 0 que es el estante por defecto.
                    int shelves = db.EstantesModel.Where(x => x.EstanteID != 0).Count();
                    return shelves;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Obtener lista de Estantes
        public List<EstantesModel> GetShelves()
        {
            try
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
            catch (SqlException)
            {
                throw;
            }
        }
        

        // Obtener estante por ID
        public EstantesModel GetShelf(int shelfID)
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Obtenemos el estante por ID
                    EstantesModel shelf = db.EstantesModel.Find(shelfID);
                    return shelf;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Obtener 
        

        // Agregar Estantes
        public bool AddShelf(EstantesModel shelf)
        {
            try
            {
                using(var db = new SistemaGestionFarmaceuticaEntities())
                {
                    db.EstantesModel.Add(shelf);
                    db.Entry(shelf).State = EntityState.Added;
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

        // Modificar Estante
        public bool ModifyShelf(EstantesModel shelf) 
        {
            try
            {
                using(var db = new SistemaGestionFarmaceuticaEntities())
                {
                    EstantesModel originalShelf = db.EstantesModel.Find(shelf.EstanteID);

                    if(originalShelf != null)
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
            catch (SqlException)
            {
               
                throw;
            }

        }

        // Eliminar Estante
        public bool DeleteShelf(int shelfID)
        {
            try
            {
                using(var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Buscamos el estante que queremos eliminar
                    EstantesModel shelf = db.EstantesModel.Find(shelfID);
                    if(shelf != null)
                    {
                        db.EstantesModel.Remove(shelf);
                        db.Entry(shelf).State = EntityState.Deleted;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
        
        // Verificar si hay medicamentos en el estante
        public bool CheckIfShelfHasMedicines(int shelfID)
        {
            try
            {
                using(var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Buscamos el estante
                    EstantesModel shelf = db.EstantesModel.Find(shelfID);
                    if(shelf != null)
                    {
                        // Buscamos los medicamentos que esten en el estante
                        var medicines = db.MedicamentosModel.Where(medicine => medicine.EstanteID == shelfID).ToList();
                        if(medicines.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        // Si no existe el estante retornamos false
                        return false;
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Reasignar medicamentos al estante por defecto
        public bool ReassignMedicinesToDefaultShelf(int shelfID)
        {
            try
            {
                int shelfDefaultID = 0;
                using(var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Buscamos el estante por defecto
                    EstantesModel shelfDefault = db.EstantesModel.Find(shelfDefaultID);
                    if(shelfDefault != null)
                    {
                        // Buscamos los medicamentos que esten en el estante que queremos eliminar
                        var medicines = db.MedicamentosModel.Where(medicine => medicine.EstanteID == shelfID).ToList();
                        if(medicines.Count > 0)
                        {
                            // Recorremos la lista de medicamentos y los reasignamos al estante por defecto
                            foreach(var medicine in medicines)
                            {
                                medicine.EstanteID = shelfDefaultID;
                                db.Entry(medicine).State = EntityState.Modified;
                            }
                            db.SaveChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        // Si no existe el estante por defecto retornamos false
                        return false;
                    }
                }

            }catch (SqlException)
            {
                throw;
            }
        }

    }
}
