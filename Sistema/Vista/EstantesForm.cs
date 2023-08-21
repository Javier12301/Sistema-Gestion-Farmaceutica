using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Controles;
using Sistema.Modelo;
using System.Media;
using Sistema.Controles.Logica;


namespace Sistema.Vista
{
    public partial class EstantesForm : Form
    {
        // Instancias de las clases de Control
        Controladora controladora = new Controladora();
        PaletaColores colorPalette = new PaletaColores();
        EstanteLogica shelfLogic = new EstanteLogica();

        public EstantesForm()
        {
            InitializeComponent();
        }

        private void Estantes_Load(object sender, EventArgs e)
        {
            loadShelvesData();
            btnGuardarG.Enabled = false;
        }

        private void txtNumE_KeyPress(object sender, KeyPressEventArgs e)
        {
            controladora.OnlyNumbers(e);
        }

        // Método para obtener los datos del datagridview
        private BindingSource bindingSourceShelves;

        private void loadShelvesData()
        {
            List<EstantesModel> shelvesList = shelfLogic.GetShelves();
            bindingSourceShelves = new BindingSource(shelvesList, null);

            // cargar los datos en el datagridview
            dtaIDEstante.DataPropertyName = "EstanteID";
            dtaNombreEstante.DataPropertyName = "Nombre";
            dtaNumEstante.DataPropertyName = "Numero_de_estante";
            dtaSectorEstante.DataPropertyName = "Sector";
            // Se asigna el binding source al datagridview
            dtaViewEstante.DataSource = bindingSourceShelves;
            dtaViewEstante.Columns["MedicamentosModel"].Visible = false;
            controladora.CheckEmptyDataGridView(dtaViewEstante, "dtaIDEstante");
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Model
            EstantesModel shelves = new EstantesModel();
            //Validaciones
            bool txtNombreEstante = controladora.VerifyTextBoxG(txtNombreE);
            bool txtNumEstante = controladora.VerifyTextBoxG(txtNumE);
            bool txtSectorEstante = controladora.VerifyTextBoxG(txtSectorE);
            if (txtNombreEstante && txtNumEstante && txtSectorEstante)

            {
                // Se utiliza la instancia de la clase Estante
                shelves.Nombre = txtNombreE.Text;
                shelves.Numero_de_estante = Convert.ToInt32(txtNumE.Text);
                shelves.Sector = txtSectorE.Text;

                bool resultado = shelfLogic.AddShelf(shelves);
                if (resultado)
                {
                    MessageBox.Show("Se agrego corectamente un nuevo estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se limpian los campos
                    txtNombreE.Text = "";
                    txtNumE.Text = "";
                    txtSectorE.Text = "";
                    // Se actualiza el datagridview
                    loadShelvesData();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, complete los campos!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento cuando se modifique una celda del datagridview
        private List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();
        private void btnGuardarG_Click(object sender, EventArgs e)
        {
            // Se crea una instancia de la clase Estante
            EstantesModel shelf = new EstantesModel();
            foreach (DataGridViewRow row in modifiedRows)
            {
                int _id = Convert.ToInt32(row.Cells["dtaIDEstante"].Value);
                string selectedShelfName = row.Cells["dtaNombreEstante"].Value.ToString();
                string selectedShelfNumber = row.Cells["dtaNumEstante"].Value.ToString();
                string selectedShelfSection = row.Cells["dtaSectorEstante"].Value.ToString();

                shelf.EstanteID = _id;
                shelf.Nombre = selectedShelfName;
                shelf.Numero_de_estante = Convert.ToInt32(selectedShelfNumber);
                shelf.Sector = selectedShelfSection;

                bool resultado = shelfLogic.ModifyShelf(shelf);
                if (resultado)
                {
                    MessageBox.Show("Se modifico corectamente el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Se actualiza el datagridview
                    loadShelvesData();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            modifiedRows.Clear();
            btnGuardarG.Enabled = false;
        }

        private void dtaViewEstante_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtaViewEstante.Rows[e.RowIndex];
            
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
                btnGuardarG.Enabled = true;        
        }

        // Evento para eliminar un estante

        private void btnEliminarG_Click(object sender, EventArgs e)
        {
            if (dtaViewEstante.SelectedRows.Count > 0)
            {
                // Se obtiene el id del estante seleccionado
                int selectedShelfID = Convert.ToInt32(dtaViewEstante.CurrentRow.Cells["dtaIDEstante"].Value);
                // se crea un cuadro de dialogo para confirmar la eliminacion
                DialogResult userConfirmation = MessageBox.Show("¿Está seguro que desea eliminar el estante?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userConfirmation == DialogResult.Yes)
                {        
                        bool deletionResult = shelfLogic.DeleteShelf(selectedShelfID);
                        if (deletionResult)
                        {
                            // Eliminar la fila del datagridview
                            EstantesModel shelf = (EstantesModel)bindingSourceShelves[dtaViewEstante.CurrentRow.Index];
                            bindingSourceShelves.Remove(shelf);
                            MessageBox.Show("Se elimino corectamente el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadShelvesData();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                                         
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnEliminarG_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 12;
        }

        private void btnEliminarG_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarG.Radius = 5;
        }


        // // // // Controles de colores utilizando la controladora // // // // //
        private void txtNombreE_Enter(object sender, EventArgs e)
        {
            txtNombreE.LineColor = colorPalette.ColorDisabled;
        }

        private void txtNumE_Enter(object sender, EventArgs e)
        {
            txtNumE.LineColor = colorPalette.ColorDisabled;
        }

        private void txtSectorE_Enter(object sender, EventArgs e)
        {
            txtSectorE.LineColor = colorPalette.ColorDisabled;
        }

        // Limitar solo número en la columa número de estante
        private void dtaViewEstante_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dtaViewEstante.CurrentCell.OwningColumn.Name == "dtaNumEstante") // Columna deseada
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }

        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }
        // 
    }
}
