using System;
using System.Collections.Generic;
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
            dalMovimiento = new MovimientoDAL(); 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Reportes";
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            CargarMovimientos(); 

            lblUsername.Text = _usuario.username; 
            lblRol.Text = _usuario.nombre_rol;    
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void CargarMovimientos()
        {
            List<MovimientoDTO> lista = dalMovimiento.Listar(); 
            dgvMovimientos.DataSource = lista;

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

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); 
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvMovimientos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un movimiento.");
                return;
            }

            try
            {
                int idMovimiento = Convert.ToInt32(
                    dgvMovimientos.CurrentRow.Cells["id_movimiento"].Value
                );

                FormReporteMovimientos frm = new FormReporteMovimientos(idMovimiento);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
        }
    }
}