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
using System.Data;

namespace Sistema.Controles.Logica
{
    public class CategoriaLogica
    {
        // Manejo de instancias usando contexto 
        

        
        // Devolver toList al datagridview para su datasource
        public List<CATEGORIA> CargarDataGridView()
        {
            using (var db = new FarmaciaDBEntities())
            {
                List<CATEGORIA> categories = db.CATEGORIA.ToList();
                return categories;
            }
        }

        // Obtener cantidad total de categorias
        public int CategoriaTotal()
        {
            using(var db = new FarmaciaDBEntities())
            {
                int categories = db.CATEGORIA.Count(c => c.CategoriaID > 0);
                return categories;
            }
        }


        public bool ExisteCategoria(int categoryID)
        {
            using (var db = new FarmaciaDBEntities())
            {
                bool doesCategoryExist = db.CATEGORIA.Any(c => c.CategoriaID == categoryID);
                return doesCategoryExist;
            }
        }


        // Obtener lista de Categorias
        public List<CATEGORIA> ObtenerCategorias(bool includeDefaultCategory)
        {
            using (var db = new FarmaciaDBEntities())
            {
                if (includeDefaultCategory)
                {
                    List<CATEGORIA> categories = db.CATEGORIA.ToList();
                    return categories;
                }
                else
                {
                    List<CATEGORIA> categories = db.CATEGORIA.Where(category => category.CategoriaID != 0).ToList();
                    return categories;
                }
            }

        }

        // Obtener Categoria por ID
        public CATEGORIA ObtenerCategoria(int categoryID)
        {
            using (var db = new FarmaciaDBEntities())
            {
                // Obtenemos la categoria por ID
                CATEGORIA category = db.CATEGORIA.Find(categoryID);
                return category;
            }
        }

        // Agregar Categoria
        public bool AgregarCategoria(CATEGORIA category)
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
        public bool ModificarCategoria(CATEGORIA category)
        {
            using (var db = new FarmaciaDBEntities())
            {
                CATEGORIA originalCategory = ObtenerCategoria(category.CategoriaID);
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


        public bool EliminarCategoria(int categoryID)
        {

            using (var db = new FarmaciaDBEntities())
            {
                // Buscamos la categoría por ID
                CATEGORIA category = db.CATEGORIA.Find(categoryID);
                MedicamentoLogica _medicinaLogica = new MedicamentoLogica();
                if (category != null)
                {
                    bool hasAssociatedMedicine = _medicinaLogica.HasMedicineCategoryAssociated(db, categoryID);

                    if (hasAssociatedMedicine)
                    {
                        string categoryName = ObtenerCategoria(categoryID).Nombre;
                        string confirmationMessage = $"Existen medicamentos asociados a la categoría: \"{categoryName}\". ¿Desea reasignar los medicamentos como \"sin categoría\" o cancelar la operación?";
                        DialogResult userConfirmation = MessageBox.Show(confirmationMessage, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (userConfirmation == DialogResult.Yes)
                        {
                            _medicinaLogica.ReassignDefaultCategoryMedicine(db, categoryID);
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
        //public bool EliminarCategoria(int categoryID)
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
        //                string categoryName = ObtenerCategoria(categoryID).Nombre;
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
