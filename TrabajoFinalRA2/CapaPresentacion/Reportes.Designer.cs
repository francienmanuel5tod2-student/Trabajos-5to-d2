namespace CapaPresentacion
{
    partial class Reportes
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
            this.components = new System.ComponentModel.Container();
            this.sistemaVentasDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaVentasDataSet = new CapaPresentacion.SistemaVentasDataSet();
            this.sPMostrarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaVentasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.sP_Mostrar_FacturaTableAdapter = new CapaPresentacion.SistemaVentasDataSetTableAdapters.SP_Mostrar_Factura_EspecificaTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.iDventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalgeneralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ventaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new CapaPresentacion.SistemaVentasDataSetTableAdapters.VentasTableAdapter();
            this.SP_Mostrar_Factura_EspecificaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Mostrar_Factura_EspecificaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaVentasDataSetBindingSource1
            // 
            this.sistemaVentasDataSetBindingSource1.DataSource = this.sistemaVentasDataSet;
            this.sistemaVentasDataSetBindingSource1.Position = 0;
            // 
            // sistemaVentasDataSet
            // 
            this.sistemaVentasDataSet.DataSetName = "SistemaVentasDataSet";
            this.sistemaVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMostrarFacturaBindingSource
            // 
            this.sPMostrarFacturaBindingSource.DataMember = "SP_Mostrar_Factura_Especifica";
            this.sPMostrarFacturaBindingSource.DataSource = this.sistemaVentasDataSetBindingSource;
            // 
            // sistemaVentasDataSetBindingSource
            // 
            this.sistemaVentasDataSetBindingSource.DataSource = this.sistemaVentasDataSet;
            this.sistemaVentasDataSetBindingSource.Position = 0;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(456, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 29);
            this.button3.TabIndex = 23;
            this.button3.Text = "Facturas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = "Productos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(12, 12);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(214, 29);
            this.btnCambiar.TabIndex = 21;
            this.btnCambiar.Text = "Categorias";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // sP_Mostrar_FacturaTableAdapter
            // 
            this.sP_Mostrar_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(680, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 29);
            this.button4.TabIndex = 32;
            this.button4.Text = "Ventas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(87, 733);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(363, 77);
            this.btnFacturar.TabIndex = 33;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoGenerateColumns = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDventaDataGridViewTextBoxColumn,
            this.fechaventaDataGridViewTextBoxColumn,
            this.iDclienteDataGridViewTextBoxColumn,
            this.totalgeneralDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.dgvVentas.DataSource = this.ventaBindingSource1;
            this.dgvVentas.Location = new System.Drawing.Point(22, 82);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 62;
            this.dgvVentas.RowTemplate.Height = 28;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(572, 635);
            this.dgvVentas.TabIndex = 34;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            // 
            // iDventaDataGridViewTextBoxColumn
            // 
            this.iDventaDataGridViewTextBoxColumn.DataPropertyName = "ID_venta";
            this.iDventaDataGridViewTextBoxColumn.HeaderText = "ID_venta";
            this.iDventaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDventaDataGridViewTextBoxColumn.Name = "iDventaDataGridViewTextBoxColumn";
            this.iDventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDventaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaventaDataGridViewTextBoxColumn
            // 
            this.fechaventaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_venta";
            this.fechaventaDataGridViewTextBoxColumn.HeaderText = "Fecha_venta";
            this.fechaventaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaventaDataGridViewTextBoxColumn.Name = "fechaventaDataGridViewTextBoxColumn";
            this.fechaventaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDclienteDataGridViewTextBoxColumn
            // 
            this.iDclienteDataGridViewTextBoxColumn.DataPropertyName = "ID_cliente";
            this.iDclienteDataGridViewTextBoxColumn.HeaderText = "ID_cliente";
            this.iDclienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDclienteDataGridViewTextBoxColumn.Name = "iDclienteDataGridViewTextBoxColumn";
            this.iDclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDclienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalgeneralDataGridViewTextBoxColumn
            // 
            this.totalgeneralDataGridViewTextBoxColumn.DataPropertyName = "Total_general";
            this.totalgeneralDataGridViewTextBoxColumn.HeaderText = "Total_general";
            this.totalgeneralDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalgeneralDataGridViewTextBoxColumn.Name = "totalgeneralDataGridViewTextBoxColumn";
            this.totalgeneralDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estadoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ventaBindingSource1
            // 
            this.ventaBindingSource1.DataMember = "Ventas";
            this.ventaBindingSource1.DataSource = this.sistemaVentasDataSetBindingSource;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Ventas";
            this.ventaBindingSource.DataSource = this.sistemaVentasDataSetBindingSource;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // SP_Mostrar_Factura_EspecificaBindingSource
            // 
            this.SP_Mostrar_Factura_EspecificaBindingSource.DataMember = "SP_Mostrar_Factura_Especifica";
            this.SP_Mostrar_Factura_EspecificaBindingSource.DataSource = this.sistemaVentasDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "VENTAS:";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 885);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCambiar);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Mostrar_Factura_EspecificaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.BindingSource sistemaVentasDataSetBindingSource;
        private SistemaVentasDataSet sistemaVentasDataSet;
        private System.Windows.Forms.BindingSource sPMostrarFacturaBindingSource;
        private SistemaVentasDataSetTableAdapters.SP_Mostrar_Factura_EspecificaTableAdapter sP_Mostrar_FacturaTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private SistemaVentasDataSetTableAdapters.VentasTableAdapter ventaTableAdapter;
        private System.Windows.Forms.BindingSource ventaBindingSource1;
        private System.Windows.Forms.BindingSource SP_Mostrar_Factura_EspecificaBindingSource;
        private System.Windows.Forms.BindingSource sistemaVentasDataSetBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalgeneralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
    }
}