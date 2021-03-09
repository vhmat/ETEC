
namespace AplWFAExercicio1
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
            this.resultado = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro valor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado.Location = new System.Drawing.Point(151, 111);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 2;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(151, 56);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(100, 20);
            this.valor.TabIndex = 3;
            this.valor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(15, 170);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(145, 32);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "&Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(200, 170);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(145, 32);
            this.limpar.TabIndex = 8;
            this.limpar.Text = "&Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(375, 170);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(145, 32);
            this.sair.TabIndex = 9;
            this.sair.Text = "&Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label label2;
    }
}

