namespace EjercicioForms3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPagoHoras = new System.Windows.Forms.TextBox();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelBruto = new System.Windows.Forms.Label();
            this.labelAFP = new System.Windows.Forms.Label();
            this.labelSFS = new System.Windows.Forms.Label();
            this.labelTotalDesc = new System.Windows.Forms.Label();
            this.labelNeto = new System.Windows.Forms.Label();
            this.labelOtro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los valores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pago por hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas trabajadas:";
            // 
            // textBoxPagoHoras
            // 
            this.textBoxPagoHoras.Location = new System.Drawing.Point(154, 45);
            this.textBoxPagoHoras.Name = "textBoxPagoHoras";
            this.textBoxPagoHoras.Size = new System.Drawing.Size(100, 26);
            this.textBoxPagoHoras.TabIndex = 3;
            // 
            // textBoxHoras
            // 
            this.textBoxHoras.Location = new System.Drawing.Point(154, 85);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(100, 26);
            this.textBoxHoras.TabIndex = 4;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(17, 404);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(109, 34);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelBruto
            // 
            this.labelBruto.AutoSize = true;
            this.labelBruto.Location = new System.Drawing.Point(13, 135);
            this.labelBruto.Name = "labelBruto";
            this.labelBruto.Size = new System.Drawing.Size(106, 20);
            this.labelBruto.TabIndex = 6;
            this.labelBruto.Text = "Sueldo Bruto:";
            // 
            // labelAFP
            // 
            this.labelAFP.AutoSize = true;
            this.labelAFP.Location = new System.Drawing.Point(13, 168);
            this.labelAFP.Name = "labelAFP";
            this.labelAFP.Size = new System.Drawing.Size(130, 20);
            this.labelAFP.TabIndex = 7;
            this.labelAFP.Text = "Descuento AFP: ";
            // 
            // labelSFS
            // 
            this.labelSFS.AutoSize = true;
            this.labelSFS.Location = new System.Drawing.Point(13, 203);
            this.labelSFS.Name = "labelSFS";
            this.labelSFS.Size = new System.Drawing.Size(131, 20);
            this.labelSFS.TabIndex = 8;
            this.labelSFS.Text = "Descuento SFS: ";
            // 
            // labelTotalDesc
            // 
            this.labelTotalDesc.AutoSize = true;
            this.labelTotalDesc.Location = new System.Drawing.Point(13, 237);
            this.labelTotalDesc.Name = "labelTotalDesc";
            this.labelTotalDesc.Size = new System.Drawing.Size(130, 20);
            this.labelTotalDesc.TabIndex = 9;
            this.labelTotalDesc.Text = "Descuento total: ";
            // 
            // labelNeto
            // 
            this.labelNeto.AutoSize = true;
            this.labelNeto.Location = new System.Drawing.Point(12, 271);
            this.labelNeto.Name = "labelNeto";
            this.labelNeto.Size = new System.Drawing.Size(105, 20);
            this.labelNeto.TabIndex = 10;
            this.labelNeto.Text = "Sueldo Neto: ";
            // 
            // labelOtro
            // 
            this.labelOtro.AutoSize = true;
            this.labelOtro.Location = new System.Drawing.Point(12, 302);
            this.labelOtro.Name = "labelOtro";
            this.labelOtro.Size = new System.Drawing.Size(52, 20);
            this.labelOtro.TabIndex = 11;
            this.labelOtro.Text = "Otros:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOtro);
            this.Controls.Add(this.labelNeto);
            this.Controls.Add(this.labelTotalDesc);
            this.Controls.Add(this.labelSFS);
            this.Controls.Add(this.labelAFP);
            this.Controls.Add(this.labelBruto);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxHoras);
            this.Controls.Add(this.textBoxPagoHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPagoHoras;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelBruto;
        private System.Windows.Forms.Label labelAFP;
        private System.Windows.Forms.Label labelSFS;
        private System.Windows.Forms.Label labelTotalDesc;
        private System.Windows.Forms.Label labelNeto;
        private System.Windows.Forms.Label labelOtro;
    }
}

