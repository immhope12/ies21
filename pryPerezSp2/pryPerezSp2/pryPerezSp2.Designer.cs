namespace pryPerezSp2
{
    partial class frmGestionBoleto
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
            gb_ticket = new GroupBox();
            ntxt_estancia = new NumericUpDown();
            ntxt_distancia = new NumericUpDown();
            lbl_distancia = new Label();
            lbl_estancia = new Label();
            btn_aceptar = new Button();
            gb_ticket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ntxt_estancia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ntxt_distancia).BeginInit();
            SuspendLayout();
            // 
            // gb_ticket
            // 
            gb_ticket.Controls.Add(ntxt_estancia);
            gb_ticket.Controls.Add(ntxt_distancia);
            gb_ticket.Controls.Add(lbl_distancia);
            gb_ticket.Controls.Add(lbl_estancia);
            gb_ticket.Location = new Point(16, 19);
            gb_ticket.Name = "gb_ticket";
            gb_ticket.Size = new Size(215, 74);
            gb_ticket.TabIndex = 7;
            gb_ticket.TabStop = false;
            gb_ticket.Text = "Boleto";
            // 
            // ntxt_estancia
            // 
            ntxt_estancia.Location = new Point(98, 42);
            ntxt_estancia.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            ntxt_estancia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ntxt_estancia.Name = "ntxt_estancia";
            ntxt_estancia.Size = new Size(111, 23);
            ntxt_estancia.TabIndex = 7;
            ntxt_estancia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ntxt_distancia
            // 
            ntxt_distancia.Location = new Point(98, 17);
            ntxt_distancia.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            ntxt_distancia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ntxt_distancia.Name = "ntxt_distancia";
            ntxt_distancia.Size = new Size(111, 23);
            ntxt_distancia.TabIndex = 6;
            ntxt_distancia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_distancia
            // 
            lbl_distancia.AutoSize = true;
            lbl_distancia.Location = new Point(6, 19);
            lbl_distancia.Name = "lbl_distancia";
            lbl_distancia.Size = new Size(55, 15);
            lbl_distancia.TabIndex = 0;
            lbl_distancia.Text = "Distancia";
            // 
            // lbl_estancia
            // 
            lbl_estancia.AutoSize = true;
            lbl_estancia.Location = new Point(6, 44);
            lbl_estancia.Name = "lbl_estancia";
            lbl_estancia.Size = new Size(91, 15);
            lbl_estancia.TabIndex = 1;
            lbl_estancia.Text = "Días de estancia";
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(114, 99);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(117, 30);
            btn_aceptar.TabIndex = 6;
            btn_aceptar.Text = "&Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // frmGestionBoleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 141);
            Controls.Add(gb_ticket);
            Controls.Add(btn_aceptar);
            Name = "frmGestionBoleto";
            Text = "Venta de Boletos";
            Load += pryPerezSp2_Load;
            gb_ticket.ResumeLayout(false);
            gb_ticket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ntxt_estancia).EndInit();
            ((System.ComponentModel.ISupportInitialize)ntxt_distancia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_distancia;
        private Label lbl_estancia;
        private Button btn_aceptar;
        private GroupBox gb_ticket;
        private NumericUpDown ntxt_estancia;
        private NumericUpDown ntxt_distancia;
    }
}