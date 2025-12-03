using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBoxNum1.Text);
            double n2 = double.Parse(textBoxNum2.Text);

            double suma = n1 + n2;
            double resta = n1 - n2;
            double multiplicacion = n1 * n2;
            double division = n1 / n2;

            label1.Text = $"Suma: {suma}";
            label2.Text = $"Resta: {resta}";
            label3.Text = $"Multiplicación: {multiplicacion}";
            label4.Text = $"División: {division:f2}";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
