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
    public partial class primeiroForm : Form
    {
        public primeiroForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            custoFabrica.Text = "";
            valorFinal.Text = "";
            custoFabrica.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botaoCalcular_Click(object sender, EventArgs e)
        {
            double imposto = 0, distribuidor = 0, custoFinal = 0;

            imposto = double.Parse(custoFabrica.Text) * 0.25;
            distribuidor = double.Parse(custoFabrica.Text) * 0.48;
            custoFinal = double.Parse(custoFabrica.Text) + imposto + distribuidor;

            valorFinal.Text = custoFinal.ToString();
        }

        private void valorFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
