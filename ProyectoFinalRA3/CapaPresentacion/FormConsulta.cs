using System;
using System.Data;
using System.Windows.Forms;
using CapaDato;
using CapaNegocios;
using ClassLibrary1;
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class FormConsulta : Form
    {
        private UsuarioDTO _usuario;
        private MovimientoDAL dalMovimiento;

        public FormConsulta(UsuarioDTO usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            dalMovimiento = new MovimientoDAL(); // Inicializa DAL
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Reportes";
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            CargarMovimientos(); // Carga movimientos en el DataGridView

            lblUsername.Text = _usuario.username; // Muestra username
            lblRol.Text = _usuario.nombre_rol;    // Muestra rol
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void CargarMovimientos()
        {
            List<MovimientoDTO> lista = dalMovimiento.Listar(); // ✅ List<MovimientoDTO>
            dgvMovimientos.DataSource = lista; // DataGridView puede enlazar listas de objetos

            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.AllowUserToAddRows = false;

            if (dgvMovimientos.Columns.Contains("id_movimiento"))
                dgvMovimientos.Columns["id_movimiento"].Visible = false;
            if (dgvMovimientos.Columns.Contains("id_usuario"))
                dgvMovimientos.Columns["id_usuario"].Visible = false;

            if (dgvMovimientos.Columns.Contains("tipo_movimiento"))
                dgvMovimientos.Columns["tipo_movimiento"].HeaderText = "Tipo";

            if (dgvMovimientos.Columns.Contains("fecha"))
            {
                dgvMovimientos.Columns["fecha"].HeaderText = "Fecha";
                dgvMovimientos.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvMovimientos.Columns.Contains("usuario"))
                dgvMovimientos.Columns["usuario"].HeaderText = "Usuario";
        }

        // Cargar ReportViewer con la lista de movimientos
        private void CargarReporte()
        {
            // Obtiene los movimientos y sus detalles
            List<MovimientoDTO> listaMovimientos = dalMovimiento.Listar();

            // Si quieres, convierte lista de movimientos a DataTable para RDLC
            DataTable dtMov = new DataTable();
            dtMov.Columns.Add("id_movimiento", typeof(int));
            dtMov.Columns.Add("tipo_movimiento", typeof(string));
            dtMov.Columns.Add("fecha", typeof(DateTime));
            dtMov.Columns.Add("usuario", typeof(string));

            foreach (var m in listaMovimientos)
            {
                dtMov.Rows.Add(m.id_movimiento, m.tipo_movimiento, m.fecha, m.usuario);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("MovimientoDS", dtMov));
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteMovimientos.rdlc";

            reportViewer1.RefreshReport();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); // Actualiza hora
        }
    }
}