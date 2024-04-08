namespace Projeto_carros
{
    partial class Carros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblsalario = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblcomissao = new System.Windows.Forms.Label();
            this.lblncarros = new System.Windows.Forms.Label();
            this.lblvalcarros = new System.Windows.Forms.Label();
            this.lblsaltotal = new System.Windows.Forms.Label();
            this.lblsalmaisc = new System.Windows.Forms.Label();
            this.txtcomissao = new System.Windows.Forms.TextBox();
            this.txtncarro = new System.Windows.Forms.TextBox();
            this.txtvalcarros = new System.Windows.Forms.TextBox();
            this.txtsaltotal = new System.Windows.Forms.TextBox();
            this.txtsalmaisc = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(68, 60);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(98, 13);
            this.lblsalario.TabIndex = 0;
            this.lblsalario.Text = "Digite o salário fixo:";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(172, 57);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 1;
            // 
            // lblcomissao
            // 
            this.lblcomissao.AutoSize = true;
            this.lblcomissao.Location = new System.Drawing.Point(28, 106);
            this.lblcomissao.Name = "lblcomissao";
            this.lblcomissao.Size = new System.Drawing.Size(138, 13);
            this.lblcomissao.TabIndex = 2;
            this.lblcomissao.Text = "Digite a comissâo por carro:";
            // 
            // lblncarros
            // 
            this.lblncarros.AutoSize = true;
            this.lblncarros.Location = new System.Drawing.Point(35, 154);
            this.lblncarros.Name = "lblncarros";
            this.lblncarros.Size = new System.Drawing.Size(131, 13);
            this.lblncarros.TabIndex = 3;
            this.lblncarros.Text = "Digite o número de carros:";
            // 
            // lblvalcarros
            // 
            this.lblvalcarros.AutoSize = true;
            this.lblvalcarros.Location = new System.Drawing.Point(42, 198);
            this.lblvalcarros.Name = "lblvalcarros";
            this.lblvalcarros.Size = new System.Drawing.Size(124, 13);
            this.lblvalcarros.TabIndex = 4;
            this.lblvalcarros.Text = "Digite o valor dos carros:";
            // 
            // lblsaltotal
            // 
            this.lblsaltotal.AutoSize = true;
            this.lblsaltotal.Location = new System.Drawing.Point(333, 64);
            this.lblsaltotal.Name = "lblsaltotal";
            this.lblsaltotal.Size = new System.Drawing.Size(109, 13);
            this.lblsaltotal.TabIndex = 5;
            this.lblsaltotal.Text = "Seu salário total é de:";
            // 
            // lblsalmaisc
            // 
            this.lblsalmaisc.AutoSize = true;
            this.lblsalmaisc.Location = new System.Drawing.Point(333, 110);
            this.lblsalmaisc.Name = "lblsalmaisc";
            this.lblsalmaisc.Size = new System.Drawing.Size(126, 13);
            this.lblsalmaisc.TabIndex = 6;
            this.lblsalmaisc.Text = "Seu salário com 5% é de:";
            // 
            // txtcomissao
            // 
            this.txtcomissao.Location = new System.Drawing.Point(172, 103);
            this.txtcomissao.Name = "txtcomissao";
            this.txtcomissao.Size = new System.Drawing.Size(100, 20);
            this.txtcomissao.TabIndex = 7;
            // 
            // txtncarro
            // 
            this.txtncarro.Location = new System.Drawing.Point(172, 151);
            this.txtncarro.Name = "txtncarro";
            this.txtncarro.Size = new System.Drawing.Size(100, 20);
            this.txtncarro.TabIndex = 8;
            // 
            // txtvalcarros
            // 
            this.txtvalcarros.Location = new System.Drawing.Point(172, 195);
            this.txtvalcarros.Name = "txtvalcarros";
            this.txtvalcarros.Size = new System.Drawing.Size(100, 20);
            this.txtvalcarros.TabIndex = 9;
            // 
            // txtsaltotal
            // 
            this.txtsaltotal.Location = new System.Drawing.Point(448, 60);
            this.txtsaltotal.Name = "txtsaltotal";
            this.txtsaltotal.Size = new System.Drawing.Size(100, 20);
            this.txtsaltotal.TabIndex = 10;
            // 
            // txtsalmaisc
            // 
            this.txtsalmaisc.Location = new System.Drawing.Point(465, 107);
            this.txtsalmaisc.Name = "txtsalmaisc";
            this.txtsalmaisc.Size = new System.Drawing.Size(100, 20);
            this.txtsalmaisc.TabIndex = 11;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(384, 151);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(490, 171);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Voltar";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(384, 195);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 14;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtsalmaisc);
            this.Controls.Add(this.txtsaltotal);
            this.Controls.Add(this.txtvalcarros);
            this.Controls.Add(this.txtncarro);
            this.Controls.Add(this.txtcomissao);
            this.Controls.Add(this.lblsalmaisc);
            this.Controls.Add(this.lblsaltotal);
            this.Controls.Add(this.lblvalcarros);
            this.Controls.Add(this.lblncarros);
            this.Controls.Add(this.lblcomissao);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.lblsalario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblcomissao;
        private System.Windows.Forms.Label lblncarros;
        private System.Windows.Forms.Label lblvalcarros;
        private System.Windows.Forms.Label lblsaltotal;
        private System.Windows.Forms.Label lblsalmaisc;
        private System.Windows.Forms.TextBox txtcomissao;
        private System.Windows.Forms.TextBox txtncarro;
        private System.Windows.Forms.TextBox txtvalcarros;
        private System.Windows.Forms.TextBox txtsaltotal;
        private System.Windows.Forms.TextBox txtsalmaisc;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
    }
}

