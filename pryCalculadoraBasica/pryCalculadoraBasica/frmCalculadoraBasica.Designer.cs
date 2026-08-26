namespace pryCalculadoraBasica
{
    partial class frmCalculadoraBasica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNum1 = new TextBox();
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            lblResultado = new Label();
            txtResultado = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(116, 52);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            txtNum1.TextChanged += textBox1_TextChanged;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(27, 55);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(74, 15);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Número 1 = ";
            lblNum1.Click += label1_Click;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(27, 95);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(74, 15);
            lblNum2.TabIndex = 3;
            lblNum2.Text = "Número 2 = ";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(116, 92);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(27, 233);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(70, 15);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado =";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(116, 230);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 8;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(49, 155);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(23, 29);
            btnSuma.TabIndex = 10;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(116, 155);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(23, 29);
            btnResta.TabIndex = 11;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(178, 155);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(23, 29);
            btnMult.TabIndex = 12;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(246, 155);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(23, 29);
            btnDiv.TabIndex = 13;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // frmCalculadoraBasica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 338);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(lblNum2);
            Controls.Add(txtNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtNum1);
            Name = "frmCalculadoraBasica";
            Text = "Calculadora Basica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum2;
        private Label lblResultado;
        private TextBox txtResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMult;
        private Button btnDiv;
        private Label label1;
    }
}