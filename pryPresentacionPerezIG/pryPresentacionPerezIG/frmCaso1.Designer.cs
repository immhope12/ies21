namespace pryPresentacionPerezIG
{
    partial class frmCaso1
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
            btnPresentar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblCarrera = new Label();
            txtCarrera = new TextBox();
            SuspendLayout();
            // 
            // btnPresentar
            // 
            btnPresentar.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPresentar.Location = new Point(32, 193);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(229, 44);
            btnPresentar.TabIndex = 0;
            btnPresentar.Text = "Presentar";
            btnPresentar.UseVisualStyleBackColor = true;
            btnPresentar.Click += btnPresentar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 10);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 64);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            lblApellido.Click += lblApellido_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(128, 56);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(133, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 107);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 7;
            lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(128, 99);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(34, 23);
            txtEdad.TabIndex = 6;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(12, 152);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 9;
            lblCarrera.Text = "Carrera";
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(128, 144);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(133, 23);
            txtCarrera.TabIndex = 8;
            // 
            // frmCaso1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 306);
            Controls.Add(lblCarrera);
            Controls.Add(txtCarrera);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnPresentar);
            Name = "frmCaso1";
            Text = "Mi Presentacion";
            Load += frmCaso1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPresentar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblCarrera;
        private TextBox txtCarrera;
    }
}