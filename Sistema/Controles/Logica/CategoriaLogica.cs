using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Models;
using System.Data.Entity;


namespace Sistema.Controles.Logica
{
    public class CategoriaLogica
    {
        // Obtener cantidad total de categorias
        public int GetTotalCategoriesCount()
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                int categories = db.CategoriasModel.Count();
                return categories;
            }
        }

        // Obtener lista de Categorias
        public List<CategoriasModel> GetCategories()
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    var categories = db.CategoriasModel.Where(category => category.CategoriaID != 0).Select(category => new
                    {
                        CategoriaID = category.CategoriaID,
                        Nombre = category.Nombre,
                        Descripcion = category.Descripcion
                    }).ToList();
                    List<CategoriasModel> categoriesList = categories.Select(category => new CategoriasModel
                    {
                        CategoriaID = category.CategoriaID,
                        Nombre = category.Nombre,
                        Descripcion = category.Descripcion
                    }).ToList();
                    return categoriesList;
                }
            }
            catch (SqlException)
            {
                throw;
            }

        }

        // Obtener Categoria por ID
        public CategoriasModel GetCategory(int categoryID)
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Obtenemos la categoria por ID
                    CategoriasModel category = db.CategoriasModel.Find(categoryID);
                    return category;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Agregar Categoria
        public bool AddCategory(CategoriasModel category)
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    db.CategoriasModel.Add(category);
                    db.Entry(category).State = EntityState.Added;
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
        

        // Modificar Categoria
        public bool ModifyCategory(CategoriasModel category)
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    CategoriasModel originalCategory = db.CategoriasModel.Find(category.CategoriaID);
                    if (originalCategory != null)
                    {
                        // Modificamos la categoria
                        originalCategory.Nombre = category.Nombre;
                        originalCategory.Descripcion = category.Descripcion;

                        // Guardamos los cambios
                        db.Entry(originalCategory).State = EntityState.Modified;
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

        // Eliminar Categoria
        public bool DeleteCategory(int categoryID)
        {
            try
            {
                using(var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Buscamos la categoria por ID
                    CategoriasModel category = db.CategoriasModel.Find(categoryID);
                    if(category != null)
                    {
                        // Eliminamos la categoria
                        db.CategoriasModel.Remove(category);
                        db.Entry(category).State = EntityState.Deleted;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }catch (SqlException)
            {
                throw;
            }
        }

        // Verificar si un medicamento tiene una categoria asignada
        public bool CheckIfMedicineHasCategory(int categoryID)
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Buscamos la categoria por ID
                    CategoriasModel category = db.CategoriasModel.Find(categoryID);
                    if (category != null)
                    {
                        // Verificamos si el medicamento tiene una categoria asignada
                        var medicines = db.MedicamentosModel.Where(medicine => medicine.CategoriaID == categoryID).ToList();
                        if (medicines.Count > 0)
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
                        // Si no existe la categoria retornamos false
                        return false;
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Reasignar medicamentos a la categoria por defecto (Sin Categoria)
        public bool ReassignMedicinesToDefaultCategory(int categoryID)
        {
            try
            {
                int categoryDefaultID = 0;
                using(var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Buscamos la categoria por defecto
                    CategoriasModel categoryDefault = db.CategoriasModel.Find(categoryDefaultID);
                    if(categoryDefault != null)
                    {
                        // Buscamos los medicamentos que pertenecen a la categoria que se va a eliminar
                        var medicines = db.MedicamentosModel.Where(medicine => medicine.CategoriaID == categoryID).ToList();
                        if(medicines.Count > 0)
                        {
                            // Recoremos la lista de medicamentos y los reasignamos a la categoria por defecto
                            foreach(var medicine in medicines)
                            {
                                medicine.CategoriaID = categoryDefaultID;
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
                        // Si no existe la categoria por defecto retornamos false
                        return false;
                    }
                }
               
            }
            catch (SqlException)
            {
                throw;
            }
        }

        // Reasignar medicamentos a la categoria por defecto (Sin Categoria)
        public bool ReassignMedicinesToCategory(int categoryID, int categoryReassignID)
        {
            try
            {
                using (var db = new SistemaGestionFarmaceuticaEntities())
                {
                    // Buscamos la categoria por defecto
                    CategoriasModel categoryReassign = db.CategoriasModel.Find(categoryReassignID);
                    if (categoryReassign != null)
                    {
                        // Buscamos los medicamentos que pertenecen a la categoria que se va a eliminar
                        var medicines = db.MedicamentosModel.Where(medicine => medicine.CategoriaID == categoryID).ToList();
                        if (medicines.Count > 0)
                        {
                            // Recoremos la lista de medicamentos y los reasignamos a la categoria por defecto
                            foreach (var medicine in medicines)
                            {
                                medicine.CategoriaID = categoryReassignID;
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
                        // Si no existe la categoria por defecto retornamos false
                        return false;
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /* using (var db = new EntityInventory())
                        {
                            if (hasMedicine)
                            {
                                userConfirmation = MessageBox.Show("Existen medicamentos asociados a la categoria" + categoryLogic.GetCategory(selectedCategoryId).Nombre + "\n¿Está seguro que desea eliminar la categoría y reasignar los medicamentos a la categoría predeterminada?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if(userConfirmation == DialogResult.Yes)
                                {
                                    // Reasignar medicamentos a la categoria predeterminada
                                    int defaultCategoryId = 0;
                                    db.MedicamentosModel
                                        .Where(m => m.CategoriaID == selectedCategoryId)
                                        .ToList()
                                        .ForEach(m => m.CategoriaID = defaultCategoryId);
                                    // Estado
                                    
                                    db.SaveChanges();
                                }
                                else
                                {
                                    return; // Se cancela la eliminación
                                }
                            }
                        } */

    }
}
