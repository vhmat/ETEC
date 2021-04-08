
namespace AplWFABancoDeDados
{
    partial class segundoFormulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.primeiroDataGrid = new System.Windows.Forms.DataGridView();
            this.imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultarDG = new System.Windows.Forms.Button();
            this.fecharDG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.primeiroDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAR DADOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // primeiroDataGrid
            // 
            this.primeiroDataGrid.AllowUserToAddRows = false;
            this.primeiroDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primeiroDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagem,
            this.codigoDG,
            this.nomeDG,
            this.telefoneDG});
            this.primeiroDataGrid.Location = new System.Drawing.Point(23, 105);
            this.primeiroDataGrid.Name = "primeiroDataGrid";
            this.primeiroDataGrid.RowHeadersVisible = false;
            this.primeiroDataGrid.Size = new System.Drawing.Size(776, 243);
            this.primeiroDataGrid.TabIndex = 1;
            // 
            // imagem
            // 
            this.imagem.HeaderText = "IMAGEM";
            this.imagem.Name = "imagem";
            // 
            // codigoDG
            // 
            this.codigoDG.HeaderText = "CÓDIGO";
            this.codigoDG.Name = "codigoDG";
            // 
            // nomeDG
            // 
            this.nomeDG.HeaderText = "NOME";
            this.nomeDG.Name = "nomeDG";
            // 
            // telefoneDG
            // 
            this.telefoneDG.HeaderText = "TELEFONE";
            this.telefoneDG.Name = "telefoneDG";
            // 
            // consultarDG
            // 
            this.consultarDG.Location = new System.Drawing.Point(460, 391);
            this.consultarDG.Name = "consultarDG";
            this.consultarDG.Size = new System.Drawing.Size(161, 47);
            this.consultarDG.TabIndex = 2;
            this.consultarDG.Text = "CONSULTAR";
            this.consultarDG.UseVisualStyleBackColor = true;
            // 
            // fecharDG
            // 
            this.fecharDG.Location = new System.Drawing.Point(627, 391);
            this.fecharDG.Name = "fecharDG";
            this.fecharDG.Size = new System.Drawing.Size(161, 47);
            this.fecharDG.TabIndex = 3;
            this.fecharDG.Text = "FECHAR";
            this.fecharDG.UseVisualStyleBackColor = true;
            // 
            // segundoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fecharDG);
            this.Controls.Add(this.consultarDG);
            this.Controls.Add(this.primeiroDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "segundoFormulario";
            this.Text = "LISTAR DADOS";
            ((System.ComponentModel.ISupportInitialize)(this.primeiroDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView primeiroDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDG;
        private System.Windows.Forms.Button consultarDG;
        private System.Windows.Forms.Button fecharDG;
    }
}