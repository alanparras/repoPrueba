using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3
{
    public partial class PequeñoFormulario : Form
    {
        public PequeñoFormulario()
        {
            InitializeComponent();
        }

        private void PequeñoFormulario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números --y teclas de control (como Backspace)--
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras y espacios en blanco --y teclas de control--
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números --y teclas de control (como Backspace)--
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Verifica si todos los campos están completos
            if (string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TApellido.Text))
            {
                // Muestra un mensaje de error
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Muestra el mensaje de consulta
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verifica el resultado del mensaje de consulta
                if (ask == DialogResult.Yes)
                {
                    // Modifica el label "LModificar" para mostrar el nombre y apellido
                    LModificar.Text = $"{TNombre.Text} {TApellido.Text}";

                    // Muestra el mensaje con el nombre del cliente registrado
                    MessageBox.Show($"El Cliente: {TNombre.Text} {TApellido.Text} se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si los campos están vacíos
            if ((!string.IsNullOrWhiteSpace(TDni.Text) && !string.IsNullOrWhiteSpace(TNombre.Text) && !string.IsNullOrWhiteSpace(TApellido.Text)) && LModificar.Text != "Modificar")
            {
                // Muestra una advertencia con el foco en "No"
                DialogResult ask = MessageBox.Show($"Está a punto de eliminar el Cliente: {TNombre.Text} {TApellido.Text}", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                // Si el usuario selecciona "Si" limpian los TextBox, de lo contrario no se realiza ninguna accion
                if (ask == DialogResult.Yes)
                {

                    // Muestra mensaje de confirmación
                    MessageBox.Show($"El Cliente: {TNombre.Text} {TApellido.Text} se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpia los TextBox
                    TDni.Clear();
                    TNombre.Clear();
                    TApellido.Clear();
                    TTelefono.Clear();
                    LModificar.Text = "Modificar";

                }
            }
        }

        private void BSAlir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                PSexo.BackgroundImage = Proyecto3.Properties.Resources.varon;
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                PSexo.BackgroundImage = Proyecto3.Properties.Resources.mujer;
            }
        }
    }
}
