using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExercicio7
{
    public partial class Exercicio7Form : Form
    {
        public Exercicio7Form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtdCarrosFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoCalcular_Click(object sender, EventArgs e)
        {
            double comissaoVariavel = 0.0, comissaoFixa = 0.0, salarioFinal = 0.0;

            comissaoVariavel = double.Parse(totalVendidoFunc.Text) * 0.05;

            comissaoFixa = (double.Parse(totalVendidoFunc.Text) / double.Parse(qtdCarrosFunc.Text)) * (double.Parse(qtdRecebidaCarro.Text)/100.0);

            salarioFinal = double.Parse(salarioFixo.Text) + comissaoVariavel + comissaoFixa;

            resultado.Text = salarioFinal.ToString();
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            qtdCarrosFunc.Text = "";
            totalVendidoFunc.Text = "";
            qtdRecebidaCarro.Text = "";
            salarioFixo.Text = "";
            resultado.Text = "";
            qtdCarrosFunc.Focus();
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
