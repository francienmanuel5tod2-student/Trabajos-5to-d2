using Microsoft.VisualBasic;
using System.Diagnostics;

namespace trabajo_en_parejas
{
    public partial class Form1 : Form
    {

        string rutaArchivo = "";

        public Form1()
        {
            InitializeComponent();
        }
        //iniciacion del forms (creacion de las columnas)
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEmpleados.Columns.Add("id", "ID");
            dgvEmpleados.Columns.Add("nombre", "NOMBRE");
            dgvEmpleados.Columns.Add("apellidos", "APELLIDOS");
            dgvEmpleados.Columns.Add("direccion", "DIRECCION");
            dgvEmpleados.Columns.Add("email", "EMAIL");
            dgvEmpleados.Columns.Add("numero", "NUMERO");
            dgvEmpleados.Columns.Add("salario", "Salario");
            dgvEmpleados.Columns.Add("Cargo", "Cargo");
            dgvEmpleados.Columns.Add("genero", "GENERO");
            dgvEmpleados.Columns.Add("fecha", "Fecha INGRESO");

        }

        //click en guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
               // ---------------------- VALIDACIONES ----------------------
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtNumero.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))

            {
                MessageBox.Show(
                    "No deje ningún campo vacío.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (comboBoxCargo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Por favor seleccione un cargo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (comboBoxGenero.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Por favor seleccione un género.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show(
                    "Ingrese un valor válido en ID.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!int.TryParse(txtNumero.Text, out int numero))
            {
                MessageBox.Show(
                    "Ingrese un valor válido en Número.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!int.TryParse(txtSalario.Text, out int salario))
            {
                MessageBox.Show(
                    "Ingrese un valor válido en Salario.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // ---------------------- CONFIRMACIÓN ----------------------
            DialogResult resultado = MessageBox.Show(
                "¿Desea guardar este empleado y generar un archivo TXT?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
                return;

            // ---------------------- SAVE FILE DIALOG ----------------------
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Archivos de texto (*.txt)|*.txt",
                Title = "Guardar archivo",
                DefaultExt = "txt",
                AddExtension = true,
                FileName = "Empleado.txt"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            string rutaArchivo = sfd.FileName;

            // ---------------------- AGREGAR FILA AL DGV ----------------------
            dgvEmpleados.Rows.Add(
                id,
                txtNombre.Text,
                txtApellidos.Text,
                txtDireccion.Text,
                txtEmail.Text,
                numero,
                salario,
                comboBoxCargo.Text,
                comboBoxGenero.Text,
                dateTimePickerFecha.Value.ToShortDateString()
            );

            // ---------------------- GUARDAR ARCHIVO FORMATEADO ----------------------
            int[] anchos = { 4, 10, 11, 12, 22, 12, 12, 14, 12, 14 };

            using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
            {
                // Línea superior
                string linea = "+";
                foreach (int a in anchos)
                    linea += new string('-', a) + "+";
                sw.WriteLine(linea);

                // Encabezados
                string[] titulos = { "ID","NOMBRE","APELLIDOS","DIRECCION","EMAIL",
                             "NUMERO","SALARIO","CARGO","GENERO","FECHA ING." };
                string encabezado = "|";
                for (int i = 0; i < anchos.Length; i++)
                    encabezado += titulos[i].PadRight(anchos[i]) + "|";
                sw.WriteLine(encabezado);
                sw.WriteLine(linea);

                // Filas del DGV
                foreach (DataGridViewRow fila in dgvEmpleados.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string row = "|";
                    for (int i = 0; i < anchos.Length; i++)
                    {
                        string valor = fila.Cells[i].Value?.ToString() ?? "";
                        row += valor.PadRight(anchos[i]) + "|";
                    }
                    sw.WriteLine(row);
                }

                // Línea final
                sw.WriteLine(linea);
            }

            // ---------------------- LIMPIAR CAMPOS ----------------------
            txtId.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtNumero.Clear();
            txtSalario.Clear();

            MessageBox.Show(
                "Archivo guardado y agregado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }



        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto (*.txt)|*.txt";
            ofd.Title = "Seleccione un archivo para abrir";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = ofd.FileName,
                    UseShellExecute = true
                });
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
                "Desea salir de la aplicacion?",
                "salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
    }
}
