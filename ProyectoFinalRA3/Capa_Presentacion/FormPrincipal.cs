using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using ClassLibrary1;

namespace CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        private UsuarioDTO _usuario;
        public FormPrincipal(UsuarioDTO usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Principio";
        }
        private void AplicarPermisos()
        {
            string rol = _usuario.nombre_rol;
            if (rol == "Almacen")
            {
                btnMovimiento.Enabled = true;
                btnProducto.Enabled = false;

                btnCategoria.Enabled = false;
            } else if
            (rol == "Consulta")
            {
                btnMovimiento.Enabled = false;
                btnCategoria.Enabled = false;
                btnProducto.Enabled = false;

               btnConsulta.Enabled = true;
            }
        }
        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormMovimiento frm = new FormMovimiento(_usuario);
            frm.ShowDialog();

            this.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormCategoria frm = new FormCategoria(_usuario);
            frm.ShowDialog();

            this.Show();
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormProducto frm = new FormProducto(_usuario);
            frm.ShowDialog();

            this.Show();
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormConsulta frm = new FormConsulta(_usuario);
            frm.ShowDialog();

            this.Show();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblUsername.Text = _usuario.username;
            lblRol.Text = _usuario.nombre_rol;
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            AplicarPermisos();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }        
    }
}
