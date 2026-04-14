namespace CapaPresentacion
{
    partial class FormConsulta
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
            groupBox1 = new GroupBox();
            lblFechaHora = new Label();
            lblRol = new Label();
            lblUsername = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            dgvMovimientos = new DataGridView();
            btnReporte = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFechaHora);
            groupBox1.Controls.Add(lblRol);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Location = new Point(741, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bienvenido";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(6, 77);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(59, 25);
            lblFechaHora.TabIndex = 2;
            lblFechaHora.Text = "label1";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(6, 52);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(59, 25);
            lblRol.TabIndex = 1;
            lblRol.Text = "label1";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(6, 27);
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
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dgvMovimientos.AllowUserToResizeColumns = false;
            dgvMovimientos.AllowUserToResizeRows = false;
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(12, 12);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersWidth = 62;
            dgvMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimientos.Size = new Size(571, 454);
            dgvMovimientos.TabIndex = 1;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(589, 12);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(112, 52);
            btnReporte.TabIndex = 2;
            btnReporte.Text = "Ver reporte";
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 478);
            Controls.Add(btnReporte);
            Controls.Add(dgvMovimientos);
            Controls.Add(groupBox1);
            Name = "FormConsulta";
            Text = "FormConsulta";
            Load += FormConsulta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timerHora;
        private Label lblUsername;
        private Label lblRol;
        private Label lblFechaHora;
        private DataGridView dgvMovimientos;
        private Button btnReporte;
    }
}