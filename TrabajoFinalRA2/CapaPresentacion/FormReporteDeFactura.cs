using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class FormReporteDeFactura : Form
    {
        private int idVenta;

        public FormReporteDeFactura(int idVentaRecibido)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            idVenta = idVentaRecibido;
            CargarReporte();
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }

        private void FormReporteDeFactura_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void CargarReporte()
        {
            SistemaVentasDataSet ds = new SistemaVentasDataSet();
            var ta = new SistemaVentasDataSetTableAdapters.SP_Mostrar_Factura_EspecificaTableAdapter();

            ds.EnforceConstraints = false;
            ta.Fill(ds.SP_Mostrar_Factura_Especifica, idVenta);

            if (ds.SP_Mostrar_Factura_Especifica.Rows.Count == 0)
                return;

            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Report1.rdlc";

            ReportDataSource rds = new ReportDataSource(
                "DataSet1",
                ds.SP_Mostrar_Factura_Especifica.DefaultView
            );

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
