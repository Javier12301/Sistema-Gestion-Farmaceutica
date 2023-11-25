using Sistema.Controles.Interfaz;
using Sistema.Controles.Logica;
using System;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema.Vista
{

    public partial class MedicamentosForm : Form
    {
        private CategoriaLogica categoryLogic = new CategoriaLogica();
        private EstanteLogica shelfLogic = new EstanteLogica();
        private MedicamentoLogica medicineLogic = new MedicamentoLogica();
        Controladora controladora = Controladora.GetInstance;
        private MessageBoxManager messageManager = MessageBoxManager.GetInstance;

        public MedicamentosForm()
        {
            InitializeComponent();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'viewSGF.VistaInventarioMedicamento' Puede moverla o quitarla según sea necesario.
            // Cargar datos en el datagridview
            loadMedicine();
            // Establecer nuevo tamaño al formulario
            this.Size = new Size(573, 299);
            // Establecer tamaño de botones de imprimir, pdf y excel
            btnExcelG.Size = new Size(73, 32);
            btnPrintG.Size = new Size(90, 32);
            btnPDFG.Size = new Size(71, 32);
            // MENSAJE PARA FUTURO, CREAR UN FILTRO QUE PERMITA AGRANDAR EL DATAGRIDVIEW CON DATOS DE LOS MEDICAMENTOS
            // CON ESTO SE LOGRARÁ OPTIMIZAR EL TAMAÑO DEL FORMULARIO
        }

        // Cargar datos en el datagridview



        private void loadMedicine()
        {
            try
            {
                //this.medicamentoModelTableAdapter.Fill(this.viewSGF.);
            }
            catch (DbUpdateException)
            {
                // Excepción relacionada con problemas de actualización en la base de datos
                messageManager.ShowDatabaseUpdateError();

                // Loguear dbEx si es necesario para fines de depuración
            }
            catch (SqlException)
            {
                // Excepción relacionada con errores de SQL
                messageManager.ShowSqlError();
                // Loguear sqlEx si es necesario para fines de depuración
            }
            catch (Exception)
            {
                // Otras excepciones no manejadas
                messageManager.ShowUnexpectedError();
                // Loguear ex si es necesario para fines de depuración
            }

        }

        private void loadCMBData()
        {
            // Obtener lista de nombres de estantes y categorías para cargar los combobox


            // Insertar en la primera posición de la lista
            //categoryList.Insert(0, "Seleccionar Categoría.");
            //shelvesList.Insert(0, "Seleccionar Estante.");
            // Cargar combobox
            //cmbFilteCat.DataSource = categoryList;
            //cmbFilterEst.DataSource = shelvesList;
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            Vista.NuevoMedicamentoForm formAgregarMedicamento = new Vista.NuevoMedicamentoForm();
            formAgregarMedicamento.FormClosed += formAgregarMedicamento_FormClosed;
            formAgregarMedicamento.ShowDialog();
        }

        // // // // INTERFAZ // // // //
        private void formAgregarMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void tsmiButtons_Click(object sender, EventArgs e)
        {
            // variable del toolstripmenuitem que fue clickeado
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            // poner el item en checked o unchecked si ya está seleccionado
            item.Checked = !item.Checked;

        }

        private void tsmiButtons_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            // se hará un switch para saber que item fue seleccionado y dependiendo si está checked o no, se desactivará su datagridview
            // en los case pon estos tag de item: codigoTAG loteTAG nombreMTAG cantidadMTAG vencimientoMTAG nombreETAG nombreCTAG sectorETAG numeroETAG
            switch (item.Tag)
            {
                case "codigoTAG":
                    dgvMedicineList.Columns[0].Visible = item.Checked;
                    break;
                case "loteTAG":
                    dgvMedicineList.Columns[1].Visible = item.Checked;
                    break;
                case "nombreMTAG":
                    dgvMedicineList.Columns[2].Visible = item.Checked;
                    break;
                case "cantidadMTAG":
                    dgvMedicineList.Columns[3].Visible = item.Checked;
                    break;
                case "vencimientoMTAG":
                    dgvMedicineList.Columns[4].Visible = item.Checked;
                    break;
                case "nombreETAG":
                    dgvMedicineList.Columns[5].Visible = item.Checked;
                    break;
                case "nombreCTAG":
                    dgvMedicineList.Columns[6].Visible = item.Checked;
                    break;
                case "sectorETAG":
                    dgvMedicineList.Columns[7].Visible = item.Checked;
                    break;
                case "numeroETAG":
                    dgvMedicineList.Columns[8].Visible = item.Checked;
                    break;
                default:
                    break;
            }

        }




        private void dgvMedicineList_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            //bindingSourceMedicine.Sort = dgvMedicineList.SortString;
        }

        private void dgvMedicineList_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            //bindingSourceMedicine.Filter = dgvMedicineList.FilterString;
        }

        private void bindingSourceMedicine_ListChanged(object sender, ListChangedEventArgs e)
        {
            //lblTotalRow.Text = "Filas Totales: " + bindingSourceMedicine.List.Count;
        }






        // // // // INTERFAZ // // // //
    }
}
