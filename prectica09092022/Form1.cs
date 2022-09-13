using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prectica09092022
{
    public partial class Form1 : Form
    {
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola este es mi primer formulario");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            if (mensaje == "")
            {
                MessageBox.Show("Debe ingresar un dato");
            }else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            string opseleccionada = comboOpcion.Text;
            MessageBox.Show(opseleccionada);
        }

        private void comboOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opseleccionada = comboOpcion.Text;
            MessageBox.Show(opseleccionada);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            var suma = num1 + num2;
            MessageBox.Show(suma.ToString());
        }
    }
}
