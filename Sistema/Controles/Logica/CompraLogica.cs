using Microsoft.SqlServer.Server;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Controles.Logica
{
    public class CompraLogica
    {
        // Generar Detalle de Compra
        DETALLE_COMPRA detail = new DETALLE_COMPRA();

        public bool GeneratePurchaseDetail(int medicineID, int productID,int userID, int purchasePrice, int salePrice, int quantity, int total)
        {
            using (var db = new FarmaciaDBEntities())
            {
                try
                {
                    if (medicineID != 0)
                    {
                        detail.ProductoID = 0;
                        detail.CompraID = userID;
                        detail.MedicamentoID = medicineID;
                        detail.PrecioCompra = purchasePrice;
                        detail.PrecioVenta = salePrice;
                        detail.Cantidad = quantity;
                        detail.MontoTotal = total;
                        detail.FechaRegistro = DateTime.Now;
                        db.DETALLE_COMPRA.Add(detail);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        detail.ProductoID = productID;
                        detail.MedicamentoID = 0;
                        detail.Cantidad = quantity;
                        detail.PrecioCompra = purchasePrice;
                        detail.PrecioVenta = salePrice;
                        detail.MontoTotal = total;
                        detail.FechaRegistro = DateTime.Now;
                        db.DETALLE_COMPRA.Add(detail);
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }

        // Identificación correlativa de la compra
        public int GetCorrelativePurchaseID()
        {
            using (var db = new FarmaciaDBEntities())
            {
                int purchaseID = db.COMPRA.Count() + 1;
                return purchaseID;
            }
        }
    }
}
