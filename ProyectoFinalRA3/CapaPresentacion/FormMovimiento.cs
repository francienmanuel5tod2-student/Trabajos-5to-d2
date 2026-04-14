using System.Data;
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
                CargarProductos(); // recarga productos según el tipo
            }
        }
        private void CargarProductos()
        {
            cmbProducto.DataSource = null;
            cmbProducto.Items.Clear();

            List<ProductoDTO> productos = new List<ProductoDTO>();

            if (cmbTipoMovimiento.SelectedItem != null && cmbTipoMovimiento.SelectedItem.ToString() == "Entrada")
            {
                // Entrada: solo productos del proveedor seleccionado
                if (cmbEntidad.SelectedItem != null)
                {
                    // Tomamos el objeto seleccionado y su id
                    if (cmbEntidad.SelectedItem is ProveedorDTO proveedor)
                    {
                        int idProveedor = proveedor.id_proveedor;
                        productos = dalProducto.ListarPorProveedor (idProveedor);
                    }
                }
            }
            else
            {
                // Salida: listar todos los productos
                productos = dalProducto.Listar();
            }

            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "id_producto";
            cmbProducto.SelectedIndex = -1;
        }

        // Cuando se selecciona proveedor/cliente
        private void cmbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMovimiento.SelectedItem.ToString() == "Entrada")
            {
                // Si es Entrada, filtra productos por proveedor
                CargarProductos();
            }
        }

        // Botón para deseleccionar entidad
        private void btnDesceleccionar_Click(object sender, EventArgs e)
        {
            cmbEntidad.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
        }

        // Obtener ID seleccionado de manera segura
        private int ObtenerIdSeleccionado()
        {
            if (cmbEntidad.SelectedValue != null && int.TryParse(cmbEntidad.SelectedValue.ToString(), out int id))
                return id;

            return 0;
        }

        // Guardar movimiento
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEntidad.SelectedIndex == -1 || cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione entidad y producto.");
                return;
            }

            int idEntidad = ObtenerIdSeleccionado();
            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);

            MovimientoDTO movimiento = new MovimientoDTO
            {
                tipo_movimiento = cmbTipoMovimiento.SelectedItem.ToString(),
                fecha = DateTime.Now,
                id_usuario = _usuario.id_usuario,
                detalles = new List<DetalleMovimientoDTO>
                {
                new DetalleMovimientoDTO
                {
            id_producto = idProducto,
            cantidad = Convert.ToInt32(txtCantidad.Text)
                }
                }
            };

            dalMovimiento.Insertar(movimiento);

            MessageBox.Show("Movimiento registrado correctamente.");
            lblNMovimiento.Text = dalMovimiento.ObtenerSiguienteMovimiento().ToString();
            cmbEntidad.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Clear();
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

            dgvMovimientos.Rows.Clear();
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

            ProductoDTO producto = cmbProducto.SelectedItem as ProductoDTO;

            foreach (DataGridViewRow row in dgvMovimientos.Rows)
            {
                if ((int)row.Cells["id_producto"].Value == producto.id_producto)
                {
                    row.Cells["cantidad"].Value = (int)row.Cells["cantidad"].Value + cantidad;
                    return;
                }
            }

            dgvMovimientos.Rows.Add(
                producto.id_producto,
                producto.nombre,
                cantidad,
                producto.categoria 
            );

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
            if (cmbEntidad.SelectedIndex == -1 || dgvMovimientos.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione entidad y agregue al menos un producto.");
                return;
            }

            int idEntidad = ObtenerIdSeleccionado();
            List<DetalleMovimientoDTO> detalles = new List<DetalleMovimientoDTO>();

            foreach (DataGridViewRow row in dgvMovimientos.Rows)
            {
                detalles.Add(new DetalleMovimientoDTO
                {
                    id_producto = (int)row.Cells["id_producto"].Value,
                    cantidad = (int)row.Cells["cantidad"].Value
                });
            }

            MovimientoDTO movimiento = new MovimientoDTO
            {
                tipo_movimiento = cmbTipoMovimiento.SelectedItem.ToString(),
                fecha = DateTime.Now,
                id_usuario = _usuario.id_usuario,
                detalles = detalles
            };

            // Primero insertamos el movimiento en la tabla Movimientos y Detalles
            dalMovimiento.Insertar(movimiento);

            // Ahora actualizamos el stock según el tipo de movimiento
            foreach (var detalle in detalles)
            {
                using (SqlConnection con = Conexion.ObtenerConexion()) // ✅ FIX
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        movimiento.tipo_movimiento == "Entrada"
                            ? "SP_ActualizarStockEntrada"
                            : "SP_ActualizarStockSalida",
                        con
                    );

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_producto", detalle.id_producto);
                    cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Movimiento registrado correctamente.");

            // Limpiar formulario
            dgvMovimientos.Rows.Clear();
            cmbEntidad.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Clear();
            lblNMovimiento.Text = dalMovimiento.ObtenerSiguienteMovimiento().ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Confirmamos con el usuario si desea cancelar
            DialogResult result = MessageBox.Show(
                "¿Desea cancelar y restablecer el formulario?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Llamamos al método que limpia y reinicia todos los controles
                RestablecerFormulario();
            }
        }
        private void RestablecerFormulario()
        {
            // Limpiar el DataGridView
            dgvMovimientos.Rows.Clear();

            // Reiniciar tipo de movimiento y entidad
            cmbTipoMovimiento.SelectedIndex = 0;
            CambiarEntidad(cmbTipoMovimiento.SelectedItem.ToString());
            CargarProductos();

            // Limpiar selecciones y campos
            cmbEntidad.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Clear();

            // Actualizar número de movimiento
            lblNMovimiento.Text = dalMovimiento.ObtenerSiguienteMovimiento().ToString();
        }
    }
}