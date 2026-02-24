namespace CapaPresentacion
{
    partial class FormReporteDeFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPMostrarFacturaEspecificaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaVentasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaVentasDataSet = new CapaPresentacion.SistemaVentasDataSet();
            this.sPMostrarFacturaEspecificaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sPMostrarFacturaEspecificaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Mostrar_Factura_EspecificaTableAdapter = new CapaPresentacion.SistemaVentasDataSetTableAdapters.SP_Mostrar_Factura_EspecificaTableAdapter();
            this.SP_Mostrar_Factura_EspecificaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaVentasDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sPMostrarFacturaEspecificaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaEspecificaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaEspecificaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaEspecificaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Mostrar_Factura_EspecificaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaEspecificaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // sPMostrarFacturaEspecificaBindingSource3
            // 
            this.sPMostrarFacturaEspecificaBindingSource3.DataMember = "SP_Mostrar_Factura_Especifica";
            this.sPMostrarFacturaEspecificaBindingSource3.DataSource = this.sistemaVentasDataSetBindingSource;
            // 
            // sistemaVentasDataSetBindingSource
            // 
            this.sistemaVentasDataSetBindingSource.DataSource = this.sistemaVentasDataSet;
            this.sistemaVentasDataSetBindingSource.Position = 0;
            // 
            // sistemaVentasDataSet
            // 
            this.sistemaVentasDataSet.DataSetName = "SistemaVentasDataSet";
            this.sistemaVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMostrarFacturaEspecificaBindingSource1
            // 
            this.sPMostrarFacturaEspecificaBindingSource1.DataMember = "SP_Mostrar_Factura_Especifica";
            this.sPMostrarFacturaEspecificaBindingSource1.DataSource = this.sistemaVentasDataSetBindingSource;
            // 
            // sPMostrarFacturaEspecificaBindingSource
            // 
            this.sPMostrarFacturaEspecificaBindingSource.DataMember = "SP_Mostrar_Factura_Especifica";
            this.sPMostrarFacturaEspecificaBindingSource.DataSource = this.sistemaVentasDataSetBindingSource;
            // 
            // sP_Mostrar_Factura_EspecificaTableAdapter
            // 
            this.sP_Mostrar_Factura_EspecificaTableAdapter.ClearBeforeFill = true;
            // 
            // SP_Mostrar_Factura_EspecificaBindingSource
            // 
            this.SP_Mostrar_Factura_EspecificaBindingSource.DataMember = "SP_Mostrar_Factura_Especifica";
            this.SP_Mostrar_Factura_EspecificaBindingSource.DataSource = this.sistemaVentasDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPMostrarFacturaEspecificaBindingSource3;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1791, 781);
            this.reportViewer1.TabIndex = 0;
            // 
            // sPMostrarFacturaEspecificaBindingSource2
            // 
            this.sPMostrarFacturaEspecificaBindingSource2.DataMember = "SP_Mostrar_Factura_Especifica";
            this.sPMostrarFacturaEspecificaBindingSource2.DataSource = this.sistemaVentasDataSetBindingSource;
            // 
            // FormReporteDeFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 781);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteDeFactura";
            this.Text = "FormReporteDeFactura";
            this.Load += new System.EventHandler(this.FormReporteDeFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaEspecificaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaEspecificaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaEspecificaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Mostrar_Factura_EspecificaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarFacturaEspecificaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sistemaVentasDataSetBindingSource;
        private SistemaVentasDataSet sistemaVentasDataSet;
        private System.Windows.Forms.BindingSource sPMostrarFacturaEspecificaBindingSource;
        private SistemaVentasDataSetTableAdapters.SP_Mostrar_Factura_EspecificaTableAdapter sP_Mostrar_Factura_EspecificaTableAdapter;
        private System.Windows.Forms.BindingSource SP_Mostrar_Factura_EspecificaBindingSource;
        private System.Windows.Forms.BindingSource sistemaVentasDataSet1BindingSource;
        private System.Windows.Forms.BindingSource sPMostrarFacturaEspecificaBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPMostrarFacturaEspecificaBindingSource3;
        private System.Windows.Forms.BindingSource sPMostrarFacturaEspecificaBindingSource2;
    }
}