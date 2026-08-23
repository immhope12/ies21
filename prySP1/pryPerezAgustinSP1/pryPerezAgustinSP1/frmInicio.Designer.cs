namespace pryPerezAgustinSP1
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            btnInicio = new Button();
            lblBienvenida = new Label();
            iconSinteplast = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconSinteplast).BeginInit();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(259, 196);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(75, 23);
            btnInicio.TabIndex = 3;
            btnInicio.Text = "&Aceptar";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += lblBienvenida_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(0, 51, 102);
            lblBienvenida.Location = new Point(121, 131);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(354, 49);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Bienvenido al Sistema";
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // iconSinteplast
            // 
            iconSinteplast.BackgroundImageLayout = ImageLayout.Center;
            iconSinteplast.BorderStyle = BorderStyle.FixedSingle;
            iconSinteplast.Image = (Image)resources.GetObject("iconSinteplast.Image");
            iconSinteplast.Location = new Point(148, 12);
            iconSinteplast.Name = "iconSinteplast";
            iconSinteplast.Size = new Size(293, 116);
            iconSinteplast.SizeMode = PictureBoxSizeMode.StretchImage;
            iconSinteplast.TabIndex = 4;
            iconSinteplast.TabStop = false;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 245);
            Controls.Add(iconSinteplast);
            Controls.Add(btnInicio);
            Controls.Add(lblBienvenida);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)iconSinteplast).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInicio;
        private Label lblBienvenida;
        private PictureBox iconSinteplast;
    }
}