using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaDato;

namespace CapaPresentacion
{
    public partial class FormReporteMovimientos : Form
    {
        private int _idMovimiento;

        public FormReporteMovimientos(int idMovimiento)
        {
            InitializeComponent();
            _idMovimiento = idMovimiento;
            WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Reporte de Movimientos";
        }

        private void FormReporteMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                MovimientoDAL dal = new MovimientoDAL();

                DataTable dt = dal.ObtenerReporteMovimientos(_idMovimiento);

                reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Reportes.Report1.rdlc";

                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}