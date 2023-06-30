using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryGabrielBordigaIELP1
{
    public partial class frmCargaDeProductos : Form
    {
        string[,] MatrizProductos = new string[30, 3];
        string[,] MatrizVentas = new string[30, 4];
        int f;

        public frmCargaDeProductos()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void cmdVolver2_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void frmCargaDeProductos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = 0;
            while (f < MatrizProductos.GetLength(0))
            {
                dtgvProductosCargados.Rows.Add(MatrizProductos[f, 0], MatrizProductos[f, 1], MatrizProductos[f, 2]);
                f++;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtID.Text.Length >= 5 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            string variableId = txtID.Text;
            string variableNombre = txtNombre.Text;
            string variableFecha = dtpFechaDeRegistro.Value.ToString();

            if (dtpFechaDeRegistro.Value >= DateTime.Today)
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        MatrizProductos[f, 0] = variableId;
                        MatrizProductos[f, 1] = variableNombre;
                        MatrizProductos[f, 2] = variableFecha;
                        f++;
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Falta Nombre del producto.", "Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNombre.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Falta ID del producto", "Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior", "Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDeRegistro.Value = DateTime.Today;
                dtpFechaDeRegistro.Focus();
            }
        }
    }
}