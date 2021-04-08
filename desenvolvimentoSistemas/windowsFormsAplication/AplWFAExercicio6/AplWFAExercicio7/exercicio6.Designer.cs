
namespace AplWFAExercicio7
{
    partial class primeiroForm
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
            this.custoFabrica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valorFinal = new System.Windows.Forms.Label();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor do custo de fábrica: ";
            // 
            // custoFabrica
            // 
            this.custoFabrica.Location = new System.Drawing.Point(187, 6);
            this.custoFabrica.Name = "custoFabrica";
            this.custoFabrica.Size = new System.Drawing.Size(100, 20);
            this.custoFabrica.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor final: ";
            // 
            // valorFinal
            // 
            this.valorFinal.BackColor = System.Drawing.Color.White;
            this.valorFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorFinal.Location = new System.Drawing.Point(187, 38);
            this.valorFinal.Name = "valorFinal";
            this.valorFinal.Size = new System.Drawing.Size(100, 20);
            this.valorFinal.TabIndex = 3;
            this.valorFinal.Click += new System.EventHandler(this.valorFinal_Click);
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.botaoCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoCalcular.Location = new System.Drawing.Point(15, 85);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(75, 23);
            this.botaoCalcular.TabIndex = 4;
            this.botaoCalcular.Text = "&Calcular";
            this.botaoCalcular.UseVisualStyleBackColor = false;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // botaoSair
            // 
            this.botaoSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botaoSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoSair.Location = new System.Drawing.Point(212, 85);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(75, 23);
            this.botaoSair.TabIndex = 5;
            this.botaoSair.Text = "&Sair";
            this.botaoSair.UseVisualStyleBackColor = false;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.botaoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoLimpar.Location = new System.Drawing.Point(115, 85);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 23);
            this.botaoLimpar.TabIndex = 6;
            this.botaoLimpar.Text = "&Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = false;
            this.botaoLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // primeiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 121);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.valorFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custoFabrica);
            this.Controls.Add(this.label1);
            this.Name = "primeiroForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custoFabrica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valorFinal;
        private System.Windows.Forms.Button botaoCalcular;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoLimpar;
    }
}

