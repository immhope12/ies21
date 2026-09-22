namespace pryPerezSp3
{
    partial class frm_gestion_repuestos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gestion_repuestos));
            gb_alta = new GroupBox();
            lbl_descripcion = new Label();
            rtb_descripcion = new RichTextBox();
            lbl_precio = new Label();
            ntxt_precio = new NumericUpDown();
            ntxt_num_repuesto = new NumericUpDown();
            cmb_marca = new ComboBox();
            lbl_marca = new Label();
            lbl_origen = new Label();
            lbl_repuesto = new Label();
            rb_importado = new RadioButton();
            rb_nacional = new RadioButton();
            btn_registrar = new Button();
            btn_salir = new Button();
            gb_consulta = new GroupBox();
            dgv_consulta = new DataGridView();
            col_nro_repuesto = new DataGridViewTextBoxColumn();
            col_precio = new DataGridViewTextBoxColumn();
            col_descripcion = new DataGridViewTextBoxColumn();
            lbl_origen_consulta = new Label();
            lbl_marca_consulta = new Label();
            rb_importado_consulta = new RadioButton();
            rb_nacional_consulta = new RadioButton();
            cmb_marca_consulta = new ComboBox();
            btn_consultar = new Button();
            ep_ac_repuestos = new ErrorProvider(components);
            sp_ac_repuestos = new ErrorProvider(components);
            lbl_exito = new Label();
            lbl_resultado = new Label();
            gb_alta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ntxt_precio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ntxt_num_repuesto).BeginInit();
            gb_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_consulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep_ac_repuestos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sp_ac_repuestos).BeginInit();
            SuspendLayout();
            // 
            // gb_alta
            // 
            gb_alta.Controls.Add(lbl_descripcion);
            gb_alta.Controls.Add(rtb_descripcion);
            gb_alta.Controls.Add(lbl_precio);
            gb_alta.Controls.Add(ntxt_precio);
            gb_alta.Controls.Add(ntxt_num_repuesto);
            gb_alta.Controls.Add(cmb_marca);
            gb_alta.Controls.Add(lbl_marca);
            gb_alta.Controls.Add(lbl_origen);
            gb_alta.Controls.Add(lbl_repuesto);
            gb_alta.Controls.Add(rb_importado);
            gb_alta.Controls.Add(rb_nacional);
            gb_alta.Location = new Point(24, 26);
            gb_alta.Name = "gb_alta";
            gb_alta.Size = new Size(408, 162);
            gb_alta.TabIndex = 0;
            gb_alta.TabStop = false;
            gb_alta.Text = "Alta de repuestos";
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.AutoSize = true;
            lbl_descripcion.Location = new Point(232, 21);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(69, 15);
            lbl_descripcion.TabIndex = 1;
            lbl_descripcion.Text = "Descripción";
            // 
            // rtb_descripcion
            // 
            rtb_descripcion.Location = new Point(232, 39);
            rtb_descripcion.MaxLength = 50;
            rtb_descripcion.Name = "rtb_descripcion";
            rtb_descripcion.Size = new Size(163, 111);
            rtb_descripcion.TabIndex = 7;
            rtb_descripcion.Text = "";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(7, 132);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(40, 15);
            lbl_precio.TabIndex = 9;
            lbl_precio.Text = "Precio";
            // 
            // ntxt_precio
            // 
            ntxt_precio.DecimalPlaces = 2;
            ntxt_precio.Location = new Point(86, 130);
            ntxt_precio.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            ntxt_precio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ntxt_precio.Name = "ntxt_precio";
            ntxt_precio.Size = new Size(120, 23);
            ntxt_precio.TabIndex = 6;
            ntxt_precio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ntxt_num_repuesto
            // 
            ntxt_num_repuesto.InterceptArrowKeys = false;
            ntxt_num_repuesto.Location = new Point(86, 53);
            ntxt_num_repuesto.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            ntxt_num_repuesto.Name = "ntxt_num_repuesto";
            ntxt_num_repuesto.Size = new Size(120, 23);
            ntxt_num_repuesto.TabIndex = 8;
            // 
            // cmb_marca
            // 
            cmb_marca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_marca.FormattingEnabled = true;
            cmb_marca.Items.AddRange(new object[] { "Peugeot", "Fiat", "Renault" });
            cmb_marca.Location = new Point(86, 24);
            cmb_marca.Name = "cmb_marca";
            cmb_marca.Size = new Size(121, 23);
            cmb_marca.TabIndex = 2;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(7, 27);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(40, 15);
            lbl_marca.TabIndex = 1;
            lbl_marca.Text = "Marca";
            // 
            // lbl_origen
            // 
            lbl_origen.AutoSize = true;
            lbl_origen.Location = new Point(7, 84);
            lbl_origen.Name = "lbl_origen";
            lbl_origen.Size = new Size(43, 15);
            lbl_origen.TabIndex = 2;
            lbl_origen.Text = "Origen";
            // 
            // lbl_repuesto
            // 
            lbl_repuesto.AutoSize = true;
            lbl_repuesto.Location = new Point(7, 55);
            lbl_repuesto.Name = "lbl_repuesto";
            lbl_repuesto.Size = new Size(73, 15);
            lbl_repuesto.TabIndex = 3;
            lbl_repuesto.Text = "N° Repuesto";
            // 
            // rb_importado
            // 
            rb_importado.AutoSize = true;
            rb_importado.Location = new Point(86, 105);
            rb_importado.Name = "rb_importado";
            rb_importado.Size = new Size(81, 19);
            rb_importado.TabIndex = 5;
            rb_importado.TabStop = true;
            rb_importado.Text = "Importado";
            rb_importado.UseVisualStyleBackColor = true;
            // 
            // rb_nacional
            // 
            rb_nacional.AutoSize = true;
            rb_nacional.Location = new Point(86, 82);
            rb_nacional.Name = "rb_nacional";
            rb_nacional.Size = new Size(72, 19);
            rb_nacional.TabIndex = 4;
            rb_nacional.TabStop = true;
            rb_nacional.Text = "Nacional";
            rb_nacional.UseVisualStyleBackColor = true;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(453, 41);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(76, 38);
            btn_registrar.TabIndex = 1;
            btn_registrar.Text = "&Registrar";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(453, 392);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(76, 38);
            btn_salir.TabIndex = 2;
            btn_salir.Text = "&Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // gb_consulta
            // 
            gb_consulta.Controls.Add(dgv_consulta);
            gb_consulta.Controls.Add(lbl_origen_consulta);
            gb_consulta.Controls.Add(lbl_marca_consulta);
            gb_consulta.Controls.Add(rb_importado_consulta);
            gb_consulta.Controls.Add(rb_nacional_consulta);
            gb_consulta.Controls.Add(cmb_marca_consulta);
            gb_consulta.Location = new Point(24, 203);
            gb_consulta.Name = "gb_consulta";
            gb_consulta.Size = new Size(408, 227);
            gb_consulta.TabIndex = 3;
            gb_consulta.TabStop = false;
            gb_consulta.Text = "Consulta de repuestos";
            // 
            // dgv_consulta
            // 
            dgv_consulta.AllowUserToAddRows = false;
            dgv_consulta.AllowUserToDeleteRows = false;
            dgv_consulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_consulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_consulta.Columns.AddRange(new DataGridViewColumn[] { col_nro_repuesto, col_precio, col_descripcion });
            dgv_consulta.Location = new Point(7, 77);
            dgv_consulta.Name = "dgv_consulta";
            dgv_consulta.ReadOnly = true;
            dgv_consulta.RowHeadersVisible = false;
            dgv_consulta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_consulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_consulta.Size = new Size(388, 144);
            dgv_consulta.TabIndex = 5;
            // 
            // col_nro_repuesto
            // 
            col_nro_repuesto.HeaderText = "Nro Repuesto";
            col_nro_repuesto.Name = "col_nro_repuesto";
            col_nro_repuesto.ReadOnly = true;
            col_nro_repuesto.Resizable = DataGridViewTriState.False;
            // 
            // col_precio
            // 
            col_precio.HeaderText = "Precio";
            col_precio.Name = "col_precio";
            col_precio.ReadOnly = true;
            col_precio.Resizable = DataGridViewTriState.False;
            // 
            // col_descripcion
            // 
            col_descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            col_descripcion.HeaderText = "Descripcion";
            col_descripcion.Name = "col_descripcion";
            col_descripcion.ReadOnly = true;
            col_descripcion.Resizable = DataGridViewTriState.False;
            col_descripcion.Width = 94;
            // 
            // lbl_origen_consulta
            // 
            lbl_origen_consulta.AutoSize = true;
            lbl_origen_consulta.Location = new Point(153, 28);
            lbl_origen_consulta.Name = "lbl_origen_consulta";
            lbl_origen_consulta.Size = new Size(43, 15);
            lbl_origen_consulta.TabIndex = 4;
            lbl_origen_consulta.Text = "Origen";
            // 
            // lbl_marca_consulta
            // 
            lbl_marca_consulta.AutoSize = true;
            lbl_marca_consulta.Location = new Point(7, 28);
            lbl_marca_consulta.Name = "lbl_marca_consulta";
            lbl_marca_consulta.Size = new Size(40, 15);
            lbl_marca_consulta.TabIndex = 3;
            lbl_marca_consulta.Text = "Marca";
            // 
            // rb_importado_consulta
            // 
            rb_importado_consulta.AutoSize = true;
            rb_importado_consulta.Location = new Point(232, 49);
            rb_importado_consulta.Name = "rb_importado_consulta";
            rb_importado_consulta.Size = new Size(81, 19);
            rb_importado_consulta.TabIndex = 2;
            rb_importado_consulta.TabStop = true;
            rb_importado_consulta.Text = "Importado";
            rb_importado_consulta.UseVisualStyleBackColor = true;
            // 
            // rb_nacional_consulta
            // 
            rb_nacional_consulta.AutoSize = true;
            rb_nacional_consulta.Location = new Point(153, 49);
            rb_nacional_consulta.Name = "rb_nacional_consulta";
            rb_nacional_consulta.Size = new Size(72, 19);
            rb_nacional_consulta.TabIndex = 1;
            rb_nacional_consulta.TabStop = true;
            rb_nacional_consulta.Text = "Nacional";
            rb_nacional_consulta.UseVisualStyleBackColor = true;
            // 
            // cmb_marca_consulta
            // 
            cmb_marca_consulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_marca_consulta.FormattingEnabled = true;
            cmb_marca_consulta.Items.AddRange(new object[] { "Peugeot", "Fiat", "Renault" });
            cmb_marca_consulta.Location = new Point(7, 48);
            cmb_marca_consulta.Name = "cmb_marca_consulta";
            cmb_marca_consulta.Size = new Size(121, 23);
            cmb_marca_consulta.TabIndex = 0;
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(453, 217);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(76, 42);
            btn_consultar.TabIndex = 4;
            btn_consultar.Text = "&Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // ep_ac_repuestos
            // 
            ep_ac_repuestos.ContainerControl = this;
            // 
            // sp_ac_repuestos
            // 
            sp_ac_repuestos.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            sp_ac_repuestos.ContainerControl = this;
            // 
            // lbl_exito
            // 
            lbl_exito.AutoSize = true;
            lbl_exito.Location = new Point(469, 99);
            lbl_exito.Name = "lbl_exito";
            lbl_exito.Size = new Size(0, 15);
            lbl_exito.TabIndex = 5;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_resultado.ForeColor = Color.Orange;
            lbl_resultado.Location = new Point(24, 433);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(0, 15);
            lbl_resultado.TabIndex = 6;
            // 
            // frm_gestion_repuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 457);
            Controls.Add(lbl_resultado);
            Controls.Add(lbl_exito);
            Controls.Add(btn_consultar);
            Controls.Add(gb_consulta);
            Controls.Add(btn_salir);
            Controls.Add(btn_registrar);
            Controls.Add(gb_alta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_gestion_repuestos";
            Text = "AC Repuestos";
            Load += frm_gestion_repuestos_Load;
            gb_alta.ResumeLayout(false);
            gb_alta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ntxt_precio).EndInit();
            ((System.ComponentModel.ISupportInitialize)ntxt_num_repuesto).EndInit();
            gb_consulta.ResumeLayout(false);
            gb_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_consulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep_ac_repuestos).EndInit();
            ((System.ComponentModel.ISupportInitialize)sp_ac_repuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_alta;
        private ComboBox cmb_marca;
        private Label lbl_marca;
        private Label lbl_origen;
        private Label lbl_repuesto;
        private RadioButton rb_nacional;
        private RadioButton rb_importado;
        private NumericUpDown ntxt_precio;
        private RichTextBox rtb_descripcion;
        private NumericUpDown ntxt_num_repuesto;
        private Label lbl_precio;
        private Label lbl_descripcion;
        private Button btn_registrar;
        private Button btn_salir;
        private GroupBox gb_consulta;
        private DataGridView dgv_consulta;
        private Label lbl_origen_consulta;
        private Label lbl_marca_consulta;
        private RadioButton rb_importado_consulta;
        private RadioButton rb_nacional_consulta;
        private ComboBox cmb_marca_consulta;
        private Button btn_consultar;
        private DataGridViewTextBoxColumn col_nro_repuesto;
        private DataGridViewTextBoxColumn col_precio;
        private DataGridViewTextBoxColumn col_descripcion;
        private ErrorProvider ep_ac_repuestos;
        private ErrorProvider sp_ac_repuestos;
        private Label lbl_exito;
        private Label lbl_resultado;
    }
}
