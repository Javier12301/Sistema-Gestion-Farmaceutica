using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Models;
using System.Data.Entity;
using System.Windows.Forms;

namespace Sistema.Controles.Logica
{
    public class CategoriaLogica
    {
        MedicamentoLogica medicineLogic = new MedicamentoLogica();
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

        // Obtener Categoria por ID
        public CategoriasModel GetCategory(int categoryID)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                // Obtenemos la categoria por ID
                CategoriasModel category = db.CategoriasModel.Find(categoryID);
                return category;
            }
        }

        // Agregar Categoria
        public bool AddCategory(CategoriasModel category)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                try
                {
                    db.CategoriasModel.Add(category);
                    db.Entry(category).State = EntityState.Added;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }


        // Modificar Categoria
        public bool ModifyCategory(CategoriasModel category)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                CategoriasModel originalCategory = GetCategory(category.CategoriaID);
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


        public bool DeleteCategory(int categoryID)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                // Buscamos la categoría por ID
                CategoriasModel category = db.CategoriasModel.Find(categoryID);
                if (category != null)
                {
                    bool hasAssociatedMedicine = medicineLogic.HasMedicineCategoryAssociated(db, categoryID);

                    if (hasAssociatedMedicine)
                    {
                        string categoryName = GetCategory(categoryID).Nombre;
                        string confirmationMessage = "Existen medicamentos asociados a la categoría: \"" + categoryName + "\". ¿Está seguro de que desea eliminar la categoría y reasignar los medicamentos como: \"sin categoría\"?";
                        DialogResult userConfirmation = MessageBox.Show(confirmationMessage, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (userConfirmation == DialogResult.Yes)
                        {
                            medicineLogic.ReassignDefaultCategoryMedicine(db, categoryID);
                        }
                        else
                        {
                            return false; // Se cancela la eliminación
                        }
                    }

                    db.CategoriasModel.Remove(category);
                    db.Entry(category).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false; // La categoría no existe
                }
            }
        }




        //public bool DeleteCategory(int categoryID)
        //{
        //    using (var db = new SistemaGestionFarmaceuticaEntities())
        //    {
        //        // Buscamos la categoría por ID
        //        CategoriasModel category = db.CategoriasModel.Find(categoryID);
        //        if (category != null)
        //        {
        //            bool hasAssociatedMedicine = db.MedicamentosModel.Any(m => m.CategoriaID == categoryID);

        //            if (hasAssociatedMedicine)
        //            {
        //                string categoryName = GetCategory(categoryID).Nombre;
        //                string confirmationMessage = "Existen medicamentos asociados a la categoría \"" + categoryName + "\". ¿Está seguro de que desea eliminar la categoría y reasignar los medicamentos a la categoría predeterminada?";
        //                DialogResult userConfirmation = MessageBox.Show(confirmationMessage, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //                if (userConfirmation == DialogResult.Yes)
        //                {
        //                    int defaultCategoryID = 0; // ID de la categoría predeterminada
        //                    var medicamentosToReassign = db.MedicamentosModel.Where(m => m.CategoriaID == categoryID);

        //                    foreach (var medicamento in medicamentosToReassign)
        //                    {
        //                        medicamento.CategoriaID = defaultCategoryID;
        //                        db.Entry(medicamento).State = EntityState.Modified;
        //                    }
        //                }
        //                else
        //                {
        //                    return false; // Se cancela la eliminación
        //                }
        //            }

        //            db.CategoriasModel.Remove(category);
        //            db.Entry(category).State = EntityState.Deleted;
        //            db.SaveChanges();
        //            return true;
        //        }
        //        else
        //        {
        //            return false; // La categoría no existe
        //        }
        //    }
        //}

    }
}
