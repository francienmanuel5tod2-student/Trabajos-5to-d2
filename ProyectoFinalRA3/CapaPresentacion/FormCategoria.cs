using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;
using ClassLibrary1;

namespace CapaPresentacion
{
    public partial class FormCategoria : Form
    {
        private UsuarioDTO _usuario;
        int IdSeleccion = 0; 
        CategoriaDAL dal = new CategoriaDAL();

        public FormCategoria(UsuarioDTO usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            CargarCategorias();
            dgvCategorias.Columns["Estado"].Visible = false;
            dgvCategorias.Columns["ID_categoria"].Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Categorias";
        }

        // Carga las categorías en el DataGridView
        private void CargarCategorias()
        {
            dgvCategorias.DataSource = dal.Listar();
        }

        // Limpia el formulario
        private void LimpiarFormulario()
        {
            txtNombreCategoria.Clear();
            IdSeleccion = 0;
            btnAgregar.Text = "Agregar";
            dgvCategorias.ClearSelection();
        }

        // AGREGAR o MODIFICAR categoría
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre de categoría");
                txtNombreCategoria.Focus();
                return;
            }

            if (IdSeleccion == 0)
            {
                // Agregar
                dal.Insertar(new CategoriaDTO
                {
                    nombre = txtNombreCategoria.Text.Trim()
                });

                MessageBox.Show("Categoría agregada correctamente");
            }
            else
            {
                // Modificar
                dal.Actualizar(new CategoriaDTO
                {
                    id_categoria = IdSeleccion,
                    nombre = txtNombreCategoria.Text.Trim()
                });

                MessageBox.Show("Categoría actualizada correctamente");
            }

            LimpiarFormulario();
            CargarCategorias();
        }

        // ELIMINAR categoría
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
                dal.Eliminar(id);

                MessageBox.Show("Categoría eliminada correctamente");
                CargarCategorias();
                LimpiarFormulario();
            }
        }

        // Cuando se selecciona una fila del DataGridView
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

            IdSeleccion = Convert.ToInt32(fila.Cells["ID_categoria"].Value);
            txtNombreCategoria.Text = fila.Cells["Nombre"].Value.ToString(); // usa el nombre exacto de tu columna
            btnAgregar.Text = "Actualizar";
        }

        // Deseleccionar fila y limpiar formulario
        private void btnDesceleccionar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
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