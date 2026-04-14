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
using CapaNegocios;
using ClassLibrary1;
using Microsoft.Data.SqlClient;


namespace CapaPresentacion
{
    public partial class InicioDeSesion : Form
    {
        int intentos = 0;
        public InicioDeSesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            try
            {
                UsuarioBL bl = new UsuarioBL();

                UsuarioDTO usuario = bl.Login(txtUsuario.Text, txtPassword.Text);

                if (usuario != null)
                {
                    intentos = 0;

                    txtPassword.Text = "";
                    txtUsuario.Text = "";

                    MessageBox.Show("Bienvenido " + usuario.nombre);

                    this.Hide();

                    FormPrincipal frm = new FormPrincipal(usuario);
                    frm.ShowDialog();

                    this.Show();
                }
                else
                {
                    intentos++;

                    txtPassword.Text = "";
                    txtUsuario.Text = "";

                    MessageBox.Show("Usuario o contraseña incorrectos");

                    if (intentos >= 3)
                    {
                        MessageBox.Show("Demasiados intentos fallidos. El sistema se cerrará.");

                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
