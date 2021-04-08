using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExemplo
{
    public partial class Exercicio : Form
    {
        public Exercicio()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTela1 objTela = new frmTela1();
            objTela.ShowDialog();
            //Show = exibe o formulário sempre que for chamado. Se clicar 5 vezes no botão, surgirão 5 formulários. Existe sobreposição.
            //ShowDialog() = para voltar para a tela principal, precisamos fechar o formulário. Só abre uma tela. Não tem sobreposição.
        }
    }
}
