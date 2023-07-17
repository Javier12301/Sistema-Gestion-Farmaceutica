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
using Sistema.Database.Logica;
using Sistema.Database.Modelo;

namespace Sistema.formHijos
{
    public partial class Estantes : Form
    {
        Controladora controladora = new Controladora();
        PaletaColores paleta = new PaletaColores();
        EstanteLogica estanteLogica = new EstanteLogica();
        Estante estante = new Estante();
        public Estantes()
        {
            InitializeComponent();
        }

        private void Estantes_Load(object sender, EventArgs e)
        {
            cargarDatosEstantes();
            btnGuardarG.Enabled = false;
        }

        private void txtNumE_KeyPress(object sender, KeyPressEventArgs e)
        {
            controladora.soloNumeros(e);
        }

        // Método para obtener los datos del datagridview
        private BindingSource bindingSourceEstantes;
        
        private void cargarDatosEstantes()
        {
            try
            {
                List<Estante> listaEstantes = estanteLogica.obtenerEstante();
                bindingSourceEstantes = new BindingSource(listaEstantes, null);

                // cargar los datos en el datagridview
                dtaIDEstante.DataPropertyName = "EstanteID";
                dtaNombreEstante.DataPropertyName = "Nombre";
                dtaNumEstante.DataPropertyName = "Num_Estante";
                dtaSectorEstante.DataPropertyName = "Sector";
                // Se asigna el binding source al datagridview
                dtaViewEstante.DataSource = bindingSourceEstantes;
                controladora.VerificarDataGridViewVacio(dtaViewEstante, "dtaIDEstante");
            }
            catch (SqlException ex)
            {
                throw;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validaciones
            bool txtNombreEstante = controladora.verificarTextboxG(txtNombreE);
            bool txtNumEstante = controladora.verificarTextboxG(txtNumE);
            bool txtSectorEstante = controladora.verificarTextboxG(txtSectorE);
            if (txtNombreEstante && txtNumEstante && txtSectorEstante)
            {
                // Se utiliza la instancia de la clase Estante
                estante.Nombre = txtNombreE.Text;
                estante.Num_Estante = Convert.ToInt32(txtNumE.Text);
                estante.Sector = txtSectorE.Text;

                try
                {
                    bool resultado = estanteLogica.agregarEstante(estante);
                    if (resultado)
                    {
                        MessageBox.Show("Se agrego corectamente un nuevo estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Se limpian los campos
                        txtNombreE.Text = "";
                        txtNumE.Text = "";
                        txtSectorE.Text = "";
                        // Se actualiza el datagridview
                        cargarDatosEstantes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }catch(SqlException ex)
                {
                   MessageBox.Show("Ocurrio un error al agregar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            foreach(DataGridViewRow row in modifiedRows)
            {
                int _id = Convert.ToInt32(row.Cells["dtaIDEstante"].Value);
                string _nombre = row.Cells["dtaNombreEstante"].Value.ToString();
                string _numE = row.Cells["dtaNumEstante"].Value.ToString();
                string _sector = row.Cells["dtaSectorEstante"].Value.ToString();

                estante.EstanteID = _id;
                estante.Nombre = _nombre;
                estante.Num_Estante = Convert.ToInt32(_numE);
                estante.Sector = _sector;
                try
                {
                    bool resultado = estanteLogica.modificarEstante(estante);
                    if (resultado)
                    {
                        MessageBox.Show("Se modifico corectamente el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Se actualiza el datagridview
                        cargarDatosEstantes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }catch(SqlException ex)
                {
                    throw;
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
                int _id = Convert.ToInt32(dtaViewEstante.CurrentRow.Cells["dtaIDEstante"].Value);
                // se crea un cuadro de dialogo para confirmar la eliminacion
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el estante?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        bool resultadoEliminar = estanteLogica.eliminarEstante(_id);
                        if (resultadoEliminar)
                        {
                            // Eliminar la fila del datagridview
                            Estante estante = (Estante)bindingSourceEstantes[dtaViewEstante.CurrentRow.Index];
                            bindingSourceEstantes.Remove(estante);
                            MessageBox.Show("Se elimino corectamente el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDatosEstantes();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el estante.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }catch(SqlException ex)
                    {
                        throw;
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
            txtNombreE.LineColor = paleta.ColorDisabled;
        }

        private void txtNumE_Enter(object sender, EventArgs e)
        {
            txtNumE.LineColor = paleta.ColorDisabled;
        }

        private void txtSectorE_Enter(object sender, EventArgs e)
        {
            txtSectorE.LineColor = paleta.ColorDisabled;
        }

        
    }
}
