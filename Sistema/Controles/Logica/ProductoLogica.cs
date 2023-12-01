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

        public PRODUCTO GetProduct(int productID)
        {
            using (var db = new FarmaciaDBEntities())
            {
                PRODUCTO product = db.PRODUCTO.Find(productID);
                return product;
            }
        }

        public PRODUCTO GetProductByCode(string code)
        {
            using (var db = new FarmaciaDBEntities())
            {
                // Buscar producto por codigo, si no existe , retornar null
                try
                {
                    PRODUCTO product = db.PRODUCTO.Where(p => p.Codigo == code).FirstOrDefault();
                    return product;
                }catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
