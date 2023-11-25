using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Models;
using System.Data.Entity;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace Sistema.Controles.Logica
{
    public class CategoriaLogica
    {
        MedicamentoLogica medicineLogic = new MedicamentoLogica();
        // Obtener cantidad total de categorias
        public int GetTotalCategoriesCount()
        {
            using (var db = new FarmaciaDBEntities())
            {
                // No contar ID 0
                int categories = db.CATEGORIA.Count(c => c.CategoriaID > 0);
                return categories;
            }
        }


        public bool IsCategoryExist(int categoryID)
        {
            using (var db = new FarmaciaDBEntities())
            {
                bool doesCategoryExist = db.CATEGORIA.Any(c => c.CategoriaID == categoryID);
                return doesCategoryExist;
            }
        }


        // Obtener lista de Categorias
        public List<CATEGORIA> GetCategories()
        {
            using (var db = new FarmaciaDBEntities())
            {
                var categories = db.CATEGORIA.Where(category => category.CategoriaID != 0).Select(category => new
                {
                    CategoriaID = category.CategoriaID,
                    Nombre = category.Nombre,
                    Descripcion = category.Descripcion
                }).ToList();
                List<CATEGORIA> categoriesList = categories.Select(category => new CATEGORIA
                {
                    CategoriaID = category.CategoriaID,
                    Nombre = category.Nombre,
                    Descripcion = category.Descripcion
                }).ToList();
                return categoriesList;
            }

        }

        // Obtener Categoria por ID
        public CATEGORIA GetCategory(int categoryID)
        {
            using (var db = new FarmaciaDBEntities())
            {
                // Obtenemos la categoria por ID
                CATEGORIA category = db.CATEGORIA.Find(categoryID);
                return category;
            }
        }

        // Agregar Categoria
        public bool AddCategory(CATEGORIA category)
        {
            using (var db = new FarmaciaDBEntities())
            {
                try
                {
                    db.CATEGORIA.Add(category);
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
        public bool ModifyCategory(CATEGORIA category)
        {
            using (var db = new FarmaciaDBEntities())
            {
                CATEGORIA originalCategory = GetCategory(category.CategoriaID);
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
            using (var db = new FarmaciaDBEntities())
            {
                // Buscamos la categoría por ID
                CATEGORIA category = db.CATEGORIA.Find(categoryID);
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

                    db.CATEGORIA.Remove(category);
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
        //    using (var db = new FarmaciaDBEntities())
        //    {
        //        // Buscamos la categoría por ID
        //        CATEGORIA category = db.CATEGORIA.Find(categoryID);
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

        //            db.CATEGORIA.Remove(category);
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
