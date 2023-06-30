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
    public partial class frmCargaDeVentas : Form
    {
        string[,] MatrizVentas = new string[30, 4];
        int f;

        public frmCargaDeVentas()
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

        private void cmdVolver2_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = 0;
            while (f < MatrizVentas.GetLength(0))
            {
                dtgvProductosCargados.Rows.Add(MatrizVentas[f, 0], MatrizVentas[f, 1], MatrizVentas[f, 2], MatrizVentas[f, 3]);
                f++;
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            string variableCantidad = nudCantidad.Text.ToString();
            string variableId = txtID.Text;
            string variableNombre = txtNombre.Text;
            string variableFecha = dtpFechaDeRegistro.Value.ToString();

            if (dtpFechaDeRegistro.Value >= DateTime.Today)
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    if (nudCantidad.Value != 0)
                    {
                        if (!string.IsNullOrEmpty(txtNombre.Text))
                        {
                            MatrizVentas[f, 0] = variableId;
                            MatrizVentas[f, 1] = variableNombre;
                            MatrizVentas[f, 2] = variableFecha;
                            MatrizVentas[f, 3] = variableCantidad;
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
                        MessageBox.Show("Falta indicar Cantidad", "Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        nudCantidad.Focus();
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
