namespace pryPerezAgustinSp2
{
    partial class frmGestionRepuestos
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
            lblMarca = new Label();
            lblRepuesto = new Label();
            lblOrigen = new Label();
            lblPrecio = new Label();
            cmbMarca = new ComboBox();
            ntnxRepuesto = new NumericUpDown();
            ntnxPrecio = new NumericUpDown();
            rbtNacional = new RadioButton();
            rbtImportado = new RadioButton();
            rtbDescripcion = new RichTextBox();
            gbAlta = new GroupBox();
            lblDescripcion = new Label();
            dgvConsulta = new DataGridView();
            col_nro_repuesto = new DataGridViewTextBoxColumn();
            col_precio = new DataGridViewTextBoxColumn();
            col_descripcion = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            lblMarcaConsulta = new Label();
            lblOrigenConsulta = new Label();
            rbtImportadoConsulta = new RadioButton();
            rbtNacionalConsulta = new RadioButton();
            gpConsulta = new GroupBox();
            btnConsultar = new Button();
            btnSalir = new Button();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)ntnxRepuesto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ntnxPrecio).BeginInit();
            gbAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            gpConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(14, 17);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblRepuesto
            // 
            lblRepuesto.AutoSize = true;
            lblRepuesto.Location = new Point(14, 52);
            lblRepuesto.Name = "lblRepuesto";
            lblRepuesto.Size = new Size(73, 15);
            lblRepuesto.TabIndex = 1;
            lblRepuesto.Text = "N° Repuesto";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(14, 84);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Origen";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(14, 134);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "Peugeot", "Fiat", "Renault" });
            cmbMarca.Location = new Point(100, 14);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 4;
            // 
            // ntnxRepuesto
            // 
            ntnxRepuesto.Location = new Point(100, 50);
            ntnxRepuesto.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            ntnxRepuesto.Name = "ntnxRepuesto";
            ntnxRepuesto.Size = new Size(120, 23);
            ntnxRepuesto.TabIndex = 5;
            // 
            // ntnxPrecio
            // 
            ntnxPrecio.DecimalPlaces = 2;
            ntnxPrecio.Location = new Point(100, 132);
            ntnxPrecio.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            ntnxPrecio.Name = "ntnxPrecio";
            ntnxPrecio.Size = new Size(120, 23);
            ntnxPrecio.TabIndex = 6;
            // 
            // rbtNacional
            // 
            rbtNacional.AutoSize = true;
            rbtNacional.Checked = true;
            rbtNacional.Location = new Point(105, 82);
            rbtNacional.Name = "rbtNacional";
            rbtNacional.Size = new Size(72, 19);
            rbtNacional.TabIndex = 7;
            rbtNacional.TabStop = true;
            rbtNacional.Text = "Nacional";
            rbtNacional.UseVisualStyleBackColor = true;
            // 
            // rbtImportado
            // 
            rbtImportado.AutoSize = true;
            rbtImportado.Location = new Point(105, 107);
            rbtImportado.Name = "rbtImportado";
            rbtImportado.Size = new Size(81, 19);
            rbtImportado.TabIndex = 8;
            rbtImportado.Text = "Importado";
            rbtImportado.UseVisualStyleBackColor = true;
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(246, 38);
            rtbDescripcion.MaxLength = 50;
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(168, 126);
            rtbDescripcion.TabIndex = 9;
            rtbDescripcion.Text = "";
            // 
            // gbAlta
            // 
            gbAlta.Controls.Add(lblDescripcion);
            gbAlta.Controls.Add(rtbDescripcion);
            gbAlta.Controls.Add(rbtImportado);
            gbAlta.Controls.Add(rbtNacional);
            gbAlta.Controls.Add(ntnxPrecio);
            gbAlta.Controls.Add(ntnxRepuesto);
            gbAlta.Controls.Add(cmbMarca);
            gbAlta.Controls.Add(lblPrecio);
            gbAlta.Controls.Add(lblOrigen);
            gbAlta.Controls.Add(lblRepuesto);
            gbAlta.Controls.Add(lblMarca);
            gbAlta.Location = new Point(12, 30);
            gbAlta.Name = "gbAlta";
            gbAlta.Size = new Size(437, 189);
            gbAlta.TabIndex = 10;
            gbAlta.TabStop = false;
            gbAlta.Text = "Alta de Repuestos";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(246, 22);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripcion";
            // 
            // dgvConsulta
            // 
            dgvConsulta.AllowUserToAddRows = false;
            dgvConsulta.AllowUserToDeleteRows = false;
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Columns.AddRange(new DataGridViewColumn[] { col_nro_repuesto, col_precio, col_descripcion });
            dgvConsulta.Location = new Point(24, 64);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.ReadOnly = true;
            dgvConsulta.RowHeadersVisible = false;
            dgvConsulta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsulta.Size = new Size(388, 144);
            dgvConsulta.TabIndex = 11;
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Peugeot", "Fiat", "Renault" });
            comboBox1.Location = new Point(24, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // lblMarcaConsulta
            // 
            lblMarcaConsulta.AutoSize = true;
            lblMarcaConsulta.Location = new Point(27, 17);
            lblMarcaConsulta.Name = "lblMarcaConsulta";
            lblMarcaConsulta.Size = new Size(40, 15);
            lblMarcaConsulta.TabIndex = 13;
            lblMarcaConsulta.Text = "Marca";
            // 
            // lblOrigenConsulta
            // 
            lblOrigenConsulta.AutoSize = true;
            lblOrigenConsulta.Location = new Point(177, 17);
            lblOrigenConsulta.Name = "lblOrigenConsulta";
            lblOrigenConsulta.Size = new Size(43, 15);
            lblOrigenConsulta.TabIndex = 14;
            lblOrigenConsulta.Text = "Origen";
            // 
            // rbtImportadoConsulta
            // 
            rbtImportadoConsulta.AutoSize = true;
            rbtImportadoConsulta.Location = new Point(256, 36);
            rbtImportadoConsulta.Name = "rbtImportadoConsulta";
            rbtImportadoConsulta.Size = new Size(81, 19);
            rbtImportadoConsulta.TabIndex = 16;
            rbtImportadoConsulta.TabStop = true;
            rbtImportadoConsulta.Text = "Importado";
            rbtImportadoConsulta.UseVisualStyleBackColor = true;
            // 
            // rbtNacionalConsulta
            // 
            rbtNacionalConsulta.AutoSize = true;
            rbtNacionalConsulta.Location = new Point(177, 36);
            rbtNacionalConsulta.Name = "rbtNacionalConsulta";
            rbtNacionalConsulta.Size = new Size(72, 19);
            rbtNacionalConsulta.TabIndex = 15;
            rbtNacionalConsulta.TabStop = true;
            rbtNacionalConsulta.Text = "Nacional";
            rbtNacionalConsulta.UseVisualStyleBackColor = true;
            // 
            // gpConsulta
            // 
            gpConsulta.Controls.Add(rbtImportadoConsulta);
            gpConsulta.Controls.Add(rbtNacionalConsulta);
            gpConsulta.Controls.Add(lblOrigenConsulta);
            gpConsulta.Controls.Add(lblMarcaConsulta);
            gpConsulta.Controls.Add(comboBox1);
            gpConsulta.Controls.Add(dgvConsulta);
            gpConsulta.Location = new Point(2, 243);
            gpConsulta.Name = "gpConsulta";
            gpConsulta.Size = new Size(452, 250);
            gpConsulta.TabIndex = 17;
            gpConsulta.TabStop = false;
            gpConsulta.Text = "Consulta";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(289, 512);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(76, 42);
            btnConsultar.TabIndex = 20;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(197, 512);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(72, 42);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(395, 512);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(80, 40);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmGestionRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 581);
            Controls.Add(btnConsultar);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(gpConsulta);
            Controls.Add(gbAlta);
            Name = "frmGestionRepuestos";
            Text = "AC Repuestos";
            ((System.ComponentModel.ISupportInitialize)ntnxRepuesto).EndInit();
            ((System.ComponentModel.ISupportInitialize)ntnxPrecio).EndInit();
            gbAlta.ResumeLayout(false);
            gbAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            gpConsulta.ResumeLayout(false);
            gpConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private Label lblMarca;
        private Label lblRepuesto;
        private Label lblOrigen;
        private Label lblPrecio;
        private ComboBox cmbMarca;
        private NumericUpDown ntnxRepuesto;
        private NumericUpDown ntnxPrecio;
        private RadioButton rbtNacional;
        private RadioButton rbtImportado;
        private RichTextBox rtbDescripcion;
        private GroupBox gbAlta;
        private Label lblDescripcion;
        private DataGridView dgvConsulta;
        private DataGridViewTextBoxColumn col_nro_repuesto;
        private DataGridViewTextBoxColumn col_precio;
        private DataGridViewTextBoxColumn col_descripcion;
        private ComboBox comboBox1;
        private Label lblMarcaConsulta;
        private Label lblOrigenConsulta;
        private RadioButton rbtImportadoConsulta;
        private RadioButton rbtNacionalConsulta;
        private GroupBox gpConsulta;
        private Button btnConsultar;
        private Button btnSalir;
        private Button btnRegistrar;
    }
    
    }
