namespace Projeto_carros
{
    partial class Salario
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
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblsalarioliq = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtsalliquido = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsalario = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(126, 100);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(95, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Digite o seu nome:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(126, 134);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(91, 13);
            this.lblsexo.TabIndex = 1;
            this.lblsexo.Text = "Digite o seu sexo:";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Location = new System.Drawing.Point(371, 100);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(96, 13);
            this.lblidade.TabIndex = 2;
            this.lblidade.Text = "Digite a sua Idade:";
            // 
            // lblsalarioliq
            // 
            this.lblsalarioliq.AutoSize = true;
            this.lblsalarioliq.Location = new System.Drawing.Point(126, 232);
            this.lblsalarioliq.Name = "lblsalarioliq";
            this.lblsalarioliq.Size = new System.Drawing.Size(75, 13);
            this.lblsalarioliq.TabIndex = 3;
            this.lblsalarioliq.Text = "Salário liquido:";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(371, 134);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(99, 13);
            this.lblsalario.TabIndex = 4;
            this.lblsalario.Text = "Digite o seu salário:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(223, 97);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 6;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(223, 131);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(100, 20);
            this.txtsexo.TabIndex = 7;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(473, 97);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 8;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(473, 131);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 9;
            // 
            // txtsalliquido
            // 
            this.txtsalliquido.Location = new System.Drawing.Point(207, 229);
            this.txtsalliquido.Name = "txtsalliquido";
            this.txtsalliquido.ReadOnly = true;
            this.txtsalliquido.Size = new System.Drawing.Size(242, 20);
            this.txtsalliquido.TabIndex = 10;
            this.txtsalliquido.TextChanged += new System.EventHandler(this.txtsalarioliq_TextChanged);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(374, 186);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsalario
            // 
            this.btnsalario.Location = new System.Drawing.Point(248, 186);
            this.btnsalario.Name = "btnsalario";
            this.btnsalario.Size = new System.Drawing.Size(75, 23);
            this.btnsalario.TabIndex = 12;
            this.btnsalario.Text = "Salário";
            this.btnsalario.UseVisualStyleBackColor = true;
            this.btnsalario.Click += new System.EventHandler(this.btnsalario_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(498, 227);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 13;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Salario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnsalario);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtsalliquido);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblsalarioliq);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblnome);
            this.Name = "Salario";
            this.Text = "Salario";
            this.Load += new System.EventHandler(this.Salario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblsalarioliq;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtsalliquido;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsalario;
        private System.Windows.Forms.Button btnvoltar;
    }
}