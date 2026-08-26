using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryPerezInterfazGraf
{
    public partial class frmSOC : Form
    {
        public frmSOC()
        {
            InitializeComponent();
        }
        private int contCritico = 0;
        private int contAlta = 0;
        private int contMedia = 0;
        private int contBaja = 0;
        private void lblCritico_Click(object sender, EventArgs e)
        {
            if (contCritico < 100) contCritico += 10;
            lblResultadoCritico.BackColor = Color.Red;
            lblResultadoCritico.Text = contCritico + "%";
        }

        private void lblAlta_Click(object sender, EventArgs e)
        {
            if (contAlta < 100) contAlta += 10;
            lblResultadoAlta.BackColor = Color.Orange;
            lblResultadoAlta.Text = contAlta + "%";
        }

        private void lblMedia_Click_1(object sender, EventArgs e)
        {
            if (contMedia < 100) contMedia += 5;
            lblResultadoMedia.BackColor = Color.Yellow;
            lblResultadoMedia.Text = contMedia + "%";
        }

        private void lblBaja_Click_1(object sender, EventArgs e)
        {
            if (contBaja < 100) contBaja += 1;
            lblResultadoBaja.BackColor = Color.Green;
            lblResultadoBaja.Text = contBaja + "%";
        }
    }
}
