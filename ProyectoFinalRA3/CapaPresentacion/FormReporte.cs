using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaDato;
using ClassLibrary1;
using System.Collections.Generic;

namespace CapaPresentacion
{
    public partial class FormReporte : Form
    {
        private MovimientoDAL dalMovimiento;

        public FormReporte()
        {
            InitializeComponent();
            dalMovimiento = new MovimientoDAL();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            List<MovimientoDTO> lista = dalMovimiento.Listar();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_movimiento", typeof(int));
            dt.Columns.Add("tipo_movimiento", typeof(string));
            dt.Columns.Add("fecha", typeof(DateTime));
            dt.Columns.Add("usuario", typeof(string));

            foreach (var m in lista)
            {
                dt.Rows.Add(m.id_movimiento, m.tipo_movimiento, m.fecha, m.usuario);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("MovimientoDS", dt)
            );

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "CapaPresentacion.ReporteMovimientos.rdlc";

            reportViewer1.RefreshReport();
        }
    }
}