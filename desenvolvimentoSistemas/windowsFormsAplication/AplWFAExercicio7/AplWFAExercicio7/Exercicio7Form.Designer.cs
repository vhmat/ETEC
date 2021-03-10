
namespace AplWFAExercicio7
{
    partial class Exercicio7Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qtdCarrosFunc = new System.Windows.Forms.TextBox();
            this.totalVendidoFunc = new System.Windows.Forms.TextBox();
            this.salarioFixo = new System.Windows.Forms.TextBox();
            this.qtdRecebidaCarro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.botaoCalcular = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite aqui quantos carros o funcionário vendeu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite aqui o valor total das vendas realizadas pelo funcionário: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite aqui o salário fixo do funcionário: ";
            // 
            // qtdCarrosFunc
            // 
            this.qtdCarrosFunc.Location = new System.Drawing.Point(328, 16);
            this.qtdCarrosFunc.Name = "qtdCarrosFunc";
            this.qtdCarrosFunc.Size = new System.Drawing.Size(100, 20);
            this.qtdCarrosFunc.TabIndex = 3;
            this.qtdCarrosFunc.TextChanged += new System.EventHandler(this.qtdCarrosFunc_TextChanged);
            // 
            // totalVendidoFunc
            // 
            this.totalVendidoFunc.Location = new System.Drawing.Point(328, 53);
            this.totalVendidoFunc.Name = "totalVendidoFunc";
            this.totalVendidoFunc.Size = new System.Drawing.Size(100, 20);
            this.totalVendidoFunc.TabIndex = 4;
            this.totalVendidoFunc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // salarioFixo
            // 
            this.salarioFixo.Location = new System.Drawing.Point(328, 136);
            this.salarioFixo.Name = "salarioFixo";
            this.salarioFixo.Size = new System.Drawing.Size(100, 20);
            this.salarioFixo.TabIndex = 5;
            // 
            // qtdRecebidaCarro
            // 
            this.qtdRecebidaCarro.Location = new System.Drawing.Point(328, 93);
            this.qtdRecebidaCarro.Name = "qtdRecebidaCarro";
            this.qtdRecebidaCarro.Size = new System.Drawing.Size(100, 20);
            this.qtdRecebidaCarro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite aqui o valor que o funcionário recebe por carro vendido:";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(12, 182);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(186, 13);
            this.labelSalario.TabIndex = 8;
            this.labelSalario.Text = "O salário final do funcionário é igual a:";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(328, 182);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 9;
            this.resultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.botaoCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoCalcular.Location = new System.Drawing.Point(15, 281);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(111, 46);
            this.botaoCalcular.TabIndex = 10;
            this.botaoCalcular.Text = "&Calcular";
            this.botaoCalcular.UseVisualStyleBackColor = false;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // botaoSair
            // 
            this.botaoSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.botaoSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoSair.Location = new System.Drawing.Point(317, 281);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(111, 46);
            this.botaoSair.TabIndex = 11;
            this.botaoSair.Text = "&Sair";
            this.botaoSair.UseVisualStyleBackColor = false;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.botaoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoLimpar.Location = new System.Drawing.Point(165, 281);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(111, 46);
            this.botaoLimpar.TabIndex = 12;
            this.botaoLimpar.Text = "&Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = false;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qtdRecebidaCarro);
            this.Controls.Add(this.salarioFixo);
            this.Controls.Add(this.totalVendidoFunc);
            this.Controls.Add(this.qtdCarrosFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtdCarrosFunc;
        private System.Windows.Forms.TextBox totalVendidoFunc;
        private System.Windows.Forms.TextBox salarioFixo;
        private System.Windows.Forms.TextBox qtdRecebidaCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button botaoCalcular;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoLimpar;
    }
}

