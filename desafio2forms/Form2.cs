using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double montoPrestamo = double.Parse(txtMontoPrestamo.Text);
                double tasaInteresMensual = double.Parse(txtTasaInteresMensual.Text) / 100;
                int plazoMeses = int.Parse(txtPlazoMeses.Text);

                double cuotaMensual = (montoPrestamo * tasaInteresMensual) / (1 - Math.Pow(1 + tasaInteresMensual, -plazoMeses));

                lblCuotaMensual.Text = $"Cuota Mensual: {cuotaMensual:C2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
