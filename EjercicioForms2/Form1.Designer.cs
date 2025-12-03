namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.textBoxC3 = new System.Windows.Forms.TextBox();
            this.textBoxC4 = new System.Windows.Forms.TextBox();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxC1
            // 
            this.textBoxC1.Location = new System.Drawing.Point(120, 3);
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(100, 26);
            this.textBoxC1.TabIndex = 0;
            // 
            // textBoxC2
            // 
            this.textBoxC2.Location = new System.Drawing.Point(120, 53);
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(100, 26);
            this.textBoxC2.TabIndex = 1;
            // 
            // textBoxC3
            // 
            this.textBoxC3.Location = new System.Drawing.Point(120, 96);
            this.textBoxC3.Name = "textBoxC3";
            this.textBoxC3.Size = new System.Drawing.Size(100, 26);
            this.textBoxC3.TabIndex = 2;
            // 
            // textBoxC4
            // 
            this.textBoxC4.Location = new System.Drawing.Point(120, 138);
            this.textBoxC4.Name = "textBoxC4";
            this.textBoxC4.Size = new System.Drawing.Size(100, 26);
            this.textBoxC4.TabIndex = 3;
            // 
            // LabelResultado
            // 
            this.LabelResultado.AutoSize = true;
            this.LabelResultado.Location = new System.Drawing.Point(366, 130);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(0, 20);
            this.LabelResultado.TabIndex = 4;
            // 
            // buttonResultado
            // 
            this.buttonResultado.Location = new System.Drawing.Point(12, 187);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(167, 34);
            this.buttonResultado.TabIndex = 5;
            this.buttonResultado.Text = "Resultado";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calificación1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calificación2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calificación3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calificación4:";
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Location = new System.Drawing.Point(12, 241);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(122, 20);
            this.labelPromedio.TabIndex = 10;
            this.labelPromedio.Text = "El promedio es: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.textBoxC4);
            this.Controls.Add(this.textBoxC3);
            this.Controls.Add(this.textBoxC2);
            this.Controls.Add(this.textBoxC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.TextBox textBoxC3;
        private System.Windows.Forms.TextBox textBoxC4;
        private System.Windows.Forms.Label LabelResultado;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPromedio;
    }
}

