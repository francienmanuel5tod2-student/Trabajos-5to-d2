namespace CapaPresentacion
{
    partial class FormCategoria
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
            components = new System.ComponentModel.Container();
            dgvCategorias = new DataGridView();
            txtNombreCategoria = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            lblFechaHora = new Label();
            lblRol = new Label();
            lblUsername = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeColumns = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(12, 12);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 62;
            dgvCategorias.Size = new Size(266, 622);
            dgvCategorias.TabIndex = 0;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(284, 40);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(150, 31);
            txtNombreCategoria.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(284, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 12);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre categoria";
            // 
            // button1
            // 
            button1.Location = new Point(284, 128);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEliminar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 168);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Desceleccionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDesceleccionar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFechaHora);
            groupBox1.Controls.Add(lblRol);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Location = new Point(950, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 117);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bienvenido";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(6, 85);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(59, 25);
            lblFechaHora.TabIndex = 2;
            lblFechaHora.Text = "label2";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(6, 59);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(59, 25);
            lblRol.TabIndex = 1;
            lblRol.Text = "label2";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(6, 34);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(59, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "label2";
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 646);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreCategoria);
            Controls.Add(dgvCategorias);
            Name = "FormCategoria";
            Text = "FormCategoria";
            Load += FormCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategorias;
        private TextBox txtNombreCategoria;
        private Button btnAgregar;
        private Label label1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label lblUsername;
        private Label lblFechaHora;
        private Label lblRol;
        private System.Windows.Forms.Timer timerHora;
    }
}