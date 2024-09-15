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



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Datos.CrearConsorcio(txtNombre.Text, txtDireccion.Text, Convert.ToInt32(txtCantUF.Text)); //parece que anda, hacer listad para comfirmar
        }
    }
}
