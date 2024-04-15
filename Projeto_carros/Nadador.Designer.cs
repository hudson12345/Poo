namespace Projeto_carros
{
    partial class Nadador
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
            this.lblnadador = new System.Windows.Forms.Label();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.txtpremiacao = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnpremiacao = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnadador
            // 
            this.lblnadador.AutoSize = true;
            this.lblnadador.Location = new System.Drawing.Point(129, 80);
            this.lblnadador.Name = "lblnadador";
            this.lblnadador.Size = new System.Drawing.Size(285, 13);
            this.lblnadador.TabIndex = 0;
            this.lblnadador.Text = "Qual a distância percorrida foram percorridos pelo nadador:";
            // 
            // txtdistancia
            // 
            this.txtdistancia.Location = new System.Drawing.Point(435, 77);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(100, 20);
            this.txtdistancia.TabIndex = 1;
            // 
            // txtpremiacao
            // 
            this.txtpremiacao.Location = new System.Drawing.Point(435, 136);
            this.txtpremiacao.Name = "txtpremiacao";
            this.txtpremiacao.ReadOnly = true;
            this.txtpremiacao.Size = new System.Drawing.Size(148, 20);
            this.txtpremiacao.TabIndex = 2;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(250, 143);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(118, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "O prémio do nadador é:";
            // 
            // btnpremiacao
            // 
            this.btnpremiacao.Location = new System.Drawing.Point(293, 224);
            this.btnpremiacao.Name = "btnpremiacao";
            this.btnpremiacao.Size = new System.Drawing.Size(75, 23);
            this.btnpremiacao.TabIndex = 4;
            this.btnpremiacao.Text = "Premiação";
            this.btnpremiacao.UseVisualStyleBackColor = true;
            this.btnpremiacao.Click += new System.EventHandler(this.btnpremiacao_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(362, 279);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(435, 224);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // Nadador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnpremiacao);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtpremiacao);
            this.Controls.Add(this.txtdistancia);
            this.Controls.Add(this.lblnadador);
            this.Name = "Nadador";
            this.Text = "Forms3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnadador;
        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.TextBox txtpremiacao;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnpremiacao;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}