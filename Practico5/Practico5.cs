using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class FPractico5 : Form
    {
        public FPractico5()
        {
            InitializeComponent();
        }

        private void FPractico5_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TRutaFoto.Text = openFileDialog.FileName;
                PictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        //Convierten el texto ingresado del nombre y apellido de tal forma que la primera letra sea mayúscula y las demás sean minúsculas
        private void TNombre_Leave(object sender, EventArgs e)
        {
            TNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TNombre.Text.ToLower());
        }

        private void TApellido_Leave(object sender, EventArgs e)
        {
            TApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TApellido.Text.ToLower());
        }
       

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }



        private void BAgregar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            row.Cells["Apellido"].Value = TApellido.Text;
            row.Cells["Nombre"].Value = TNombre.Text;
            row.Cells["FechaNacimiento"].Value = DateTimePicker.Value.ToShortDateString();
            row.Cells["Sexo"].Value = RBHombre.Checked ? "Hombre" : "Mujer";
            row.Cells["Saldo"].Value = TSaldo.Text;
            row.Cells["Ruta"].Value = TRutaFoto.Text;

            if (PictureBox.Image != null)
            {
                row.Cells["Foto"].Value = PictureBox.Image;
            }

            // Crear un botón de eliminar
            DataGridViewButtonCell btnEliminar = new DataGridViewButtonCell();
            btnEliminar.Value = "Eliminar";
            row.Cells["Eliminar"].Value = btnEliminar;

            // Validar si el saldo es menor a 50
            if (Convert.ToDecimal(TSaldo.Text) < 50)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                var confirmResult = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                if (row.Cells["Sexo"].Value.ToString() == "Hombre")
                {
                    RBHombre.Checked = true;
                }
                else
                {
                    RBMujer.Checked = true;
                }
            }
        }

        private void RBHombre_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
