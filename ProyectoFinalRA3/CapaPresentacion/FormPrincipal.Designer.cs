namespace CapaPresentacion
{
    partial class FormPrincipal
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
            btnMovimiento = new Button();
            btnCategoria = new Button();
            btnProducto = new Button();
            groupBox1 = new GroupBox();
            lblFechaHora = new Label();
            lblRol = new Label();
            lblUsername = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            btnConsulta = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMovimiento
            // 
            btnMovimiento.Location = new Point(37, 235);
            btnMovimiento.Name = "btnMovimiento";
            btnMovimiento.Size = new Size(238, 61);
            btnMovimiento.TabIndex = 0;
            btnMovimiento.Text = "MOVIMIENTO";
            btnMovimiento.UseVisualStyleBackColor = true;
            btnMovimiento.Click += btnMovimiento_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(525, 235);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(238, 61);
            btnCategoria.TabIndex = 1;
            btnCategoria.Text = "CATEGORIA";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(281, 235);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(238, 61);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "PRODUCTO";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFechaHora);
            groupBox1.Controls.Add(lblRol);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Location = new Point(534, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 110);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bienvenido";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(6, 77);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(0, 25);
            lblFechaHora.TabIndex = 2;
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
            // btnConsulta
            // 
            btnConsulta.Location = new Point(281, 302);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(238, 61);
            btnConsulta.TabIndex = 4;
            btnConsulta.Text = "CONSULTA";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsulta);
            Controls.Add(groupBox1);
            Controls.Add(btnProducto);
            Controls.Add(btnCategoria);
            Controls.Add(btnMovimiento);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMovimiento;
        private Button btnCategoria;
        private Button btnProducto;
        private GroupBox groupBox1;
        private Label lblRol;
        private Label lblUsername;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer timerHora;
        private Button btnConsulta;
    }
}