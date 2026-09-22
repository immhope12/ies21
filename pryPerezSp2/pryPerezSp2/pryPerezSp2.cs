using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryPerezSp2
{
    public partial class frmGestionBoleto : Form
    {
        private const int PRECIO_FIJO = 5;
        private const double DESCUENTO = 0.5;

        public frmGestionBoleto()
        {
            InitializeComponent();
        }

        private void frmGestionBoleto_Load(object sender, EventArgs e)
        {

        }

        private void pryPerezSp2_Load(object sender, EventArgs e)
        {

        }
        private void limpiar_campos()
        {
            ntxt_distancia.ResetText();
            ntxt_estancia.ResetText();

            ntxt_distancia.Focus();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            double precio_final = 0;
            double distancia = (double)ntxt_distancia.Value;

            
            if (distancia >= 100 && (double)ntxt_estancia.Value >= 7) precio_final = (PRECIO_FIJO * distancia) * DESCUENTO;
            else precio_final = PRECIO_FIJO * distancia;

            
            MessageBox.Show("El precio total es de: " + precio_final.ToString(), "Importe final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar_campos();
        }
    }
}
