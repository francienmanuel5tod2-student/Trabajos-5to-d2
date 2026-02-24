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
    public partial class Reportes : Form
    {
        int IdVentaSeleccionada = 0;
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            FormCategoria frm = new FormCategoria();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProductos frm = new FormProductos();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }
        private void Reportes_Load(object sender, EventArgs e)
        {
            this.ventaTableAdapter.Fill(this.sistemaVentasDataSet.Ventas);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormVentas frm = new FormVentas();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }

        public void btnFacturar_Click(object sender, EventArgs e)
        {

            if (IdVentaSeleccionada <= 0)
            {
                MessageBox.Show("Seleccione una venta primero");
                return;
            }
            FormReporteDeFactura frm = new FormReporteDeFactura(IdVentaSeleccionada);
            frm.ShowDialog(); 
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdVentaSeleccionada = Convert.ToInt32(
            dgvVentas.CurrentRow.Cells["IDventaDataGridViewTextBoxColumn"].Value);
        }
    }
}
