using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Controles.Logica
{
    public class ProveedorLogica
    {
        MedicamentoLogica medicineLogic = new MedicamentoLogica();
        // Obtener lista de Proveedores
        

        public List<PROVEEDOR> GetSuppliers()
        {
            using (var db = new FarmaciaDBEntities())
            {
                var suppliers = db.PROVEEDOR.Where(supplier => supplier.ProveedorID != 0).Select(supplier => new
                {
                    ProveedorID = supplier.ProveedorID,
                    RazonSocial = supplier.RazonSocial, 
                    Documento = supplier.Documento, 
                    Direccion = supplier.Direccion,
                    TelefonoProveedor = supplier.TelefonoProveedor, 
                    Correo = supplier.Correo, // Nuevo campo
                }).ToList();

                List<PROVEEDOR> suppliersList = suppliers.Select(supplier => new PROVEEDOR
                {
                    ProveedorID = supplier.ProveedorID,
                    RazonSocial = supplier.RazonSocial, 
                    Documento = supplier.Documento, 
                    Direccion = supplier.Direccion,
                    TelefonoProveedor = supplier.TelefonoProveedor, 
                    Correo = supplier.Correo, 
                }).ToList();

                return suppliersList;
            }
        }

        // Obtener Proveedor por ID
        public PROVEEDOR GetSupplier(int supplierID)
        {
            using (var db = new FarmaciaDBEntities())
            {
                // Obtenemos el proveedor por ID
                PROVEEDOR supplier = db.PROVEEDOR.Find(supplierID);
                return supplier;
            }
        }

        // Agregar Proveedor
        public bool AddSupplier(PROVEEDOR supplier)
        {
            using (var db = new FarmaciaDBEntities())
            {
                try
                {
                    db.PROVEEDOR.Add(supplier);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        // Modificar Proveedor
        public bool ModifySupplier(PROVEEDOR supplier)
        {
            using (var db = new FarmaciaDBEntities())
            {
                PROVEEDOR originalSupplier = GetSupplier(supplier.ProveedorID);
                if (originalSupplier != null)
                {
                    originalSupplier.RazonSocial = supplier.RazonSocial;
                    originalSupplier.Documento = supplier.Documento;
                    originalSupplier.Direccion = supplier.Direccion;
                    originalSupplier.TelefonoProveedor = supplier.TelefonoProveedor;
                    originalSupplier.Correo = supplier.Correo;
                    db.Entry(originalSupplier).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // Eliminar Proveedor
        public bool DeleteSupplier(int supplierID)
        {
            using (var db = new FarmaciaDBEntities())
            {
                try
                {
                    PROVEEDOR supplier = db.PROVEEDOR.Find(supplierID);
                    db.PROVEEDOR.Remove(supplier);
                    db.Entry(supplier).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }


    }
}
