namespace EjercicioGama1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPagoHora = new TextBox();
            textBoxHoraTrabajada = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBoxHorasExtra = new CheckBox();
            groupBoxResultados = new GroupBox();
            labelSueldo = new Label();
            labelTotalGeneral = new Label();
            labelHorasExtras = new Label();
            button1Calc = new Button();
            buttonLimpiar = new Button();
            textBoxHoraXtras = new TextBox();
            buttonExit = new Button();
            groupBoxResultados.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPagoHora
            // 
            textBoxPagoHora.Location = new Point(12, 43);
            textBoxPagoHora.Name = "textBoxPagoHora";
            textBoxPagoHora.Size = new Size(150, 31);
            textBoxPagoHora.TabIndex = 0;
            // 
            // textBoxHoraTrabajada
            // 
            textBoxHoraTrabajada.Location = new Point(180, 43);
            textBoxHoraTrabajada.Name = "textBoxHoraTrabajada";
            textBoxHoraTrabajada.Size = new Size(150, 31);
            textBoxHoraTrabajada.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 2;
            label1.Text = "Pago por hora:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 9);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 3;
            label2.Text = "Horas trabajadas:";
            // 
            // checkBoxHorasExtra
            // 
            checkBoxHorasExtra.AutoSize = true;
            checkBoxHorasExtra.Location = new Point(12, 91);
            checkBoxHorasExtra.Name = "checkBoxHorasExtra";
            checkBoxHorasExtra.Size = new Size(203, 29);
            checkBoxHorasExtra.TabIndex = 4;
            checkBoxHorasExtra.Text = "Trabajo horas extras?";
            checkBoxHorasExtra.UseVisualStyleBackColor = true;
            checkBoxHorasExtra.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBoxResultados
            // 
            groupBoxResultados.Controls.Add(labelSueldo);
            groupBoxResultados.Controls.Add(labelTotalGeneral);
            groupBoxResultados.Controls.Add(labelHorasExtras);
            groupBoxResultados.Location = new Point(488, 12);
            groupBoxResultados.Name = "groupBoxResultados";
            groupBoxResultados.Size = new Size(300, 148);
            groupBoxResultados.TabIndex = 5;
            groupBoxResultados.TabStop = false;
            groupBoxResultados.Text = "Resultados:";
            groupBoxResultados.Visible = false;
            // 
            // labelSueldo
            // 
            labelSueldo.AutoSize = true;
            labelSueldo.Location = new Point(6, 31);
            labelSueldo.Name = "labelSueldo";
            labelSueldo.Size = new Size(0, 25);
            labelSueldo.TabIndex = 2;
            // 
            // labelTotalGeneral
            // 
            labelTotalGeneral.AutoSize = true;
            labelTotalGeneral.Location = new Point(6, 56);
            labelTotalGeneral.Name = "labelTotalGeneral";
            labelTotalGeneral.Size = new Size(0, 25);
            labelTotalGeneral.TabIndex = 1;
            // 
            // labelHorasExtras
            // 
            labelHorasExtras.AutoSize = true;
            labelHorasExtras.Location = new Point(6, 83);
            labelHorasExtras.Name = "labelHorasExtras";
            labelHorasExtras.Size = new Size(0, 25);
            labelHorasExtras.TabIndex = 0;
            // 
            // button1Calc
            // 
            button1Calc.Location = new Point(676, 184);
            button1Calc.Name = "button1Calc";
            button1Calc.Size = new Size(112, 34);
            button1Calc.TabIndex = 6;
            button1Calc.Text = "Calcular";
            button1Calc.UseVisualStyleBackColor = true;
            button1Calc.Click += button1Calc_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(326, 184);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(112, 34);
            buttonLimpiar.TabIndex = 7;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // textBoxHoraXtras
            // 
            textBoxHoraXtras.Location = new Point(12, 129);
            textBoxHoraXtras.Name = "textBoxHoraXtras";
            textBoxHoraXtras.PlaceholderText = "Horas extra...";
            textBoxHoraXtras.Size = new Size(150, 31);
            textBoxHoraXtras.TabIndex = 8;
            textBoxHoraXtras.Visible = false;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(12, 184);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(112, 34);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Salir";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(textBoxHoraXtras);
            Controls.Add(buttonLimpiar);
            Controls.Add(button1Calc);
            Controls.Add(groupBoxResultados);
            Controls.Add(checkBoxHorasExtra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxHoraTrabajada);
            Controls.Add(textBoxPagoHora);
            Name = "Form1";
            Text = "Form1";
            groupBoxResultados.ResumeLayout(false);
            groupBoxResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPagoHora;
        private TextBox textBoxHoraTrabajada;
        private Label label1;
        private Label label2;
        private CheckBox checkBoxHorasExtra;
        private GroupBox groupBoxResultados;
        private Label labelTotalGeneral;
        private Label labelHorasExtras;
        private Button button1Calc;
        private Button buttonLimpiar;
        private TextBox textBoxHoraXtras;
        private Button buttonExit;
        private Label labelSueldo;
    }
}
