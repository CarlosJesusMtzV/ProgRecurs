namespace ProgRecurs
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
            comboBoxProblemas = new ComboBox();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // comboBoxProblemas
            // 
            comboBoxProblemas.FormattingEnabled = true;
            comboBoxProblemas.Items.AddRange(new object[] { "Factorial", "Fibonacci", "Suma" });
            comboBoxProblemas.Location = new Point(50, 56);
            comboBoxProblemas.Name = "comboBoxProblemas";
            comboBoxProblemas.Size = new Size(151, 28);
            comboBoxProblemas.TabIndex = 0;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(50, 146);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(58, 262);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(259, 55);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(151, 67);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(comboBoxProblemas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxProblemas;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnCalcular;
    }
}
