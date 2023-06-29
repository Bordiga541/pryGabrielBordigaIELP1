namespace pryGabrielBordigaIELP1
{
    partial class frmCargaDeVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDeVentas));
            this.tbProductos = new System.Windows.Forms.TabControl();
            this.tbRegistroProductos = new System.Windows.Forms.TabPage();
            this.dtpFechaDeRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblFechaDeVenta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCargarProductos = new System.Windows.Forms.Label();
            this.tbConsultarProductos = new System.Windows.Forms.TabPage();
            this.tbVendido2 = new System.Windows.Forms.TabControl();
            this.tbMayorA10 = new System.Windows.Forms.TabPage();
            this.tbVendido = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdVolver2 = new System.Windows.Forms.Button();
            this.lblProductosVendidos = new System.Windows.Forms.Label();
            this.dtgvProductosCargados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.lblProductoEnAlmacen = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblVentasRegistradas = new System.Windows.Forms.Label();
            this.lblCantidadVendido = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadVendido = new System.Windows.Forms.NumericUpDown();
            this.nudMayorA10 = new System.Windows.Forms.NumericUpDown();
            this.tbProductos.SuspendLayout();
            this.tbRegistroProductos.SuspendLayout();
            this.tbConsultarProductos.SuspendLayout();
            this.tbVendido2.SuspendLayout();
            this.tbMayorA10.SuspendLayout();
            this.tbVendido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductosCargados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVendido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMayorA10)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductos
            // 
            this.tbProductos.Controls.Add(this.tbRegistroProductos);
            this.tbProductos.Controls.Add(this.tbConsultarProductos);
            this.tbProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductos.Location = new System.Drawing.Point(12, 12);
            this.tbProductos.Name = "tbProductos";
            this.tbProductos.SelectedIndex = 0;
            this.tbProductos.Size = new System.Drawing.Size(540, 451);
            this.tbProductos.TabIndex = 2;
            // 
            // tbRegistroProductos
            // 
            this.tbRegistroProductos.Controls.Add(this.nudCantidad);
            this.tbRegistroProductos.Controls.Add(this.dtpFechaDeRegistro);
            this.tbRegistroProductos.Controls.Add(this.txtNombre);
            this.tbRegistroProductos.Controls.Add(this.txtID);
            this.tbRegistroProductos.Controls.Add(this.cmdVolver);
            this.tbRegistroProductos.Controls.Add(this.cmdCargar);
            this.tbRegistroProductos.Controls.Add(this.lblFechaDeVenta);
            this.tbRegistroProductos.Controls.Add(this.lblNombre);
            this.tbRegistroProductos.Controls.Add(this.lblCantidad);
            this.tbRegistroProductos.Controls.Add(this.lblID);
            this.tbRegistroProductos.Controls.Add(this.lblCargarProductos);
            this.tbRegistroProductos.Location = new System.Drawing.Point(4, 32);
            this.tbRegistroProductos.Name = "tbRegistroProductos";
            this.tbRegistroProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistroProductos.Size = new System.Drawing.Size(532, 415);
            this.tbRegistroProductos.TabIndex = 0;
            this.tbRegistroProductos.Text = "Registro";
            this.tbRegistroProductos.UseVisualStyleBackColor = true;
            // 
            // dtpFechaDeRegistro
            // 
            this.dtpFechaDeRegistro.Location = new System.Drawing.Point(48, 264);
            this.dtpFechaDeRegistro.Name = "dtpFechaDeRegistro";
            this.dtpFechaDeRegistro.Size = new System.Drawing.Size(436, 31);
            this.dtpFechaDeRegistro.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(48, 190);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(436, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(48, 110);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(436, 31);
            this.txtID.TabIndex = 0;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(384, 381);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(68, 28);
            this.cmdVolver.TabIndex = 5;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(458, 381);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(68, 28);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblFechaDeVenta
            // 
            this.lblFechaDeVenta.AutoSize = true;
            this.lblFechaDeVenta.Location = new System.Drawing.Point(44, 238);
            this.lblFechaDeVenta.Name = "lblFechaDeVenta";
            this.lblFechaDeVenta.Size = new System.Drawing.Size(168, 23);
            this.lblFechaDeVenta.TabIndex = 1;
            this.lblFechaDeVenta.Text = "Fecha de Venta:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(44, 164);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(44, 316);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(105, 23);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(44, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 23);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblCargarProductos
            // 
            this.lblCargarProductos.AutoSize = true;
            this.lblCargarProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargarProductos.Location = new System.Drawing.Point(141, 20);
            this.lblCargarProductos.Name = "lblCargarProductos";
            this.lblCargarProductos.Size = new System.Drawing.Size(249, 32);
            this.lblCargarProductos.TabIndex = 0;
            this.lblCargarProductos.Text = "Ventas Productos";
            // 
            // tbConsultarProductos
            // 
            this.tbConsultarProductos.Controls.Add(this.tbVendido2);
            this.tbConsultarProductos.Controls.Add(this.pictureBox1);
            this.tbConsultarProductos.Controls.Add(this.button1);
            this.tbConsultarProductos.Controls.Add(this.cmdVolver2);
            this.tbConsultarProductos.Controls.Add(this.lblProductosVendidos);
            this.tbConsultarProductos.Controls.Add(this.dtgvProductosCargados);
            this.tbConsultarProductos.Location = new System.Drawing.Point(4, 32);
            this.tbConsultarProductos.Name = "tbConsultarProductos";
            this.tbConsultarProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultarProductos.Size = new System.Drawing.Size(532, 415);
            this.tbConsultarProductos.TabIndex = 1;
            this.tbConsultarProductos.Text = "Consultar";
            this.tbConsultarProductos.UseVisualStyleBackColor = true;
            // 
            // tbVendido2
            // 
            this.tbVendido2.Controls.Add(this.tbMayorA10);
            this.tbVendido2.Controls.Add(this.tbVendido);
            this.tbVendido2.Location = new System.Drawing.Point(6, 11);
            this.tbVendido2.Name = "tbVendido2";
            this.tbVendido2.SelectedIndex = 0;
            this.tbVendido2.Size = new System.Drawing.Size(519, 157);
            this.tbVendido2.TabIndex = 2;
            // 
            // tbMayorA10
            // 
            this.tbMayorA10.Controls.Add(this.nudMayorA10);
            this.tbMayorA10.Controls.Add(this.button2);
            this.tbMayorA10.Controls.Add(this.comboBox1);
            this.tbMayorA10.Controls.Add(this.lblProductoEnAlmacen);
            this.tbMayorA10.Controls.Add(this.lblIngresar);
            this.tbMayorA10.Location = new System.Drawing.Point(4, 32);
            this.tbMayorA10.Name = "tbMayorA10";
            this.tbMayorA10.Padding = new System.Windows.Forms.Padding(3);
            this.tbMayorA10.Size = new System.Drawing.Size(511, 121);
            this.tbMayorA10.TabIndex = 0;
            this.tbMayorA10.Text = "Mayor a 10";
            this.tbMayorA10.UseVisualStyleBackColor = true;
            // 
            // tbVendido
            // 
            this.tbVendido.Controls.Add(this.nudCantidadVendido);
            this.tbVendido.Controls.Add(this.comboBox2);
            this.tbVendido.Controls.Add(this.lblCantidadVendido);
            this.tbVendido.Controls.Add(this.lblVentasRegistradas);
            this.tbVendido.Location = new System.Drawing.Point(4, 32);
            this.tbVendido.Name = "tbVendido";
            this.tbVendido.Padding = new System.Windows.Forms.Padding(3);
            this.tbVendido.Size = new System.Drawing.Size(511, 121);
            this.tbVendido.TabIndex = 1;
            this.tbVendido.Text = "Vendido";
            this.tbVendido.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryGabrielBordigaIELP1.Properties.Resources.Refresh_icon;
            this.pictureBox1.Location = new System.Drawing.Point(439, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(459, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdVolver2
            // 
            this.cmdVolver2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver2.Location = new System.Drawing.Point(439, 378);
            this.cmdVolver2.Name = "cmdVolver2";
            this.cmdVolver2.Size = new System.Drawing.Size(87, 31);
            this.cmdVolver2.TabIndex = 1;
            this.cmdVolver2.Text = "Volver";
            this.cmdVolver2.UseVisualStyleBackColor = true;
            this.cmdVolver2.Click += new System.EventHandler(this.cmdVolver2_Click);
            // 
            // lblProductosVendidos
            // 
            this.lblProductosVendidos.AutoSize = true;
            this.lblProductosVendidos.Location = new System.Drawing.Point(6, 178);
            this.lblProductosVendidos.Name = "lblProductosVendidos";
            this.lblProductosVendidos.Size = new System.Drawing.Size(214, 23);
            this.lblProductosVendidos.TabIndex = 3;
            this.lblProductosVendidos.Text = "Productos Vendidos:";
            // 
            // dtgvProductosCargados
            // 
            this.dtgvProductosCargados.AllowUserToAddRows = false;
            this.dtgvProductosCargados.AllowUserToDeleteRows = false;
            this.dtgvProductosCargados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProductosCargados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvProductosCargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductosCargados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.FechaDeVenta,
            this.Cantidad});
            this.dtgvProductosCargados.Location = new System.Drawing.Point(6, 204);
            this.dtgvProductosCargados.Name = "dtgvProductosCargados";
            this.dtgvProductosCargados.RowHeadersVisible = false;
            this.dtgvProductosCargados.Size = new System.Drawing.Size(520, 169);
            this.dtgvProductosCargados.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.FillWeight = 54.12501F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 109.9478F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FechaDeVenta
            // 
            this.FechaDeVenta.FillWeight = 150.648F;
            this.FechaDeVenta.HeaderText = "Fecha de Venta";
            this.FechaDeVenta.Name = "FechaDeVenta";
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 85.27921F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.Location = new System.Drawing.Point(6, 8);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(154, 21);
            this.lblIngresar.TabIndex = 0;
            this.lblIngresar.Text = "Ingresa la cantidad";
            // 
            // lblProductoEnAlmacen
            // 
            this.lblProductoEnAlmacen.AutoSize = true;
            this.lblProductoEnAlmacen.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoEnAlmacen.Location = new System.Drawing.Point(6, 59);
            this.lblProductoEnAlmacen.Name = "lblProductoEnAlmacen";
            this.lblProductoEnAlmacen.Size = new System.Drawing.Size(179, 21);
            this.lblProductoEnAlmacen.TabIndex = 0;
            this.lblProductoEnAlmacen.Text = "Productos en almacen";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 25);
            this.comboBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(417, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblVentasRegistradas
            // 
            this.lblVentasRegistradas.AutoSize = true;
            this.lblVentasRegistradas.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasRegistradas.Location = new System.Drawing.Point(7, 10);
            this.lblVentasRegistradas.Name = "lblVentasRegistradas";
            this.lblVentasRegistradas.Size = new System.Drawing.Size(157, 21);
            this.lblVentasRegistradas.TabIndex = 0;
            this.lblVentasRegistradas.Text = "Ventas Registradas";
            // 
            // lblCantidadVendido
            // 
            this.lblCantidadVendido.AutoSize = true;
            this.lblCantidadVendido.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVendido.Location = new System.Drawing.Point(6, 61);
            this.lblCantidadVendido.Name = "lblCantidadVendido";
            this.lblCantidadVendido.Size = new System.Drawing.Size(147, 21);
            this.lblCantidadVendido.TabIndex = 0;
            this.lblCantidadVendido.Text = "Cantidad Vendido";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(11, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(253, 25);
            this.comboBox2.TabIndex = 1;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(48, 342);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(91, 31);
            this.nudCantidad.TabIndex = 3;
            // 
            // nudCantidadVendido
            // 
            this.nudCantidadVendido.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadVendido.Location = new System.Drawing.Point(11, 84);
            this.nudCantidadVendido.Name = "nudCantidadVendido";
            this.nudCantidadVendido.Size = new System.Drawing.Size(85, 25);
            this.nudCantidadVendido.TabIndex = 2;
            // 
            // nudMayorA10
            // 
            this.nudMayorA10.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMayorA10.Location = new System.Drawing.Point(10, 31);
            this.nudMayorA10.Name = "nudMayorA10";
            this.nudMayorA10.Size = new System.Drawing.Size(85, 25);
            this.nudMayorA10.TabIndex = 0;
            // 
            // frmCargaDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 470);
            this.Controls.Add(this.tbProductos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaDeVentas";
            this.Text = "frmCargaDeVentas";
            this.tbProductos.ResumeLayout(false);
            this.tbRegistroProductos.ResumeLayout(false);
            this.tbRegistroProductos.PerformLayout();
            this.tbConsultarProductos.ResumeLayout(false);
            this.tbConsultarProductos.PerformLayout();
            this.tbVendido2.ResumeLayout(false);
            this.tbMayorA10.ResumeLayout(false);
            this.tbMayorA10.PerformLayout();
            this.tbVendido.ResumeLayout(false);
            this.tbVendido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductosCargados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVendido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMayorA10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbProductos;
        private System.Windows.Forms.TabPage tbRegistroProductos;
        private System.Windows.Forms.DateTimePicker dtpFechaDeRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblFechaDeVenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCargarProductos;
        private System.Windows.Forms.TabPage tbConsultarProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdVolver2;
        private System.Windows.Forms.Label lblProductosVendidos;
        private System.Windows.Forms.DataGridView dtgvProductosCargados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TabControl tbVendido2;
        private System.Windows.Forms.TabPage tbMayorA10;
        private System.Windows.Forms.TabPage tbVendido;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblProductoEnAlmacen;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblCantidadVendido;
        private System.Windows.Forms.Label lblVentasRegistradas;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudMayorA10;
        private System.Windows.Forms.NumericUpDown nudCantidadVendido;
    }
}