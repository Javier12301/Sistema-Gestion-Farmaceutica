using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Modelo;
using System.Data.Entity;

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
                    int shelves = db.EstantesModel.Count();
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
                    var shelves = db.EstantesModel.Select(shelf => new
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
        


    }
}
