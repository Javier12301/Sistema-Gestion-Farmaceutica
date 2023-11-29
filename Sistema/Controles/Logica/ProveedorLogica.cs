using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Controles.Logica
{
    public class ProveedorLogica
    {
        MedicamentoLogica medicineLogic = new MedicamentoLogica();
        // Obtener lista de Proveedores


        public List<PROVEEDOR> GetSuppliers(bool includeDefaultShelf)
        {
            using (var db = new FarmaciaDBEntities())
            {
                if (includeDefaultShelf)
                {
                    List<PROVEEDOR> suppliers = db.PROVEEDOR.ToList();
                    return suppliers;
                }
                else
                {
                    List<PROVEEDOR> suppliers = db.PROVEEDOR.Where(supplier => supplier.ProveedorID != 0).ToList();
                    return suppliers;
                }
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

                    if (supplier != null)
                    {
                        bool hasAssociatedMedicine = medicineLogic.HasMedicineSupplierAssociated(db, supplierID);

                        if (hasAssociatedMedicine)
                        {
                            string supplierName = GetSupplier(supplierID).RazonSocial;
                            string confirmationMessage = $"Existen medicamentos asociados al proveedor: \"{supplierName}\". ¿Desea reasignar los medicamentos a otro proveedor o cancelar la operación?";
                            DialogResult userConfirmation = MessageBox.Show(confirmationMessage, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (userConfirmation == DialogResult.Yes)
                            {
                                medicineLogic.ReassignDefaultSupplierMedicine(db, supplierID);
                            }
                            else
                            {
                                return false; // Se cancela la eliminación
                            }
                        }

                        db.PROVEEDOR.Remove(supplier);
                        db.Entry(supplier).State = EntityState.Deleted;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false; // El proveedor no existe
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


    }
}
