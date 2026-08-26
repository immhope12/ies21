using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryPresentacionPerezIG
{
    public partial class frmCaso1 : Form
    {
        public frmCaso1()
        {
            InitializeComponent();
        }

        private void frmCaso1_Load(object sender, EventArgs e)
        {

        }

        private void btnPresentar_Click(object sender, EventArgs e)
        {
            

            string datos =  $"Nombre: {txtNombre.Text}\n"+
                            $"Apellido: {txtApellido.Text}\n"+
                            $"Edad: {txtEdad.Text} \n"+
                            $"Carrera {txtCarrera.Text}";



            MessageBox.Show(datos, "Información Ingresada");

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
