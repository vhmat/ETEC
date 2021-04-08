
namespace AplWFAExercicio30_03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pagina1 = new System.Windows.Forms.TabPage();
            this.pagina2 = new System.Windows.Forms.TabPage();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inserir = new System.Windows.Forms.Button();
            this.primeiroGrid = new System.Windows.Forms.DataGridView();
            this.eliminar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicionar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.pagina1.SuspendLayout();
            this.pagina2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primeiroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pagina1);
            this.tabControl1.Controls.Add(this.pagina2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // pagina1
            // 
            this.pagina1.AccessibleName = "paginaEntrada";
            this.pagina1.Controls.Add(this.adicionar);
            this.pagina1.Controls.Add(this.inserir);
            this.pagina1.Controls.Add(this.label2);
            this.pagina1.Controls.Add(this.label1);
            this.pagina1.Controls.Add(this.txtNome);
            this.pagina1.Controls.Add(this.txtCodigo);
            this.pagina1.Location = new System.Drawing.Point(4, 22);
            this.pagina1.Name = "pagina1";
            this.pagina1.Padding = new System.Windows.Forms.Padding(3);
            this.pagina1.Size = new System.Drawing.Size(746, 314);
            this.pagina1.TabIndex = 0;
            this.pagina1.Text = "Entrada de Dados";
            this.pagina1.UseVisualStyleBackColor = true;
            // 
            // pagina2
            // 
            this.pagina2.AccessibleName = "consultarDados";
            this.pagina2.Controls.Add(this.eliminar);
            this.pagina2.Controls.Add(this.primeiroGrid);
            this.pagina2.Location = new System.Drawing.Point(4, 22);
            this.pagina2.Name = "pagina2";
            this.pagina2.Padding = new System.Windows.Forms.Padding(3);
            this.pagina2.Size = new System.Drawing.Size(746, 314);
            this.pagina2.TabIndex = 1;
            this.pagina2.Text = "Consultar Dados";
            this.pagina2.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(81, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // inserir
            // 
            this.inserir.Location = new System.Drawing.Point(624, 246);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(116, 62);
            this.inserir.TabIndex = 5;
            this.inserir.Text = "&Inserir";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // primeiroGrid
            // 
            this.primeiroGrid.AllowUserToAddRows = false;
            this.primeiroGrid.AllowUserToDeleteRows = false;
            this.primeiroGrid.AllowUserToOrderColumns = true;
            this.primeiroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primeiroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome});
            this.primeiroGrid.Location = new System.Drawing.Point(-4, 0);
            this.primeiroGrid.Name = "primeiroGrid";
            this.primeiroGrid.RowHeadersVisible = false;
            this.primeiroGrid.Size = new System.Drawing.Size(750, 117);
            this.primeiroGrid.TabIndex = 0;
            this.primeiroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.primeiroGrid_CellContentClick);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(624, 246);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(116, 62);
            this.eliminar.TabIndex = 5;
            this.eliminar.Text = "&Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(647, 376);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(116, 62);
            this.sair.TabIndex = 7;
            this.sair.Text = "&Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(525, 376);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(116, 62);
            this.limpar.TabIndex = 6;
            this.limpar.Text = "&Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 200;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(502, 246);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(116, 62);
            this.adicionar.TabIndex = 6;
            this.adicionar.Text = "&Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DataGridView e TabControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.pagina1.ResumeLayout(false);
            this.pagina1.PerformLayout();
            this.pagina2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.primeiroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pagina1;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TabPage pagina2;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.DataGridView primeiroGrid;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Button adicionar;
    }
}

