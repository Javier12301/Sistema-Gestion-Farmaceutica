using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Controles.Logica
{
    public class ProductoLogica
    {
        public int GetTotalProductCount()
        {
            using (var db = new FarmaciaDBEntities())
            {
                int product = db.PRODUCTO.Count(m => m.ProductoID > 0);
                return product;
            }
        }
    }
}
