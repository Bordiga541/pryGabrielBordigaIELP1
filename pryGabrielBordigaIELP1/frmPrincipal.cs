using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGabrielBordigaIELP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCargaDeProductos frm = new frmCargaDeProductos();
            this.Hide();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCargaDeVentas frm = new frmCargaDeVentas();
            this.Hide();
            frm.Show();
        }

        private void cmdVerListado_Click(object sender, EventArgs e)
        {
            frmListado frm = new frmListado();
            this.Hide();
            frm.Show();
        }
    }
}
