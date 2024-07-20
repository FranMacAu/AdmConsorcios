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
            Int32 IND = cmbConsorcios.SelectedIndex;
            Datos.Edificio[IND].IdUF = IndUF;
            Datos.Edificio[IND].Alias = txtAlias.Text;
            Datos.Edificio[IND].Propietario = txtProp.Text;
            Datos.Edificio[IND].Ocupante = txtOcup.Text;
            Datos.Edificio[IND].piso = Convert.ToInt32(txtPiso.Text);
            Datos.Edificio[IND].Unidad = txtUnidad.Text;
            Datos.Edificio[IND].ExpB = rdbExpB.Checked;
            Datos.Edificio[IND].Saldo = 0;
            IndUF++;

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
            for (Int32 i = 0; i<Datos.Edificios.Length; i++)
            {
                cmbConsorcios.Items.Add(Datos.Edificios[i].Alias);
            }
        }
    }
}
