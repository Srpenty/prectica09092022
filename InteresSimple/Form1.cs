using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteresSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string op = comboBoxOp.Text;
            string capital = txtCapital.Text;
            string tiempo = txtTiempo.Text;
            string interes = txtInteres.Text;
            string calculo;
            if (capital == "" || tiempo == "" || interes == "")
            {
                MessageBox.Show("Por favor rellene todos los espacios");
            }
            else
            {
                switch (op)
                {
                    case "Anual":
                        calculo = Convert.ToString(double.Parse(capital) * double.Parse(tiempo) / 100 * double.Parse(interes));
                        MessageBox.Show("El calculo es de: " + calculo);
                        break;
                    case "Mensual":
                        calculo = Convert.ToString(double.Parse(capital) * double.Parse(tiempo) / 100 * double.Parse(interes)/12);
                        MessageBox.Show("El calculo es de: " + calculo);
                        break;
                    case "Diario":
                        calculo = Convert.ToString(double.Parse(capital) * double.Parse(tiempo) /100 * double.Parse(interes) / 360);
                        MessageBox.Show("El calculo es de: " + calculo);
                        break;
                }


            }
        }
    }
}
