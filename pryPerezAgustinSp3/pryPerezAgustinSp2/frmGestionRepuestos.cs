namespace pryPerezAgustinSp2
{
    public struct Repuesto
    {
        public char Marca;
        public char Origen;
        public int Numero;
        public string Descripcion;
        public float Precio;

    }

    public partial class frmGestionRepuestos : Form
    {
        Repuesto[] repuestos = new Repuesto[100];
        int cantidad = 0;
        public frmGestionRepuestos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Lectura de datos 
            char marca = cmbMarca.Text[0];
            char origen = rbtNacional.Checked ? 'N' : (rbtImportado.Checked ? 'I' : ' ');
            int numero = (int)ntnxRepuesto.Value;
            string descripcion = rtbDescripcion.Text;
            float precio = (float)ntnxPrecio.Value;

            // Verificar que se haya seleccionado una marca
            if (string.IsNullOrWhiteSpace(cmbMarca.Text))
            {
                MessageBox.Show("Debe seleccionar una marca.");
                return;
            }

            // 2. Validar origen
            if (origen == ' ')
            {
                MessageBox.Show("Debe seleccionar el origen (Nacional o Importado).");
                return;
            }

            // 3. Validar descripción
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Debe ingresar una descripción.");
                return;
            }

            if (descripcion.Length > 50)
            {
                MessageBox.Show("La descripción no puede superar los 50 caracteres.");
                return;
            }

            // 4. Validar precio
            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.");
                return;
            }

            // 5. Verificar número repetido
            bool repetido = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (repuestos[i].Numero == numero)
                {
                    repetido = true;
                    break;
                }
            }

            if (repetido)
            {
                MessageBox.Show("Ya existe un repuesto con ese número.");
                return;
            }

            // 6. Verificar que el arreglo no esté lleno
            if (cantidad >= 100)
            {
                MessageBox.Show("Se alcanzó el máximo de 100 repuestos. No se permiten más ingresos.");
                return;
            }

            // 7. Registrar el repuesto
            repuestos[cantidad].Marca = marca;
            repuestos[cantidad].Origen = origen;
            repuestos[cantidad].Numero = numero;
            repuestos[cantidad].Descripcion = descripcion;
            repuestos[cantidad].Precio = precio;

            cantidad++;

            MessageBox.Show("Repuesto registrado correctamente.");

            // Limpiar los controles para cargar otro repuesto
            cmbMarca.SelectedIndex = -1;
            rbtNacional.Checked = false;
            rbtImportado.Checked = false;
            ntnxRepuesto.Value = 0;
            rtbDescripcion.Clear();
            ntnxPrecio.Value = 0;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // 1. Validar que se haya seleccionado una marca en la consulta
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Debe seleccionar una marca para consultar.");
                return;
            }

            // 2. Obtener la marca buscada (primer carácter)
            char marcaBuscada = comboBox1.Text[0];

            // 3. Determinar el origen buscado
            char origenBuscado;
            if (rbtNacionalConsulta.Checked)
            {
                origenBuscado = 'N';
            }
            else if (rbtImportadoConsulta.Checked)
            {
                origenBuscado = 'I';
            }
            else
            {
                MessageBox.Show("Debe seleccionar un origen (Nacional o Importado) para consultar.");
                return;
            }

            // 4. Limpiar filas previas de la grilla
            dgvConsulta.Rows.Clear();

            // 5. Contador para saber si encontramos coincidencias
            int coincidencias = 0;

            // 6. Recorrer los repuestos cargados hasta ahora
            for (int i = 0; i < cantidad; i++)
            {
                if (repuestos[i].Marca == marcaBuscada && repuestos[i].Origen == origenBuscado)
                {
                    // Agregar fila con: Número, Precio, Descripción
                    dgvConsulta.Rows.Add(repuestos[i].Numero, repuestos[i].Precio, repuestos[i].Descripcion);
                    coincidencias++;
                }
            }

            // 7. Informar si no hubo resultados
            if (coincidencias == 0)
            {
                MessageBox.Show("No se encontraron repuestos con los filtros seleccionados.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}