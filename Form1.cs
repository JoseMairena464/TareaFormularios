using System.Text;

namespace TareaFormulario
{
    public partial class Form1 : Form
    {
        private StringBuilder listaEstudiantes = new StringBuilder();
        public Form1()
        {
          
     
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string carnet = txtCarnet.Text.Trim();
            string carrera = txtCarrera.Text.Trim();

            // Validaciones
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (carnet.Length != 7)
            {
                MessageBox.Show("El carnet debe tener exactamente 7 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(carrera))
            {
                MessageBox.Show("La carrera no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar a la lista
            listaEstudiantes.AppendLine($"{nombre} - {carnet} - {carrera}");
            lblLista.Text = "Lista de Estudiantes:\n" + listaEstudiantes.ToString();

            // Limpiar campos
            txtNombre.Clear();
            txtCarnet.Clear();
            txtCarrera.Clear();
            txtNombre.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCarnet.Clear();
            txtCarrera.Clear();
            lblLista.Text = "Lista de Estudiantes:\n";
            listaEstudiantes.Clear();
            txtNombre.Focus();
        }
    }
}
