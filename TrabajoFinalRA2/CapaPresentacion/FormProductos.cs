using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FormProductos : Form
    {
        int IDProductoSeleccionado = 0;
        public FormProductos()
        {
            InitializeComponent();
            CargarCategoriasCombo();
            CargarCategoriasProducto();
            CargarProductos();

            dgvProductos.Columns["ID_categoria"].Visible = false;
            dgvProductos.Columns["Estado"].Visible = false;
            dgvProductos.Columns["ID_producto"].Visible = false;
            dgvProductos.Columns["ObjCategoria"].Visible = false;
            btnAgregarProducto.Text = "Agregar";
            dgvProductos.ClearSelection();
        }
        public void Limpiar()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtStockProducto.Clear();

            cbCategoriaProducto.SelectedIndex = -1;
            dgvProductos.ClearSelection();
  
            dgvProductos.CurrentCell = null;

            IDProductoSeleccionado = 0; 
            btnAgregarProducto.Text = "Agregar"; 
        }

        private void CargarProductos()
        {
            Producto_DAL dal = new Producto_DAL();
            dgvProductos.DataSource = dal.Listar();

            dgvProductos.Columns["ID_categoria"].Visible = false;
            dgvProductos.Columns["Estado"].Visible = false;
            dgvProductos.Columns["ID_producto"].Visible = false;
            dgvProductos.Columns["ObjCategoria"].Visible = false;

            dgvProductos.Columns["NombreCategoria"].HeaderText = "Categoría";
            dgvProductos.Columns["NombreCategoria"].DisplayIndex = 1; 

            dgvProductos.ClearSelection();
            IDProductoSeleccionado = 0;
            btnAgregarProducto.Text = "Agregar";
        }
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            FormCategoria frm = new FormCategoria();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }

        private void btnComprobarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();
                    MessageBox.Show("Conectado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnCambiar_Click_1(object sender, EventArgs e)
        {
            FormCategoria frm = new FormCategoria();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }

        private void CargarCategoriasCombo()
        {
            CategoriaDAL dal = new CategoriaDAL();
            cmbFiltrarCategorias.DataSource = null;
            cmbFiltrarCategorias.DataSource = dal.Listar();
            cmbFiltrarCategorias.DisplayMember = "Nombre_categoria";
            cmbFiltrarCategorias.ValueMember = "ID_categoria";
        }

        private void cmbFiltrarCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarCategorias.SelectedValue == null)
                return;

            if (cmbFiltrarCategorias.SelectedValue is int idCategoria)
            {
                Producto_DAL dal = new Producto_DAL();
                dgvProductos.DataSource = dal.ListarPorCategoria(idCategoria);
            }
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioProducto.Text) ||
                string.IsNullOrWhiteSpace(txtStockProducto.Text) ||
                cbCategoriaProducto.SelectedValue == null)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio))
            {
                MessageBox.Show("Precio inválido");
                return;
            }

            if (!int.TryParse(txtStockProducto.Text, out int stock))
            {
                MessageBox.Show("Stock inválido");
                return;
            }

            Producto p = new Producto
            {
                ID_producto = IDProductoSeleccionado,
                Nombre_producto = txtNombreProducto.Text.Trim(),
                Precio_producto = precio,
                Stock = stock,
                ID_categoria = Convert.ToInt32(cbCategoriaProducto.SelectedValue)
            };

            Producto_DAL dal = new Producto_DAL();

            if (IDProductoSeleccionado == 0)
            {
                dal.Insertar(p);
                MessageBox.Show("Producto agregado correctamente");
            }

            else
            {
                DialogResult r = MessageBox.Show(
                    "¿Desea actualizar el producto seleccionado?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (r == DialogResult.Yes)
                {
                    dal.Actualizar(p);
                    MessageBox.Show("Producto actualizado correctamente");
                }
            }

            Limpiar();
            CargarProductos();
        }


        private void CargarCategoriasProducto()
        {
            CategoriaDAL dal = new CategoriaDAL();
            var lista = dal.Listar();

            cbCategoriaProducto.DataSource = null;
            cbCategoriaProducto.DataSource = lista;
            cbCategoriaProducto.DisplayMember = "Nombre_categoria";
            cbCategoriaProducto.ValueMember = "ID_categoria";
            cbCategoriaProducto.SelectedIndex = -1;
        } 
        private void cbCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoriaProducto.SelectedValue == null)
                return;
            if (cbCategoriaProducto.SelectedValue is DataRowView)
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            int idProducto = Convert.ToInt32(
                dgvProductos.CurrentRow.Cells["ID_producto"].Value
            );

            DialogResult r = MessageBox.Show(
                "¿Seguro que desea eliminar este producto?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r == DialogResult.No) return;

            Producto_DAL dal = new Producto_DAL();
            dal.Eliminar(idProducto);

            CargarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            IDProductoSeleccionado = Convert.ToInt32(fila.Cells["ID_producto"].Value);

            txtNombreProducto.Text = fila.Cells["Nombre_producto"].Value.ToString();
            txtPrecioProducto.Text = fila.Cells["Precio_producto"].Value.ToString();
            txtStockProducto.Text = fila.Cells["Stock"].Value.ToString();
            cbCategoriaProducto.SelectedValue = fila.Cells["ID_categoria"].Value;

            btnAgregarProducto.Text = "Actualizar";
        
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormVentas frm = new FormVentas();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }

    }


}

