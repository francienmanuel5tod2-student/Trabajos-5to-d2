namespace CapaPresentacion
{
    partial class FormProducto
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
            dgvProductos = new DataGridView();
            groupBox1 = new GroupBox();
            lblFechaHora = new Label();
            lblRol = new Label();
            lblUsername = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            btnAgregarProducto = new Button();
            groupBox2 = new GroupBox();
            btnDesceleccionar = new Button();
            btnEliminarProducto = new Button();
            label3 = new Label();
            cmbProveedor = new ComboBox();
            label2 = new Label();
            cmbCategoriaProducto = new ComboBox();
            Stock = new Label();
            txtStockProducto = new TextBox();
            label1 = new Label();
            txtNombreProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1021, 761);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFechaHora);
            groupBox1.Controls.Add(lblRol);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Location = new Point(1358, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 116);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bienvenido";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(13, 79);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(59, 25);
            lblFechaHora.TabIndex = 2;
            lblFechaHora.Text = "label3";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(13, 54);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(59, 25);
            lblRol.TabIndex = 1;
            lblRol.Text = "label2";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(13, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(59, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "label1";
            // 
            // timerHora
            // 
            timerHora.Enabled = true;
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(6, 305);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(112, 34);
            btnAgregarProducto.TabIndex = 2;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDesceleccionar);
            groupBox2.Controls.Add(btnEliminarProducto);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbProveedor);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmbCategoriaProducto);
            groupBox2.Controls.Add(Stock);
            groupBox2.Controls.Add(txtStockProducto);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtNombreProducto);
            groupBox2.Controls.Add(btnAgregarProducto);
            groupBox2.Location = new Point(1039, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 403);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nuevo Producto";
            // 
            // btnDesceleccionar
            // 
            btnDesceleccionar.Location = new Point(6, 345);
            btnDesceleccionar.Name = "btnDesceleccionar";
            btnDesceleccionar.Size = new Size(150, 34);
            btnDesceleccionar.TabIndex = 12;
            btnDesceleccionar.Text = "Desceleccionar";
            btnDesceleccionar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(124, 305);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(112, 34);
            btnEliminarProducto.TabIndex = 11;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 214);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 10;
            label3.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(6, 242);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(182, 33);
            cmbProveedor.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 150);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 8;
            label2.Text = "Categoria";
            // 
            // cmbCategoriaProducto
            // 
            cmbCategoriaProducto.FormattingEnabled = true;
            cmbCategoriaProducto.Location = new Point(6, 178);
            cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            cmbCategoriaProducto.Size = new Size(182, 33);
            cmbCategoriaProducto.TabIndex = 7;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Location = new Point(6, 89);
            Stock.Name = "Stock";
            Stock.Size = new Size(55, 25);
            Stock.TabIndex = 6;
            Stock.Text = "Stock";
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(6, 116);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(150, 31);
            txtStockProducto.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(6, 55);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(150, 31);
            txtNombreProducto.TabIndex = 3;
            // 
            // FormProducto
            // 
            ClientSize = new Size(1670, 785);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvProductos);
            Name = "FormProducto";
            Text = "FormProducto";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private GroupBox groupBox1;
        private Label lblFechaHora;
        private Label lblRol;
        private Label lblUsername;
        private System.Windows.Forms.Timer timerHora;
        private Button btnAgregarProducto;
        private GroupBox groupBox2;
        private TextBox txtStockProducto;
        private Label label1;
        private TextBox txtNombreProducto;
        private Label Stock;
        private Label label2;
        private ComboBox cmbCategoriaProducto;
        private Label label3;
        private ComboBox cmbProveedor;
        private Button btnEliminarProducto;
        private Button btnDesceleccionar;
    }
}