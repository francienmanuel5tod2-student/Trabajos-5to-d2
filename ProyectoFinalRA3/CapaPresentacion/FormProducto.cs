using CapaDato;
using ClassLibrary1;

namespace CapaPresentacion
{
    public partial class FormProducto : Form
    {
        private UsuarioDTO _usuario;
        int IDProductoSeleccionado = 0;
        ProductoDAL dal = new ProductoDAL();

        public FormProducto(UsuarioDTO usuario)
        {
            InitializeComponent();
            _usuario = usuario;

            CargarCategorias();
            CargarProveedores();
            CargarProductos();

            dgvProductos.ClearSelection();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Productos";
        }
        private void CargarProductos()
        {
            dgvProductos.DataSource = dal.Listar();

            dgvProductos.Columns["id_producto"].Visible = false;

            dgvProductos.Columns["nombre"].HeaderText = "Producto";
            dgvProductos.Columns["stock"].HeaderText = "Stock";
            dgvProductos.Columns["categoria"].HeaderText = "Categoría";
            dgvProductos.Columns["usuario"].HeaderText = "Creado por";
            dgvProductos.Columns["proveedor"].HeaderText = "Proveedor";
            dgvProductos.Columns["fecha_creacion"].HeaderText = "Fecha";

            dgvProductos.ClearSelection();
            IDProductoSeleccionado = 0;
        }
        private void Limpiar()
        {
            txtNombreProducto.Clear();
            txtStockProducto.Clear();
            cmbCategoriaProducto.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;

            dgvProductos.ClearSelection();
            dgvProductos.CurrentCell = null;

            IDProductoSeleccionado = 0;
            btnAgregarProducto.Text = "Agregar";
        }
        private void CargarCategorias()
        {
            CategoriaDAL dalCat = new CategoriaDAL();
            cmbCategoriaProducto.DataSource = dalCat.Listar();
            cmbCategoriaProducto.DisplayMember = "nombre";
            cmbCategoriaProducto.ValueMember = "ID_categoria";
            cmbCategoriaProducto.SelectedIndex = -1;
        }
        private void CargarProveedores()
        {
            ProveedorDAL dalProv = new ProveedorDAL();
            cmbProveedor.DataSource = dalProv.Listar();
            cmbProveedor.DisplayMember = "nombre";
            cmbProveedor.ValueMember = "id_proveedor";
            cmbProveedor.SelectedIndex = -1;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
       string.IsNullOrWhiteSpace(txtStockProducto.Text) ||
       cmbCategoriaProducto.SelectedValue == null ||
       cmbProveedor.SelectedValue == null)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!int.TryParse(txtStockProducto.Text, out int stock))
            {
                MessageBox.Show("Stock inválido");
                return;
            }

            ProductoDTO p = new ProductoDTO
            {
                id_producto = IDProductoSeleccionado,
                nombre = txtNombreProducto.Text.Trim(),
                stock = stock
            };

            if (IDProductoSeleccionado == 0)
            {
                dal.Insertar(
                    p,
                    Convert.ToInt32(cmbCategoriaProducto.SelectedValue),
                    _usuario.id_usuario,
                    Convert.ToInt32(cmbProveedor.SelectedValue)
                );

                MessageBox.Show("Producto agregado correctamente");
            }
            else
            {
                DialogResult r = MessageBox.Show("¿Modificar producto?",
                    "Confirmar", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    dal.Actualizar(
                        p,
                        Convert.ToInt32(cmbCategoriaProducto.SelectedValue),
                        Convert.ToInt32(cmbProveedor.SelectedValue)
                    );

                    MessageBox.Show("Producto actualizado correctamente");
                }
            }

            Limpiar();
            CargarProductos();
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_producto"].Value);

            DialogResult r = MessageBox.Show("¿Eliminar producto?",
                "Confirmar", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                dal.Eliminar(id);
                MessageBox.Show("Producto eliminado");
                CargarProductos();
                Limpiar();
            }
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            IDProductoSeleccionado = Convert.ToInt32(fila.Cells["id_producto"].Value);

            txtNombreProducto.Text = fila.Cells["nombre"].Value.ToString();
            txtStockProducto.Text = fila.Cells["stock"].Value.ToString();

            btnAgregarProducto.Text = "Modificar";
        }
        private void FormProducto_Load(object sender, EventArgs e)
        {
            lblUsername.Text = _usuario.username;
            lblRol.Text = _usuario.nombre_rol;
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}