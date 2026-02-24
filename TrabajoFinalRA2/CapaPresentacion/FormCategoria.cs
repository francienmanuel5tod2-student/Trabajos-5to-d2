using System;
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
using CapaPresentacion;
using CapaEntidades;

namespace CapaPresentacion
{
    
    public partial class FormCategoria : Form
    {
        int Idselccion = 0;
        CategoriaDAL dal = new CategoriaDAL();
        public FormCategoria()
        {
            InitializeComponent();
            CargarCategorias();
            dgvCategorias.Columns["Estado"].Visible = false;
            dgvCategorias.Columns["ID_categoria"].Visible = false;
        }
        private void CargarCategorias()
        {
            CategoriaDAL dal = new CategoriaDAL();
            dgvCategorias.DataSource = dal.Listar();
        }


        public void button1_Click(object sender, EventArgs e)
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
        private void LimpiarFormulario()
        {
            txtNombreCategoria.Clear();
            Idselccion = 0;
            btnAgregar.Text = "Agregar";
            dgvCategorias.ClearSelection();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre de categoría");
                txtNombreCategoria.Focus();
                return;
            }

            CategoriaDAL dal = new CategoriaDAL();

            if (Idselccion == 0)
            {
                dal.Insertar(new Categoria
                {
                    Nombre_categoria = txtNombreCategoria.Text.Trim()
                });

                MessageBox.Show("Categoría agregada correctamente");
            }
            else
            {
                dal.Actualizar(new Categoria
                {
                    ID_categoria = Idselccion,
                    Nombre_categoria = txtNombreCategoria.Text.Trim()
                });

                MessageBox.Show("Categoría actualizada correctamente");
            }

            LimpiarFormulario();
            CargarCategorias();
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["ID_categoria"].Value);
                CategoriaDAL dal = new CategoriaDAL();
                dal.Eliminar(id);

                CargarCategorias();
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            FormProductos frm = new FormProductos();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();

        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormVentas frm = new FormVentas();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Hide();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

            Idselccion = Convert.ToInt32(fila.Cells["ID_categoria"].Value);

            txtNombreCategoria.Text = fila.Cells["Nombre_categoria"].Value.ToString();

            btnAgregar.Text = "Actualizar";
        }

        private void btnDesceleccionar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
