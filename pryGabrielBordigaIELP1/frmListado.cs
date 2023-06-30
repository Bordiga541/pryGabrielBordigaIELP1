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
    public partial class frmListado : Form
    {
        string[,] MatrizListados;
        string variableOperacion;
        int f, c;
        public string[,] MatrizProductos { get; set; }
        public string[,] MatrizVentas { get; set; }
        public frmListado(string variableOperacion, string[,] MatrizListados)
        {
            InitializeComponent();

            this.variableOperacion = variableOperacion;
            this.MatrizListados = MatrizListados;
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            if (variableOperacion == "Productos")
            {
                for (int f = 0; f < MatrizProductos.GetLength(0); f++)
                {
                    if (MatrizProductos[f, 0] != null)
                    {
                        lstProductos.Items.Add("Producto " + (f + 1).ToString());
                        lstProductos.Items.Add(" ID: " + MatrizProductos[f, 0] + " \nNombre: " + MatrizProductos[f, 1]
                            + " \nFecha: " + MatrizProductos[f, 2]);
                    }
                }
            }
            else if (variableOperacion == "Ventas")
            {
                for (int f = 0; f < MatrizVentas.GetLength(0); f++)
                {
                    if (MatrizVentas[f, 0] != null)
                    {
                        lstProductos.Items.Add("Venta " + (f + 1).ToString());
                        lstProductos.Items.Add(" ID: " + MatrizVentas[f, 0] + " \nProducto: " + MatrizVentas[f, 1]
                            + " \nCantidad: " + MatrizVentas[f, 2] + " \nFecha: " + MatrizVentas[f, 3]);
                    }
                }
            }

        }

        private void cmdVolver_Click_1(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {

        }

        //private void frmListado_Load_1(object sender, EventArgs e)
        //{

        //}

        //private void cmdVolver_Click_2(object sender, EventArgs e)
        //{
        //    frmPrincipal frm = new frmPrincipal();
        //    this.Hide();
         //   frm.Show();
        //}
    }
}
