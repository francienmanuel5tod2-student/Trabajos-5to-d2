using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        Double Promedio;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            buttonEnviar.Enabled = false;
            int N1 = int.Parse(textBoxN1.Text);
            int N2 = int.Parse(textBoxN2.Text);
            int N3 = int.Parse(textBoxN3.Text);
            int N4 = int.Parse(textBoxN4.Text);

            Promedio = ((double)N1 + N2 + N3 + N4) / 4;

            labelN.Text = $"Promedio: {Promedio.ToString():F2}";

            if (Promedio > 69)
            {
                labelEstado.Text = "Aprobado";
                labelN.Visible = true;
            }
            else
            {
                groupBox2.Visible = true;
                labelN.Visible = true;
            }
        }

        private void buttonEnviar2_Click(object sender, EventArgs e)
        {
            buttonEnviar2.Enabled = false;
            double Completivo = double.Parse(textBoxCompletivo.Text);
            double NotaC = (Completivo * 0.5) + (Promedio * 0.5);

            labelNC.Text = $"Nota Completivo: {NotaC.ToString():F2}";
            if (NotaC > 69)
            {
                labelEstado.Text = "Aprobado";
                labelNC.Visible = true;
            }
            else
            {
                groupBox4.Visible = true;
                labelNC.Visible = true;

            }
        }
    
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxN1.Text = "";
            textBoxN2.Text = "";
            textBoxN3.Text = "";
            textBoxN4.Text = "";
            textBoxCompletivo.Text = "";
            textBoxExtra.Text = "";

            labelN.Text ="Promedio:";
            labelNC.Text = "Nota Completivo:";
            labelNE.Text = "Nota Extraodinario:";
            labelEstado.Text = "";

            groupBox4.Visible = false;
            groupBox2.Visible = false;
            labelN.Visible = false;
            labelNC.Visible = false;
            labelNE.Visible = false;
            buttonEnviar.Enabled = true;
            buttonEnviar2.Enabled =true;
            buttonEnviar3.Enabled = true;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnviar3_Click(object sender, EventArgs e)
        {
            buttonEnviar3.Enabled = false;
            double Extraodinario = double.Parse(textBoxExtra.Text);
            double NotaExtra = (Extraodinario * 0.7) + (Promedio * 0.3);

            labelNE.Text = $"Nota Extraodinario: {NotaExtra.ToString():F2}";
            if (Extraodinario > 69)
            {
                labelEstado.Text = "Aprobado";
                labelNE.Visible = true;
            }
            else
            {
                labelEstado.Text = "Reprobado";
                labelNE.Visible = true;
            }
        }
    }
}
