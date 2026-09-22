namespace pryPerezSp3
{
    public partial class frm_gestion_repuestos : Form
    {
       
        private List<Repuesto> lista_repuesto = new List<Repuesto>();

      
        private Dictionary<string, string> DIC_MARCA = new Dictionary<string, string>()
        {
            { "Peugeot", "P" },
            { "Fiat", "F" },
            { "Renault", "R" }
        };

        public frm_gestion_repuestos()
        {
            InitializeComponent();
        }

        
        private void frm_gestion_repuestos_Load(object sender, EventArgs e)
        {
            cmb_marca.SelectedIndex = 0;
            cmb_marca_consulta.SelectedIndex = 0;
            rb_nacional.Checked = true;
            rb_nacional_consulta.Checked = true;
            ntxt_num_repuesto.Controls[0].Hide();
            ntxt_precio.Controls[0].Hide();
        }

       
        private void limpiar_campos_registro()
        {
            rtb_descripcion.Clear();
            ntxt_num_repuesto.ResetText();
            ntxt_precio.ResetText();
            cmb_marca.SelectedIndex = 0;
            rb_nacional.Checked = true;

            ntxt_num_repuesto.BackColor = Color.White;
            rtb_descripcion.BackColor = Color.White;
            ep_ac_repuestos.Clear();

            cmb_marca.Focus();
        }

     
        private void limpiar_tabla()
        {
            dgv_consulta.Rows.Clear();
            lbl_resultado.ResetText();
        }

      
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            
            if (lista_repuesto.Count >= 100)
            {
                MessageBox.Show("Se ha llegado al número máximo de números permitidos (100)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nro_repuesto = (int)ntxt_num_repuesto.Value;
            string descripcion = rtb_descripcion.Text;

            // Validación del nro de repuesto para saber si hay uno existente.
            foreach (Repuesto r in lista_repuesto)
            {
                if (r.NroRepuesto == nro_repuesto)
                {
                    ep_ac_repuestos.SetError(ntxt_num_repuesto, "El numero de repuesto ya existe.");
                    ntxt_num_repuesto.BackColor = Color.MistyRose;
                    sp_ac_repuestos.Clear();
                    return;
                }
            }

          
            if (descripcion == "")
            {
                ep_ac_repuestos.SetError(rtb_descripcion, "La descripción no puede estar vacía.");
                rtb_descripcion.BackColor = Color.MistyRose;
                sp_ac_repuestos.Clear();
                return;
            }

            
            Repuesto repuesto = new Repuesto
            {
                Marca = cmb_marca.Text,
                Descripcion = descripcion,
                Precio = (float)ntxt_precio.Value,
                NroRepuesto = nro_repuesto,
                Origen = rb_nacional.Checked ? "N" : "I"
            };


            sp_ac_repuestos.SetError(lbl_exito, "Carga exitosa.");
            limpiar_campos_registro();

            
            lista_repuesto.Add(repuesto);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            limpiar_tabla();

           
            if (lista_repuesto.Count == 0)
            {
                MessageBox.Show("No hay elementos cargados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string marca = cmb_marca_consulta.Text;
            string origen = rb_nacional_consulta.Checked ? "N" : "I";
            int coincidencias = 0;

            foreach (Repuesto r in lista_repuesto)
            {
                if (r.Marca == marca && r.Origen == origen)
                {
                    dgv_consulta.Rows.Add(r.NroRepuesto, r.Precio, r.Descripcion);
                    coincidencias++;
                }
            }

           
            lbl_resultado.Text = coincidencias == 0 ? "No se encontraron repuestos para esa marca y origen" : $"{coincidencias} repuesto(s) encontrado(s)";
        }
    }
}