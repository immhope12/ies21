using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryPerezAgustinSP1
{

    public partial class frmLogin : Form
    {
        bool esValido;
        string usuario;
        string contraseña;
        string modulo;
        int intentos = 0;
        //TIPO
        public frmLogin()
        {
            InitializeComponent();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            esValido = false;
            cmbModulo.SelectedIndex = 0;

        }

        private void Validar()
        {



            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;
            modulo = cmbModulo.Text;
            /*

           if ((usuario == "Adm" && contraseña == "@1a") && (modulo != "SIST"))
           {
                esValido = true;

           }
           else
           {
               esValido = false;


           }*/
            esValido = false;
            switch (usuario)
            {

                case "Adm":
                    if (contraseña == "@1a" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA"))
                    {
                        esValido = true;
                    }
                    break;
                case "John":
                    if (contraseña == "*2b" && (modulo == "SIST"))
                    {
                        esValido = true;
                    }
                    break;
                case "Ceci":
                    if (contraseña == "*@3c" && (modulo == "ADM" || modulo == "VTA"))
                    {
                        esValido = true;
                    }
                    break;
                case "God":
                    if (contraseña == "*@#4d" && (modulo == "SIST" || modulo == "ADM" || modulo == "COM" || modulo == "VTA"))
                    {
                        esValido = true;
                    }
                    break;

                default:
                    esValido = false;
                    break;

            }

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Validar();
            if (esValido == true)
            {

                this.Hide();
                frmInicio inicio = new frmInicio();

                inicio.Show();
            }
            else
            {
                intentos++;
                MessageBox.Show("Usuario y/o contraseña\r\nincorrectos para el módulo seleccionado");

                if (intentos >= 2)
                {
                    this.Close();

                }
                else
                {
                    txtContraseña.Clear();
                    txtUsuario.Clear();
                }
            }


        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



