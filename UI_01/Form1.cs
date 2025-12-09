using Microsoft.VisualBasic;

namespace EjercicioGama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHorasExtra.Checked == true)
            {
                textBoxHoraXtras.Visible = true;
            }
            else
            {
                textBoxHoraXtras.Visible = false;
            }
        }

        private void button1Calc_Click(object sender, EventArgs e)
        {
            groupBoxResultados.Show();

            double PagoHora = double.Parse(textBoxPagoHora.Text);
            double HorasTrabajadas = double.Parse(textBoxHoraTrabajada.Text);

            double sueldo = PagoHora * HorasTrabajadas;

            double HorasXtra = 0;
            double THorasXtra = 0;

            if (checkBoxHorasExtra.Checked)
            {
                HorasXtra = double.Parse(textBoxHoraXtras.Text);

                // 1.35 es sobre el pago por hora, no sobre el sueldo.
                THorasXtra = (PagoHora * 1.35) * HorasXtra;

                labelHorasExtras.Text = $"Horas Extra: {THorasXtra}";
            }
            else
            {
                labelHorasExtras.Text = $"Horas Extra: 0";
            }

            // Total general debe calcularse despues de obtener THorasXtra
            double TotalGeneral = sueldo + THorasXtra;

            labelSueldo.Text = $"Sueldo: {sueldo}";
            labelTotalGeneral.Text = $"Total General: {TotalGeneral}";
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxHoraTrabajada.Text = "";
            textBoxHoraXtras.Text = "";
            textBoxPagoHora.Text = "";
        }
    }
}
