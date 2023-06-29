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
        string variableId;
        string variableNombre;
        string variableFecha;
        string ProductoConcatenado;
        string[,] matrizRegistarProductos = new string[30, 3];
        int f, c;
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
            while (f < matrizRegistarProductos.GetLength(0))
            {


                dtgvProductosCargados.Rows.Add(matrizRegistarProductos[f, 0], matrizRegistarProductos[f, 1], matrizRegistarProductos[f, 2]);



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
            variableId = txtID.Text;
            variableNombre = txtNombre.Text;
            variableFecha = dtpFechaDeRegistro.Value.ToString();

            
            if (dtpFechaDeRegistro.Value >= DateTime.Today)
            {
               
                if (txtID.Text != "")
                {
                    if (txtNombre.Text != "")
                    {
                        
                        matrizRegistarProductos[f, 0] = variableId;
                        matrizRegistarProductos[f, 1] = variableNombre;
                        matrizRegistarProductos[f, 2] = variableFecha;

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
                MessageBox.Show("Selecione una fecha actual o posterior", "Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDeRegistro.Value = DateTime.Today;
                dtpFechaDeRegistro.Focus();
            }

        }
    }
}
