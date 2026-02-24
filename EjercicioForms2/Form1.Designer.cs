namespace trabajo_en_parejas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            txtNumero = new TextBox();
            txtEmail = new TextBox();
            comboBoxCargo = new ComboBox();
            dgvEmpleados = new DataGridView();
            dateTimePickerFecha = new DateTimePicker();
            txtSalario = new TextBox();
            comboBoxGenero = new ComboBox();
            lblID = new Label();
            lblNombre = new Label();
            lblDireccion = new Label();
            label1 = new Label();
            lblNumero = new Label();
            lblEmail = new Label();
            lblSalario = new Label();
            lblCargo = new Label();
            lblGenero = new Label();
            lblFecha = new Label();
            btnGuardar = new Button();
            btnAbrir = new Button();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            lblSubtitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(478, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(441, 53);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario Empleado";
            // 
            // txtId
            // 
            txtId.Location = new Point(17, 112);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Id";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(17, 188);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(17, 269);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "Apellidos";
            txtApellidos.Size = new Size(150, 31);
            txtApellidos.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(17, 350);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(133, 428);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(162, 31);
            txtNumero.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(264, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 6;
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Items.AddRange(new object[] { "Administrador", "Cajero", "Supervisor", "Conserje" });
            comboBoxCargo.Location = new Point(254, 269);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(182, 33);
            comboBoxCargo.TabIndex = 7;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEmpleados.BorderStyle = BorderStyle.Fixed3D;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(495, 66);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersWidth = 62;
            dgvEmpleados.Size = new Size(860, 259);
            dgvEmpleados.TabIndex = 8;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(55, 517);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(321, 31);
            dateTimePickerFecha.TabIndex = 9;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(264, 188);
            txtSalario.Name = "txtSalario";
            txtSalario.PlaceholderText = "Salario";
            txtSalario.Size = new Size(150, 31);
            txtSalario.TabIndex = 10;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxGenero.Location = new Point(254, 348);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(182, 33);
            comboBoxGenero.TabIndex = 11;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(17, 84);
            lblID.Name = "lblID";
            lblID.Size = new Size(115, 25);
            lblID.TabIndex = 12;
            lblID.Text = "Ingrese el ID:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 160);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(163, 25);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Ingrese el Nombre:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(10, 322);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(170, 25);
            lblDireccion.TabIndex = 14;
            lblDireccion.Text = "Ingrese la Direccion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 241);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 15;
            label1.Text = "Ingrese la Apellidos:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(135, 400);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(162, 25);
            lblNumero.TabIndex = 16;
            lblNumero.Text = "Ingrese el Numero:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(264, 84);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(139, 25);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Ingrese el Email:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(264, 160);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(150, 25);
            lblSalario.TabIndex = 18;
            lblSalario.Text = "Ingrese el Salario:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(254, 241);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(145, 25);
            lblCargo.TabIndex = 19;
            lblCargo.Text = "Ingrese el Cargo:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(254, 322);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(154, 25);
            lblGenero.TabIndex = 20;
            lblGenero.Text = "Ingrese el Genero:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(55, 489);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(328, 25);
            lblFecha.TabIndex = 21;
            lblFecha.Text = "Ingrese Fecha de Ingreso del Empleado:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(512, 434);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(873, 434);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(112, 34);
            btnAbrir.TabIndex = 23;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1236, 434);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSubtitulo);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(dateTimePickerFecha);
            groupBox1.Controls.Add(lblGenero);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(comboBoxGenero);
            groupBox1.Controls.Add(lblCargo);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblSalario);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(comboBoxCargo);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblNumero);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(30, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 588);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(66, 27);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(301, 25);
            lblSubtitulo.TabIndex = 22;
            lblSubtitulo.Text = "Ingrese los datos del empleado aqui";
            // 
            // Form1
            // 
            ClientSize = new Size(1368, 650);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnAbrir);
            Controls.Add(btnGuardar);
            Controls.Add(dgvEmpleados);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblTitulo;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtDireccion;
        private TextBox txtNumero;
        private TextBox txtEmail;
        private ComboBox comboBoxCargo;
        private DataGridView dgvEmpleados;
        private DateTimePicker dateTimePickerFecha;
        private TextBox txtSalario;
        private ComboBox comboBoxGenero;
        private Label lblID;
        private Label lblNombre;
        private Label lblDireccion;
        private Label label1;
        private Label lblNumero;
        private Label lblEmail;
        private Label lblSalario;
        private Label lblCargo;
        private Label lblGenero;
        private Label lblFecha;
        private Button btnGuardar;
        private Button btnAbrir;
        private Button btnSalir;
        private GroupBox groupBox1;
        private Label lblSubtitulo;
    }
}
