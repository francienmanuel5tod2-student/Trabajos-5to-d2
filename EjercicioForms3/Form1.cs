using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioForms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double pagoHora = double.Parse(textBoxPagoHoras.Text);
            double horas = double.Parse(textBoxHoras.Text);

            double sueldoBruto = pagoHora * horas;
            double afp = sueldoBruto * 0.0287;
            double sfs = sueldoBruto * 0.0304;
            double descuentoOtro = 700;
            double totalDescuento = afp + sfs + descuentoOtro;
            double sueldoNeto = sueldoBruto - totalDescuento;

            labelBruto.Text = $"Sueldo Bruto: {sueldoBruto.ToString("N2")}";
            labelAFP.Text = $"Descuento AFP: {afp.ToString("N2")}";
            labelSFS.Text = $"Descuento SFS: {sfs.ToString("N2")}";
            labelTotalDesc.Text = $"Descuento total: {totalDescuento.ToString("N2")}";
            labelNeto.Text = $"Sueldo Neto: {sueldoNeto.ToString("N2")}";
            labelOtro.Text = $"Otros: {descuentoOtro.ToString("N2")}";
        }
    }
}
