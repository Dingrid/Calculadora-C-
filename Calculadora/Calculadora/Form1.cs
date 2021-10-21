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

        private void btSoma_Click(object sender, EventArgs e)
        {
            double n1, n2, soma;
            n1 = Double.Parse(tb_num1.Text);
            n2 = Double.Parse(tb_num2.Text);
            soma = n1 + n2;
            tb_resultado.Text = soma.ToString("F");
            tb_resultado.Enabled = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
           tb_resultado.Text = null;
           tb_num1.Text = null;
           tb_num2.Text = null;
           tb_resultado.Enabled = false;
           tb_num2.Enabled = false;
           btSoma.Enabled = false;
           btSubtrai.Enabled = false;
           btDivide.Enabled = false;
           btMultiplica.Enabled = false;
           btResto.Enabled = false;
           btLimpar.Enabled = false;
        }

        private void btSubtrai_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = Double.Parse(tb_num1.Text);
            n2 = Double.Parse(tb_num2.Text);
            resultado = n1 - n2;
            tb_resultado.Text = resultado.ToString("F");
            tb_resultado.Enabled = true;
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = Double.Parse(tb_num1.Text);
            n2 = Double.Parse(tb_num2.Text);

            if (n2 == 0) tb_resultado.Text = "Impossível dividir por 0";
            else
            {
                resultado = n1 / n2;
                tb_resultado.Text = resultado.ToString("F");
            }
            tb_resultado.Enabled = true;
        }

        private void btMultiplica_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = Double.Parse(tb_num1.Text);
            n2 = Double.Parse(tb_num2.Text);
            resultado = n1 * n2;
            tb_resultado.Text = resultado.ToString("F");
            tb_resultado.Enabled = true;
        }

        private void btResto_Click(object sender, EventArgs e)
        {
            double n1, n2, resultado;
            n1 = Double.Parse(tb_num1.Text);
            n2 = Double.Parse(tb_num2.Text);
            resultado = n1 % n2;
            tb_resultado.Text = resultado.ToString();
            tb_resultado.Enabled = true;
        }

        private void tb_num1_TextChanged(object sender, EventArgs e)
        {
            if (tb_num1.Text != null)
            {
                tb_num2.Enabled = true;
            }
        }

        private void tb_num2_TextChanged(object sender, EventArgs e)
        {
            if (tb_num2.Text != null)
            {
                btSoma.Enabled = true;
                btSubtrai.Enabled = true;
                btDivide.Enabled = true;
                btMultiplica.Enabled = true;
                btResto.Enabled = true;
                btLimpar.Enabled = true;
            }
        }
    }
}
