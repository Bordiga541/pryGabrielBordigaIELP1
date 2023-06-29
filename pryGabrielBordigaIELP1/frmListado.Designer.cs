namespace pryGabrielBordigaIELP1
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.lstProductos = new System.Windows.Forms.ComboBox();
            this.lstVentas = new System.Windows.Forms.ComboBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblDetalles2 = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Items.AddRange(new object[] {
            "Ejemplo 1",
            "Ejemplo 2",
            "Ejemplo 3",
            "Ejemplo 4",
            "Ejemplo 5"});
            this.lstProductos.Location = new System.Drawing.Point(30, 57);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(157, 21);
            this.lstProductos.TabIndex = 0;
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.Items.AddRange(new object[] {
            "Ejemplo 1",
            "Ejemplo 2",
            "Ejemplo 3",
            "Ejemplo 4",
            "Ejemplo 5"});
            this.lstVentas.Location = new System.Drawing.Point(30, 121);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(157, 21);
            this.lstVentas.TabIndex = 1;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(26, 34);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(90, 20);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Productos";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(26, 98);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(66, 20);
            this.lblVentas.TabIndex = 1;
            this.lblVentas.Text = "Ventas";
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFiltrar.Location = new System.Drawing.Point(320, 167);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(70, 37);
            this.cmdFiltrar.TabIndex = 3;
            this.cmdFiltrar.Text = "Filtrar";
            this.cmdFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(233, 55);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(80, 20);
            this.lblDetalles.TabIndex = 1;
            this.lblDetalles.Text = "Detalles:";
            // 
            // lblDetalles2
            // 
            this.lblDetalles2.AutoSize = true;
            this.lblDetalles2.Location = new System.Drawing.Point(234, 89);
            this.lblDetalles2.Name = "lblDetalles2";
            this.lblDetalles2.Size = new System.Drawing.Size(157, 13);
            this.lblDetalles2.TabIndex = 2;
            this.lblDetalles2.Text = "_________________________";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(244, 167);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(70, 37);
            this.cmdVolver.TabIndex = 4;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click_1);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 216);
            this.Controls.Add(this.lblDetalles2);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdFiltrar);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.lstProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.Text = "frmListado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstProductos;
        private System.Windows.Forms.ComboBox lstVentas;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Button cmdFiltrar;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblDetalles2;
        private System.Windows.Forms.Button cmdVolver;
    }
}