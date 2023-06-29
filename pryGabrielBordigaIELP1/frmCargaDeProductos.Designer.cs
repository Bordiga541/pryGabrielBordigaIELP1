namespace pryGabrielBordigaIELP1
{
    partial class frmCargaDeProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDeProductos));
            this.tbProductos = new System.Windows.Forms.TabControl();
            this.tbRegistroProductos = new System.Windows.Forms.TabPage();
            this.dtpFechaDeRegistro = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblFechaDeRegistro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCargarProductos = new System.Windows.Forms.Label();
            this.tbConsultarProductos = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.cmdVolver2 = new System.Windows.Forms.Button();
            this.lblProductosCargados = new System.Windows.Forms.Label();
            this.dtgvProductosCargados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProductos.SuspendLayout();
            this.tbRegistroProductos.SuspendLayout();
            this.tbConsultarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductosCargados)).BeginInit();
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
            this.tbProductos.Size = new System.Drawing.Size(540, 469);
            this.tbProductos.TabIndex = 0;
            // 
            // tbRegistroProductos
            // 
            this.tbRegistroProductos.Controls.Add(this.dtpFechaDeRegistro);
            this.tbRegistroProductos.Controls.Add(this.txtNombre);
            this.tbRegistroProductos.Controls.Add(this.txtID);
            this.tbRegistroProductos.Controls.Add(this.cmdVolver);
            this.tbRegistroProductos.Controls.Add(this.cmdCargar);
            this.tbRegistroProductos.Controls.Add(this.lblFechaDeRegistro);
            this.tbRegistroProductos.Controls.Add(this.lblNombre);
            this.tbRegistroProductos.Controls.Add(this.lblID);
            this.tbRegistroProductos.Controls.Add(this.lblCargarProductos);
            this.tbRegistroProductos.Location = new System.Drawing.Point(4, 32);
            this.tbRegistroProductos.Name = "tbRegistroProductos";
            this.tbRegistroProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistroProductos.Size = new System.Drawing.Size(532, 433);
            this.tbRegistroProductos.TabIndex = 0;
            this.tbRegistroProductos.Text = "Registro";
            this.tbRegistroProductos.UseVisualStyleBackColor = true;
            // 
            // dtpFechaDeRegistro
            // 
            this.dtpFechaDeRegistro.Location = new System.Drawing.Point(48, 308);
            this.dtpFechaDeRegistro.Name = "dtpFechaDeRegistro";
            this.dtpFechaDeRegistro.Size = new System.Drawing.Size(436, 31);
            this.dtpFechaDeRegistro.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(48, 208);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(436, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(48, 110);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(436, 31);
            this.txtID.TabIndex = 1;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(384, 398);
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
            this.cmdCargar.Location = new System.Drawing.Point(458, 398);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(68, 28);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblFechaDeRegistro
            // 
            this.lblFechaDeRegistro.AutoSize = true;
            this.lblFechaDeRegistro.Location = new System.Drawing.Point(44, 282);
            this.lblFechaDeRegistro.Name = "lblFechaDeRegistro";
            this.lblFechaDeRegistro.Size = new System.Drawing.Size(194, 23);
            this.lblFechaDeRegistro.TabIndex = 1;
            this.lblFechaDeRegistro.Text = "Fecha de Registro:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(44, 182);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
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
            this.lblCargarProductos.Size = new System.Drawing.Size(250, 32);
            this.lblCargarProductos.TabIndex = 0;
            this.lblCargarProductos.Text = "Cargar Productos";
            // 
            // tbConsultarProductos
            // 
            this.tbConsultarProductos.Controls.Add(this.pictureBox1);
            this.tbConsultarProductos.Controls.Add(this.cmdActualizar);
            this.tbConsultarProductos.Controls.Add(this.cmdVolver2);
            this.tbConsultarProductos.Controls.Add(this.lblProductosCargados);
            this.tbConsultarProductos.Controls.Add(this.dtgvProductosCargados);
            this.tbConsultarProductos.Location = new System.Drawing.Point(4, 32);
            this.tbConsultarProductos.Name = "tbConsultarProductos";
            this.tbConsultarProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultarProductos.Size = new System.Drawing.Size(532, 433);
            this.tbConsultarProductos.TabIndex = 1;
            this.tbConsultarProductos.Text = "Consultar";
            this.tbConsultarProductos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryGabrielBordigaIELP1.Properties.Resources.Refresh_icon;
            this.pictureBox1.Location = new System.Drawing.Point(439, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdActualizar.Location = new System.Drawing.Point(459, 16);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(67, 20);
            this.cmdActualizar.TabIndex = 0;
            this.cmdActualizar.Text = "actualizar";
            this.cmdActualizar.UseVisualStyleBackColor = true;
            this.cmdActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdVolver2
            // 
            this.cmdVolver2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver2.Location = new System.Drawing.Point(434, 400);
            this.cmdVolver2.Name = "cmdVolver2";
            this.cmdVolver2.Size = new System.Drawing.Size(92, 27);
            this.cmdVolver2.TabIndex = 1;
            this.cmdVolver2.Text = "Volver";
            this.cmdVolver2.UseVisualStyleBackColor = true;
            this.cmdVolver2.Click += new System.EventHandler(this.cmdVolver2_Click);
            // 
            // lblProductosCargados
            // 
            this.lblProductosCargados.AutoSize = true;
            this.lblProductosCargados.Location = new System.Drawing.Point(6, 16);
            this.lblProductosCargados.Name = "lblProductosCargados";
            this.lblProductosCargados.Size = new System.Drawing.Size(219, 23);
            this.lblProductosCargados.TabIndex = 1;
            this.lblProductosCargados.Text = "Productos Cargados:";
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
            this.FechaDeRegistro});
            this.dtgvProductosCargados.Location = new System.Drawing.Point(6, 42);
            this.dtgvProductosCargados.Name = "dtgvProductosCargados";
            this.dtgvProductosCargados.RowHeadersVisible = false;
            this.dtgvProductosCargados.Size = new System.Drawing.Size(520, 352);
            this.dtgvProductosCargados.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.FillWeight = 45.68528F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 127.1574F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FechaDeRegistro
            // 
            this.FechaDeRegistro.FillWeight = 127.1574F;
            this.FechaDeRegistro.HeaderText = "Fecha de Registro";
            this.FechaDeRegistro.Name = "FechaDeRegistro";
            // 
            // frmCargaDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(561, 490);
            this.Controls.Add(this.tbProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaDeProductos";
            this.Text = "frmCargaDeProductos";
            this.Load += new System.EventHandler(this.frmCargaDeProductos_Load);
            this.tbProductos.ResumeLayout(false);
            this.tbRegistroProductos.ResumeLayout(false);
            this.tbRegistroProductos.PerformLayout();
            this.tbConsultarProductos.ResumeLayout(false);
            this.tbConsultarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductosCargados)).EndInit();
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
        private System.Windows.Forms.Label lblFechaDeRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCargarProductos;
        private System.Windows.Forms.TabPage tbConsultarProductos;
        private System.Windows.Forms.DataGridView dtgvProductosCargados;
        private System.Windows.Forms.Button cmdVolver2;
        private System.Windows.Forms.Label lblProductosCargados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeRegistro;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}