namespace prySp2EjercicioResolverLencina
{
    partial class frmPrincipal
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
            dtpFecha = new DateTimePicker();
            cboTipoBoleto = new ComboBox();
            gbDistancia = new GroupBox();
            rbCorta = new RadioButton();
            rbLarga = new RadioButton();
            btnRegistrar = new Button();
            lblFecha = new Label();
            lblCodigo = new Label();
            lblTipoBoleta = new Label();
            txtCodigo = new MaskedTextBox();
            gbDistancia.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(106, 24);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(133, 23);
            dtpFecha.TabIndex = 0;
            // 
            // cboTipoBoleto
            // 
            cboTipoBoleto.FormattingEnabled = true;
            cboTipoBoleto.Location = new Point(106, 112);
            cboTipoBoleto.Name = "cboTipoBoleto";
            cboTipoBoleto.Size = new Size(133, 23);
            cboTipoBoleto.TabIndex = 1;
            cboTipoBoleto.SelectedIndexChanged += cboTipoBoleta_SelectedIndexChanged;
            // 
            // gbDistancia
            // 
            gbDistancia.Controls.Add(rbCorta);
            gbDistancia.Controls.Add(rbLarga);
            gbDistancia.Location = new Point(27, 174);
            gbDistancia.Name = "gbDistancia";
            gbDistancia.Size = new Size(216, 110);
            gbDistancia.TabIndex = 2;
            gbDistancia.TabStop = false;
            gbDistancia.Text = "Distancia";
            // 
            // rbCorta
            // 
            rbCorta.AutoSize = true;
            rbCorta.Location = new Point(28, 35);
            rbCorta.Name = "rbCorta";
            rbCorta.Size = new Size(54, 19);
            rbCorta.TabIndex = 4;
            rbCorta.TabStop = true;
            rbCorta.Text = "Corta";
            rbCorta.UseVisualStyleBackColor = true;
            // 
            // rbLarga
            // 
            rbLarga.AutoSize = true;
            rbLarga.Location = new Point(28, 69);
            rbLarga.Name = "rbLarga";
            rbLarga.Size = new Size(54, 19);
            rbLarga.TabIndex = 3;
            rbLarga.TabStop = true;
            rbLarga.Text = "Larga";
            rbLarga.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(168, 301);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(27, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            lblFecha.Click += label1_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(27, 72);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 7;
            lblCodigo.Text = "Codigo";
            // 
            // lblTipoBoleta
            // 
            lblTipoBoleta.AutoSize = true;
            lblTipoBoleta.Location = new Point(27, 115);
            lblTipoBoleta.Name = "lblTipoBoleta";
            lblTipoBoleta.Size = new Size(34, 15);
            lblTipoBoleta.TabIndex = 8;
            lblTipoBoleta.Text = "Tipo ";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(106, 69);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(133, 23);
            txtCodigo.TabIndex = 9;
            txtCodigo.MaskInputRejected += txtCodigo_MaskInputRejected;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 349);
            Controls.Add(txtCodigo);
            Controls.Add(lblTipoBoleta);
            Controls.Add(lblCodigo);
            Controls.Add(lblFecha);
            Controls.Add(btnRegistrar);
            Controls.Add(gbDistancia);
            Controls.Add(cboTipoBoleto);
            Controls.Add(dtpFecha);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta Boleteria";
            Load += frmPrincipal_Load;
            gbDistancia.ResumeLayout(false);
            gbDistancia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private ComboBox cboTipoBoleto;
        private GroupBox gbDistancia;
        private RadioButton rbCorta;
        private RadioButton rbLarga;
        private Button btnRegistrar;
        private Label lblFecha;
        private Label lblCodigo;
        private Label lblTipoBoleta;
        private MaskedTextBox txtCodigo;
    }
}
