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
        string variableId;
        string variableNombre;
        string variableFecha;
        string variableCantidad;
        string ProductoConcatenado;
        string[,] matrizRegistarProductos = new string[30, 4];
        int f, c;
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
            while (f < matrizRegistarProductos.GetLength(0))
            {


                dtgvProductosCargados.Rows.Add(matrizRegistarProductos[f, 0], matrizRegistarProductos[f, 1], matrizRegistarProductos[f, 2], matrizRegistarProductos[f, 3]);



                f++;
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            variableCantidad = nudCantidad.Text.ToString();
            variableId = txtID.Text;
            variableNombre = txtNombre.Text;
            variableFecha = dtpFechaDeRegistro.Value.ToString();


            if (dtpFechaDeRegistro.Value >= DateTime.Today)
            {

                if (txtID.Text != "")
                {
                    if (nudCantidad.Text != "0")
                    {
                        if (txtNombre.Text != "")
                        {

                            matrizRegistarProductos[f, 0] = variableId;
                            matrizRegistarProductos[f, 1] = variableNombre;
                            matrizRegistarProductos[f, 2] = variableFecha;
                            matrizRegistarProductos[f, 3] = variableCantidad;

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
                        MessageBox.Show("Falta indicar Cantidad", "Carga de Datos", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        
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
                MessageBox.Show("Selecione una fecha actual o posterior", "Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDeRegistro.Value = DateTime.Today;
                dtpFechaDeRegistro.Focus();
            }
        }
    }
}
