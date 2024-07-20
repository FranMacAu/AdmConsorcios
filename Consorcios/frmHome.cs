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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void consorcioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarConsorcio Ventana = new frmAgregarConsorcio();
            Ventana.ShowDialog();
        }

        private void unidadFuncionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarUF Ventana = new frmAgregarUF();
            Ventana.ShowDialog();
        }
    }
}
