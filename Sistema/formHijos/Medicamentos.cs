using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.formHijos
{
    public partial class Medicamentos : Form
    {
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            formHijos.nuevoMedicamento formAgregarMedicamento = new formHijos.nuevoMedicamento();
            formAgregarMedicamento.ShowDialog();
        }
    }
}
