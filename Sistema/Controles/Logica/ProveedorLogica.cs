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
        public List<ProveedoresModel> GetSuppliers()
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                var suppliers = db.ProveedoresModel.Where(supplier => supplier.ProveedorID != 0).Select(supplier => new
                {
                    ProveedorID = supplier.ProveedorID,
                    Nombre = supplier.Nombre,
                    Direccion = supplier.Direccion,
                    Telefono = supplier.Telefono,
                }).ToList();
                List<ProveedoresModel> suppliersList = suppliers.Select(supplier => new ProveedoresModel
                {
                    ProveedorID = supplier.ProveedorID,
                    Nombre = supplier.Nombre,
                    Direccion = supplier.Direccion,
                    Telefono = supplier.Telefono,
                }).ToList();
                return suppliersList;
            }
        }

        // Obtener Proveedor por ID
        public ProveedoresModel GetSupplier(int supplierID)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                // Obtenemos el proveedor por ID
                ProveedoresModel supplier = db.ProveedoresModel.Find(supplierID);
                return supplier;
            }
        }

        // Agregar Proveedor
        public bool AddSupplier(ProveedoresModel supplier)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                try
                {
                    db.ProveedoresModel.Add(supplier);
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
        public bool ModifySupplier(ProveedoresModel supplier)
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                ProveedoresModel originalSupplier = GetSupplier(supplier.ProveedorID);
                if (originalSupplier != null)
                {
                    originalSupplier.Nombre = supplier.Nombre;
                    originalSupplier.Direccion = supplier.Direccion;
                    originalSupplier.Telefono = supplier.Telefono;
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
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                try
                {
                    ProveedoresModel supplier = db.ProveedoresModel.Find(supplierID);
                    db.ProveedoresModel.Remove(supplier);
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
