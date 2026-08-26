using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryPerezInterfazGraf
{
    public partial class frmCajaDeTexto : Form
    {
        public frmCajaDeTexto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(
                    "Código: " + txtCodigo.Text + "\n" +
                    "Medicamento: " + txtMedicamento.Text + "\n" +
                    "Laboratorio: " + txtLaboratorio.Text + "\n" +
                    "Categoría: " + txtCategoria.Text + "\n" +
                    "Precio: " + txtPrecio.Text
                );
            }
        }
    }
}
