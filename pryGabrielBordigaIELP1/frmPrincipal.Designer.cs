namespace pryGabrielBordigaIELP1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.cmdCargaDeProductos = new System.Windows.Forms.Button();
            this.cmdCargaDeVentas = new System.Windows.Forms.Button();
            this.cmdVerListado = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Myanmar Text", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(62, 30);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(225, 58);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // cmdCargaDeProductos
            // 
            this.cmdCargaDeProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargaDeProductos.Location = new System.Drawing.Point(54, 91);
            this.cmdCargaDeProductos.Name = "cmdCargaDeProductos";
            this.cmdCargaDeProductos.Size = new System.Drawing.Size(233, 78);
            this.cmdCargaDeProductos.TabIndex = 0;
            this.cmdCargaDeProductos.Text = "Carga de Productos";
            this.cmdCargaDeProductos.UseVisualStyleBackColor = true;
            this.cmdCargaDeProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCargaDeVentas
            // 
            this.cmdCargaDeVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargaDeVentas.Location = new System.Drawing.Point(54, 175);
            this.cmdCargaDeVentas.Name = "cmdCargaDeVentas";
            this.cmdCargaDeVentas.Size = new System.Drawing.Size(233, 78);
            this.cmdCargaDeVentas.TabIndex = 1;
            this.cmdCargaDeVentas.Text = "Carga de Ventas";
            this.cmdCargaDeVentas.UseVisualStyleBackColor = true;
            this.cmdCargaDeVentas.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmdVerListado
            // 
            this.cmdVerListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerListado.Location = new System.Drawing.Point(54, 259);
            this.cmdVerListado.Name = "cmdVerListado";
            this.cmdVerListado.Size = new System.Drawing.Size(233, 78);
            this.cmdVerListado.TabIndex = 2;
            this.cmdVerListado.Text = "Ver Listado";
            this.cmdVerListado.UseVisualStyleBackColor = true;
            this.cmdVerListado.Click += new System.EventHandler(this.cmdVerListado_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(279, 371);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(51, 24);
            this.cmdSalir.TabIndex = 3;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 407);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdVerListado);
            this.Controls.Add(this.cmdCargaDeVentas);
            this.Controls.Add(this.cmdCargaDeProductos);
            this.Controls.Add(this.lblBienvenido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button cmdCargaDeProductos;
        private System.Windows.Forms.Button cmdCargaDeVentas;
        private System.Windows.Forms.Button cmdVerListado;
        private System.Windows.Forms.Button cmdSalir;
    }
}