using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CapaDato;
using ClassLibrary1;
using Microsoft.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormMovimiento : Form
    {
        private UsuarioDTO _usuario;
        private MovimientoDAL dalMovimiento = new MovimientoDAL();
        private ProductoDAL dalProducto = new ProductoDAL();
        private ProveedorDAL dalProveedor = new ProveedorDAL();
        private ClienteDAL dalCliente = new ClienteDAL();
        private int filaEditando = -1;
        public FormMovimiento(UsuarioDTO usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
        }

        private void FormMovimiento_Load(object sender, EventArgs e)
        {
            ConfigurarDGV();
            lblUsuario.Text = _usuario.username;
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cmbTipoMovimiento.SelectedIndex = 0;
            CambiarEntidad(cmbTipoMovimiento.SelectedItem.ToString());
            CargarProductos();
            lblNMovimiento.Text = dalMovimiento.ObtenerSiguienteMovimiento().ToString();
        }
        private void dgvMovimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMovimientos.Rows[e.RowIndex];

                filaEditando = e.RowIndex;

                cmbProducto.Text = row.Cells["producto"].Value.ToString();
                txtCantidad.Text = row.Cells["cantidad"].Value.ToString();
                cmbEntidad.Text = row.Cells["responsable"].Value.ToString();
            }
        }
        private void CambiarEntidad(string tipoMovimiento)
        {
            cmbEntidad.DataSource = null;
            cmbEntidad.Items.Clear();

            if (tipoMovimiento == "Entrada") // proveedores
            {
                lblTipo.Text = "Proveedor";
                cmbEntidad.DataSource = dalProveedor.Listar();
                cmbEntidad.DisplayMember = "nombre";
                cmbEntidad.ValueMember = "id_proveedor";
            }
            else
            {
                lblTipo.Text = "Cliente";
                cmbEntidad.DataSource = dalCliente.Listar();
                cmbEntidad.DisplayMember = "nombre_completo";
                cmbEntidad.ValueMember = "id_cliente";
            }

            cmbEntidad.SelectedIndex = -1;
        }


        private void cmbTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMovimiento.SelectedItem != null)
            {
                CambiarEntidad(cmbTipoMovimiento.SelectedItem.ToString());
                CargarProductos();
            }
        }
        private void CargarProductos()
        {
            cmbProducto.DataSource = null;
            cmbProducto.Items.Clear();

            List<ProductoDTO> productos = new List<ProductoDTO>();

            if (cmbTipoMovimiento.SelectedItem != null && cmbTipoMovimiento.SelectedItem.ToString() == "Entrada")
            {
                
                if (cmbEntidad.SelectedItem != null)
                {
                    
                    if (cmbEntidad.SelectedItem is ProveedorDTO proveedor)
                    {
                        int idProveedor = proveedor.id_proveedor;
                        productos = dalProducto.ListarPorProveedor(idProveedor);
                    }
                }
            }
            else
            {
               
                productos = dalProducto.Listar();
            }

            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "id_producto";
            cmbProducto.SelectedIndex = -1;
        }

        private void cmbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMovimiento.SelectedItem.ToString() == "Entrada")
            {
                CargarProductos();
            }
        }

        private int ObtenerIdSeleccionado()
        {
            if (cmbEntidad.SelectedValue != null && int.TryParse(cmbEntidad.SelectedValue.ToString(), out int id))
                return id;

            return 0;
        }

        private void ConfigurarDGV()
        {
            dgvMovimientos.DataSource = null;
            dgvMovimientos.Columns.Clear();
            dgvMovimientos.AutoGenerateColumns = false;
            dgvMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "id_producto",
                HeaderText = "ID Producto",
                DataPropertyName = "id_producto",
                Visible = false
            });
            dgvMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "producto",
                HeaderText = "Producto",
                DataPropertyName = "nombre"
            });
            dgvMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "cantidad"
            });
            dgvMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "categoria",
                HeaderText = "Categoría",
                DataPropertyName = "categoria"
            });
            dgvMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "responsable",
                HeaderText = "Proveedor/Cliente"
            });

            dgvMovimientos.Rows.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (cmbEntidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione proveedor/cliente.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            ProductoDTO producto = cmbProducto.SelectedItem as ProductoDTO;
            string nombreResponsable = cmbEntidad.Text;

            if (filaEditando >= 0)
            {
                DataGridViewRow row = dgvMovimientos.Rows[filaEditando];

                row.Cells["id_producto"].Value = producto.id_producto;
                row.Cells["producto"].Value = producto.nombre;
                row.Cells["cantidad"].Value = cantidad;
                row.Cells["categoria"].Value = producto.categoria;
                row.Cells["responsable"].Value = nombreResponsable;

                filaEditando = -1;
            }
            else
            {
                foreach (DataGridViewRow row in dgvMovimientos.Rows)
                {
                    if ((int)row.Cells["id_producto"].Value == producto.id_producto)
                    {
                        int cantidadActual = (int)row.Cells["cantidad"].Value;
                        row.Cells["cantidad"].Value = cantidadActual + cantidad;
                        return;
                    }
                }

                dgvMovimientos.Rows.Add(
                    producto.id_producto,
                    producto.nombre,
                    cantidad,
                    producto.categoria,
                    nombreResponsable
                );
            }

            cmbProducto.SelectedIndex = -1;
            txtCantidad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMovimientos.CurrentRow != null)
            {
                dgvMovimientos.Rows.Remove(dgvMovimientos.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para quitar.");
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (dgvMovimientos.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.");
                return;
            }

            string tipoMovimiento = cmbTipoMovimiento.Text;

            List<DetalleMovimientoDTO> detalles = new List<DetalleMovimientoDTO>();

            foreach (DataGridViewRow row in dgvMovimientos.Rows)
            {
                if (row.IsNewRow) continue;

                DetalleMovimientoDTO detalle = new DetalleMovimientoDTO
                {
                    id_producto = (int)row.Cells["id_producto"].Value,
                    cantidad = (int)row.Cells["cantidad"].Value
                };

                string nombreResponsable = row.Cells["responsable"].Value.ToString();

                if (tipoMovimiento == "Entrada")
                {
                    var proveedor = dalProveedor.Listar()
                        .FirstOrDefault(p => p.nombre == nombreResponsable);

                    if (proveedor != null)
                        detalle.id_proveedor = proveedor.id_proveedor;
                }
                else
                {
                    var cliente = dalCliente.Listar()
                        .FirstOrDefault(c => c.nombre_completo == nombreResponsable);

                    if (cliente != null)
                        detalle.id_cliente = cliente.id_cliente;
                }

                detalles.Add(detalle);
            }

            MovimientoDTO movimiento = new MovimientoDTO
            {
                tipo_movimiento = tipoMovimiento,
                fecha = DateTime.Now,
                id_usuario = _usuario.id_usuario,
                detalles = detalles
            };

            try
            {
                int idMovimiento = dalMovimiento.Insertar(movimiento);

                MessageBox.Show("Movimiento registrado correctamente.");

                FormReporteMovimientos frm = new FormReporteMovimientos(idMovimiento);
                frm.ShowDialog();

                dgvMovimientos.Rows.Clear();
                cmbEntidad.SelectedIndex = -1;
                cmbProducto.SelectedIndex = -1;
                txtCantidad.Clear();
                lblNMovimiento.Text = dalMovimiento.ObtenerSiguienteMovimiento().ToString();

                cmbTipoMovimiento.Enabled = true;
                cmbEntidad.Enabled = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Desea cancelar y restablecer el formulario?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                RestablecerFormulario();
            }
        }
        private void RestablecerFormulario()
        {
            dgvMovimientos.Rows.Clear();

            cmbTipoMovimiento.SelectedIndex = 0;
            CambiarEntidad(cmbTipoMovimiento.SelectedItem.ToString());
            CargarProductos();

            cmbEntidad.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Clear();

            lblNMovimiento.Text = dalMovimiento.ObtenerSiguienteMovimiento().ToString();
            cmbTipoMovimiento.Enabled = true;            
        }
    }
}