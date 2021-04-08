using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAExercicio30_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pagina1_Click(object sender, EventArgs e)
        {

        }

        private void botao1_Click(object sender, EventArgs e)
        {
            
        }

        private void texto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                adicionar_Click(null, null);
            }
        }

        private void adicionar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            primeiroGrid.Rows.Add(txtCodigo.Text, txtNome.Text);
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtCodigo.Focus();

        }

        private void primeiroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inserir_Click(object sender, EventArgs e)
        {
            primeiroGrid.Rows.Insert(1, txtCodigo.Text, txtNome.Text);

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            primeiroGrid.Rows.Clear();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            primeiroGrid.Rows.RemoveAt(primeiroGrid.CurrentRow.Cells[0].RowIndex);
        }
    }
}
