using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryPerezAgustinSP1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin inicio = new frmLogin();
            inicio.Show();
        }


    }
}
