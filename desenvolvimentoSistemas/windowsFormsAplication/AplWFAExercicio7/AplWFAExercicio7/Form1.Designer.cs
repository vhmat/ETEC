
namespace AplWFAExercicio7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qtdCarrosFunc = new System.Windows.Forms.TextBox();
            this.totalVendidoFunc = new System.Windows.Forms.TextBox();
            this.salarioFixo = new System.Windows.Forms.TextBox();
            this.qtdRecebidaCarro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.salarioFinal = new System.Windows.Forms.TextBox();
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
            // salarioFinal
            // 
            this.salarioFinal.Location = new System.Drawing.Point(328, 182);
            this.salarioFinal.Name = "salarioFinal";
            this.salarioFinal.Size = new System.Drawing.Size(100, 20);
            this.salarioFinal.TabIndex = 9;
            this.salarioFinal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salarioFinal);
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
        private System.Windows.Forms.TextBox salarioFinal;
    }
}

