using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Modelo;


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
    }
}
