namespace CapaPresentacion
{
    partial class FormMovimiento
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
            groupBox1 = new GroupBox();
            lblFecha = new Label();
            lblNMovimiento = new Label();
            lblUsuario = new Label();
            label8 = new Label();
            label7 = new Label();
            lblTipo = new Label();
            cmbEntidad = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cmbTipoMovimiento = new ComboBox();
            groupBox2 = new GroupBox();
            cmbProducto = new ComboBox();
            txtCantidad = new TextBox();
            label3 = new Label();
            Producto = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dgvMovimientos = new DataGridView();
            btnEliminar = new Button();
            btnAgregar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(lblNMovimiento);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblTipo);
            groupBox1.Controls.Add(cmbEntidad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbTipoMovimiento);
            groupBox1.Location = new Point(8, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(988, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movimiento";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(473, 38);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(16, 25);
            lblFecha.TabIndex = 12;
            lblFecha.Text = ".";
            // 
            // lblNMovimiento
            // 
            lblNMovimiento.AutoSize = true;
            lblNMovimiento.Location = new Point(473, 98);
            lblNMovimiento.Name = "lblNMovimiento";
            lblNMovimiento.Size = new Size(16, 25);
            lblNMovimiento.TabIndex = 11;
            lblNMovimiento.Text = ".";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(755, 33);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(16, 25);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = ".";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(677, 33);
            label8.Name = "label8";
            label8.Size = new Size(72, 25);
            label8.TabIndex = 9;
            label8.Text = "Usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(398, 98);
            label7.Name = "label7";
            label7.Size = new Size(35, 25);
            label7.TabIndex = 8;
            label7.Text = "N0";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(6, 93);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(94, 25);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Proveedor";
            // 
            // cmbEntidad
            // 
            cmbEntidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEntidad.FormattingEnabled = true;
            cmbEntidad.Location = new Point(185, 90);
            cmbEntidad.Name = "cmbEntidad";
            cmbEntidad.Size = new Size(182, 33);
            cmbEntidad.TabIndex = 4;
            cmbEntidad.SelectedIndexChanged += cmbEntidad_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 38);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 3;
            label5.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 38);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 1;
            label4.Text = "Tipo de Movimiento";
            // 
            // cmbTipoMovimiento
            // 
            cmbTipoMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimiento.FormattingEnabled = true;
            cmbTipoMovimiento.Items.AddRange(new object[] { "Entrada", "Salida" });
            cmbTipoMovimiento.Location = new Point(185, 30);
            cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            cmbTipoMovimiento.Size = new Size(182, 33);
            cmbTipoMovimiento.TabIndex = 0;
            cmbTipoMovimiento.SelectedIndexChanged += cmbTipoMovimiento_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Producto);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(dgvMovimientos);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Location = new Point(8, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1172, 681);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(102, 46);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(182, 33);
            cmbProducto.TabIndex = 10;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(411, 48);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 31);
            txtCantidad.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 54);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 8;
            label3.Text = "Cantidad";
            // 
            // Producto
            // 
            Producto.AutoSize = true;
            Producto.Location = new Point(21, 54);
            Producto.Name = "Producto";
            Producto.Size = new Size(85, 25);
            Producto.TabIndex = 6;
            Producto.Text = "Producto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(876, 144);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(876, 104);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dgvMovimientos.AllowUserToResizeColumns = false;
            dgvMovimientos.AllowUserToResizeRows = false;
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(21, 104);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersWidth = 62;
            dgvMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimientos.Size = new Size(849, 556);
            dgvMovimientos.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(758, 54);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(640, 54);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormMovimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 946);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMovimiento";
            Text = "FormMovimiento";
            Load += FormMovimiento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtCantidad;
        private TextBox textBox1;
        private Label label3;
        private Label Producto;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridView dgvMovimientos;
        private Button btnEliminar;
        private Button btnAgregar;
        private Label label4;
        private ComboBox cmbTipoMovimiento;
        private Label label8;
        private Label label7;
        private Label lblTipo;
        private ComboBox cmbEntidad;
        private Label label5;
        private ComboBox cmbProducto;
        private Label lblUsuario;
        private Label lblNMovimiento;
        private Label lblFecha;
    }
}