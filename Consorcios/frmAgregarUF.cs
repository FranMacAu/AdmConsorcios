using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consorcios
{
    public partial class frmAgregarUF : Form
    {
        public frmAgregarUF()
        {
            InitializeComponent();
        }

        Int32 IndUF;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Datos.CrearConsorcio(txt)

            MessageBox.Show("Datos cargados!");

            txtAlias.Text = "";
            txtOcup.Text = "";
            txtPiso.Text = "";
            txtProp.Text = "";
            txtUnidad.Text = "";
            rdbExpB.Checked = false;

        }

        private void frmAgregarUF_Load(object sender, EventArgs e)
        {
            //for (Int32 i = 0; i<Datos.Edificios.Length; i++)
            //{
            //    cmbConsorcios.Items.Add(Datos.Edificios[i].Alias);
            //}
        }
    }
}
