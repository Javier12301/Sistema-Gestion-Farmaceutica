using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Modelo;


namespace Sistema.Controles.Logica
{
    public class MedicamentoLogica
    {
        // Obtener cantidad total de medicamentos
        public int GetTotalMedicinesCount()
        {
            using (var db = new SistemaGestionFarmaceuticaEntities())
            {
                int medicines = db.MedicamentosModel.Count();
                return medicines;
            }
        }


    }
}
