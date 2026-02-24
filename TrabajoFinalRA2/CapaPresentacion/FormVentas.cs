using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormVentas : Form
    {
        private int IDVentaActual = 0;
        private decimal totalAcumulado = 0;

        public FormVentas()
        {
            InitializeComponent();
            CargarClientes();
            CargarProductos();
            InicializarDataGrid();
            txtTotal.Enabled = false;
            btnAgregar.Enabled = false;
            btnFacturar.Enabled = false;
        }

        private void InicializarDataGrid()
        {
            dgvDetalle.Columns.Clear();

            dgvDetalle.Columns.Add("ID_producto", "ID Producto");   
            dgvDetalle.Columns.Add("Producto", "Producto");
            dgvDetalle.Columns.Add("Categoria", "Categoría");
            dgvDetalle.Columns.Add("Precio", "Precio");
            dgvDetalle.Columns.Add("Cantidad", "Cantidad");
            dgvDetalle.Columns.Add("Subtotal", "Subtotal");

            dgvDetalle.Columns["ID_producto"].Visible = false;
            dgvDetalle.Columns["Categoria"].Visible = false;

            dgvDetalle.Columns["Producto"].Width = 150;
            dgvDetalle.Columns["Precio"].Width = 70;
            dgvDetalle.Columns["Cantidad"].Width = 70;
            dgvDetalle.Columns["Subtotal"].Width = 80;

        }

        private void CargarClientes()
        {
            ClientesBL clienteBL = new ClientesBL();
            cmbCliente.DataSource = clienteBL.Listar();
            cmbCliente.DisplayMember = "Nombre";      
            cmbCliente.ValueMember = "ID_cliente";   
            cmbCliente.SelectedIndex = -1;
        }

        private void CargarProductos()
        {
            ProductoBL prodBL = new ProductoBL();
            cmbProducto.DataSource = prodBL.Listar(); 
            cmbProducto.DisplayMember = "Nombre_producto";
            cmbProducto.ValueMember = "ID_producto";
            cmbProducto.SelectedIndex = -1;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCrear.Enabled = cmbCliente.SelectedIndex != -1;
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }
            btnAgregar.Enabled = true;
            btnFacturar.Enabled = true;
            cmbProducto.Enabled = true;
            txtCantidad.Enabled = true;
            cmbCliente.Enabled = false;
            btnAgregar.Enabled = true;
            btnCrear.Enabled = false;

            Ventas venta = new Ventas
            {
                Fecha_venta = DateTime.Now,
                ID_cliente = (int)cmbCliente.SelectedValue,
                Estado = true
            };

            VentasBL ventasBL = new VentasBL();
            IDVentaActual = ventasBL.Guardar(venta);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            Producto prod = (Producto)cmbProducto.SelectedItem;         

            if (cantidad > prod.Stock)
            {
                MessageBox.Show("No hay suficiente stock.");
                return;
            }

            decimal subtotal = prod.Precio_producto * cantidad;

            dgvDetalle.Rows.Add(
            prod.ID_producto,
            prod.Nombre_producto,
            prod.ObjCategoria?.Nombre_categoria ?? "",
            prod.Precio_producto,
            cantidad,
            prod.Precio_producto * cantidad
            );

            totalAcumulado += subtotal;
            txtTotal.Text = totalAcumulado.ToString("C");

            cmbProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (IDVentaActual == 0)
            {
                MessageBox.Show("Primero cree la venta con un cliente.");
                return;
            }

            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Agregue productos antes de facturar.");
                return;
            }

            VentasBL ventasBL = new VentasBL();

            Ventas venta = new Ventas
            {
                ID_venta = IDVentaActual,
                Total_general = totalAcumulado
            };
            ventasBL.ActualizarTotal(venta);

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                int idProducto = Convert.ToInt32(fila.Cells["ID_producto"].Value);
                Producto prod = new ProductoBL().Listar()
                                 .FirstOrDefault(p => p.ID_producto == idProducto);

                if (prod == null)
                {
                    continue; 
                }

                decimal cantidad = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);

                DetalleVenta detalle = new DetalleVenta
                {
                    ID_venta = IDVentaActual,
                    ID_producto = idProducto,
                    Cantidad = cantidad,
                    Precio = precio,
                    Subtotal = cantidad * precio
                };

                ventasBL.GuardarDetalle(detalle);
                btnAgregar.Enabled = false;
                btnFacturar.Enabled = false;
            }

            int idVenta = IDVentaActual;

            dgvDetalle.Rows.Clear();
            totalAcumulado = 0;
            txtTotal.Text = "";
            cmbCliente.SelectedIndex = -1;
            IDVentaActual = 0;
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
            
            FormReporteDeFactura frmFactura = new FormReporteDeFactura(idVenta);
            frmFactura.ShowDialog();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            FormCategoria frm = new FormCategoria();
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }
    }
}
