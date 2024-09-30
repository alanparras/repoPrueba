using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Formulario4 : Form
    {
        public Formulario4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool ValidarCampos(out int desde, out int hasta)
        {
            desde = 0;
            hasta = 0;

            // Valida que ambos TextBox no estén vacíos
            if (string.IsNullOrEmpty(TDesde.Text) || string.IsNullOrEmpty(THasta.Text))
            {
                MessageBox.Show("Debe completar ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Valida que ambos TextBox contengan números
            if (!int.TryParse(TDesde.Text, out desde) || !int.TryParse(THasta.Text, out hasta))
            {
                MessageBox.Show("Ambos valores deben ser numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LimpiarDatos()
        {
            LBNumeros.Items.Clear();
            chart1.Series["NúmerosGenerados"].Points.Clear();
            chart1.Series["NúmerosPares"].Points.Clear();
            chart1.Series["NúmerosImpares"].Points.Clear();
            chart1.Series["NúmerosPrimos"].Points.Clear();
        }
        private void BGenerar_Click(object sender, EventArgs e)
        {
            // Validar que ambos TextBox no estén vacíos y que sean números válidos
            if (!ValidarCampos(out int desde, out int hasta))
                return;

            // Limpia el ListBox
            LimpiarDatos();

            // Genera números desde el valor "desde" hasta el valor "hasta" y los agrega al ListBox
            for (int i = desde; i <= hasta; i++)
            {
                LBNumeros.Items.Add(i.ToString());
                chart1.Series["NúmerosGenerados"].Points.AddY(i);
            }
        }

        private void BPar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out int desde, out int hasta))
                return;

            LimpiarDatos();

            // Agregar números pares al ListBox
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 == 0) // Verifica si el número es par
                {
                    LBNumeros.Items.Add(i.ToString());
                    chart1.Series["NúmerosPares"].Points.AddY(i);
                }
            }
        }

        private void BImpar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out int desde, out int hasta))
                return;

            LimpiarDatos();

            // Agrega números impares al ListBox
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 != 0) // Verifica si el número es impar
                {
                    LBNumeros.Items.Add(i.ToString());
                    chart1.Series["NúmerosImpares"].Points.AddY(i);
                }
            }
        }

        private void BPrimos_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out int desde, out int hasta))
                return;

            LBNumeros.Items.Clear();
            LimpiarDatos();

            // Agregar números primos al ListBox
            for (int i = desde; i <= hasta; i++)
            {
                if (EsPrimo(i)) // Verifica si el número es primo
                {
                    LBNumeros.Items.Add(i.ToString());
                    chart1.Series["NúmerosPrimos"].Points.AddY(i);
                }
            }
        }

        // Función para verificar si un número es primo
        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
