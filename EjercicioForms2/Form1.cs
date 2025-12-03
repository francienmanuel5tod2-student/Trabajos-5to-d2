using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            double C1 = double.Parse(textBoxC1.Text);
            double C2 = double.Parse(textBoxC2.Text);
            double C3 = double.Parse(textBoxC3.Text);
            double C4 = double.Parse(textBoxC4.Text);
            double promedio = (C1 + C2 + C3 + C4) / 4;

            labelPromedio.Text = $"El promedio es: {promedio}";
        }
    }
}
