using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            string op = comboBoxEleccion.Text;
            string num1 = txtNum1.Text;
            string num2 = txtNum2.Text;
            string Resultado;

            if (num1 == "" || num2 == "" || op == "")
            {
                MessageBox.Show("Por favor rellene todo los campos para continuar");
            }
            else
            {
                double Num1 = int.Parse(num1);
                double Num2 = int.Parse(num2);
                switch (op)
                {
                    case "Suma":
                        Resultado = Convert.ToString(Num1 + Num2);
                        MessageBox.Show("El resultado de la suma es: " + Resultado);
                        break;
                    case "Resta":
                        Resultado = Convert.ToString(Num1 - Num2);
                        MessageBox.Show("El resultado de la resta es: " + Resultado);
                        break;
                    case "Multiplicacion":
                        Resultado = Convert.ToString(Num1 * Num2);
                        MessageBox.Show("El resultado de la multiplicacion es: " + Resultado);
                        break;
                    case "Division":
                        Resultado = Convert.ToString(Num1 / Num2);
                        MessageBox.Show("El resultado de la Division es: " + Resultado);
                        break;
                }
            }
        }
    }
}
