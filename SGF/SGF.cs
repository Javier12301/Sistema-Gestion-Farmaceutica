using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SGF
{
    public partial class SGF : Form
    {
        public SGF()
        {
            InitializeComponent();
        }

        private void SGF_Load(object sender, EventArgs e)
        {
            //Default Size
            // this.Size = new Size(800, 600);
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error al ingresar al link");

            }
        }

        private void VisitLink()
        {
            System.Diagnostics.Process.Start("mailto:javierramirez1230123@gmail.com");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}