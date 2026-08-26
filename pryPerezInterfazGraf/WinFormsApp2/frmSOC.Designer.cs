namespace pryPerezInterfazGraf
{
    partial class frmSOC
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
            lblCritico = new Label();
            lblAlta = new Label();
            lblMedia = new Label();
            lblBaja = new Label();
            lblResultadoBaja = new Label();
            lblResultadoMedia = new Label();
            lblResultadoAlta = new Label();
            lblResultadoCritico = new Label();
            SuspendLayout();
            // 
            // lblCritico
            // 
            lblCritico.AutoSize = true;
            lblCritico.Location = new Point(26, 39);
            lblCritico.Name = "lblCritico";
            lblCritico.Size = new Size(42, 15);
            lblCritico.TabIndex = 0;
            lblCritico.Text = "Critico";
            lblCritico.Click += lblCritico_Click;
            // 
            // lblAlta
            // 
            lblAlta.AutoSize = true;
            lblAlta.Location = new Point(26, 65);
            lblAlta.Name = "lblAlta";
            lblAlta.Size = new Size(28, 15);
            lblAlta.TabIndex = 1;
            lblAlta.Text = "Alta";
            lblAlta.Click += lblAlta_Click;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(26, 92);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(40, 15);
            lblMedia.TabIndex = 2;
            lblMedia.Text = "Media";
            lblMedia.Click += lblMedia_Click_1;
            // 
            // lblBaja
            // 
            lblBaja.AutoSize = true;
            lblBaja.Location = new Point(26, 121);
            lblBaja.Name = "lblBaja";
            lblBaja.Size = new Size(29, 15);
            lblBaja.TabIndex = 3;
            lblBaja.Text = "Baja";
            lblBaja.Click += lblBaja_Click_1;
            // 
            // lblResultadoBaja
            // 
            lblResultadoBaja.AutoSize = true;
            lblResultadoBaja.Location = new Point(98, 121);
            lblResultadoBaja.Name = "lblResultadoBaja";
            lblResultadoBaja.Size = new Size(12, 15);
            lblResultadoBaja.TabIndex = 7;
            lblResultadoBaja.Text = "-";
            // 
            // lblResultadoMedia
            // 
            lblResultadoMedia.AutoSize = true;
            lblResultadoMedia.Location = new Point(98, 92);
            lblResultadoMedia.Name = "lblResultadoMedia";
            lblResultadoMedia.Size = new Size(12, 15);
            lblResultadoMedia.TabIndex = 6;
            lblResultadoMedia.Text = "-";
            // 
            // lblResultadoAlta
            // 
            lblResultadoAlta.AutoSize = true;
            lblResultadoAlta.Location = new Point(98, 65);
            lblResultadoAlta.Name = "lblResultadoAlta";
            lblResultadoAlta.Size = new Size(12, 15);
            lblResultadoAlta.TabIndex = 5;
            lblResultadoAlta.Text = "-";
            // 
            // lblResultadoCritico
            // 
            lblResultadoCritico.AutoSize = true;
            lblResultadoCritico.Location = new Point(98, 39);
            lblResultadoCritico.Name = "lblResultadoCritico";
            lblResultadoCritico.Size = new Size(12, 15);
            lblResultadoCritico.TabIndex = 4;
            lblResultadoCritico.Text = "-";
            // 
            // frmSOC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 207);
            Controls.Add(lblResultadoBaja);
            Controls.Add(lblResultadoMedia);
            Controls.Add(lblResultadoAlta);
            Controls.Add(lblResultadoCritico);
            Controls.Add(lblBaja);
            Controls.Add(lblMedia);
            Controls.Add(lblAlta);
            Controls.Add(lblCritico);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSOC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSOC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCritico;
        private Label lblAlta;
        private Label lblMedia;
        private Label lblBaja;
        private Label lblResultadoBaja;
        private Label lblResultadoMedia;
        private Label lblResultadoAlta;
        private Label lblResultadoCritico;
    }
}