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
    public partial class frmAgregarConsorcio : Form
    {
        public frmAgregarConsorcio()
        {
            InitializeComponent();
        }
        Int32 ID = 0;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Datos.Consorcio nuevoConsorcio = new Datos.Consorcio
            {
                Alias = txtNombre.Text;
        }


             
            nuevoConsorcio.IndEdif = Datos.IndEdifTotal;
            nuevoConsorcio.Alias = txtNombre.Text;
            nuevoConsorcio.Direccion = txtDireccion.Text;
            nuevoConsorcio.CantidadUF = Convert.ToInt32(txtCantUF.Text);
            nuevoConsorcio.Categoria = txtCategoria.Text;
              
            MessageBox.Show("Edificio cargado!");
            txtCategoria.Text = "";
            txtCantUF.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            Datos.IndEdifTotal++;
        }

        
    }
}
