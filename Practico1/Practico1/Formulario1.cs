namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            TBResultado.Clear();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Concatenar el apellido y el nombre
            TBResultado.Text = TBApellido.Text + " " + TBNombre.Text;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            // Detectar si se presiona Ctrl + S
            if (e.Control && e.KeyCode == Keys.S)
            {
                Application.Exit();
            }
        }
    }
}
