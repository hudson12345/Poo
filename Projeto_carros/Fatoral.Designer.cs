namespace Projeto_carros
{
    partial class Fatoral
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
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndoW = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnwhile
            // 
            this.btnwhile.Location = new System.Drawing.Point(132, 323);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(75, 23);
            this.btnwhile.TabIndex = 0;
            this.btnwhile.Text = "While";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndoW
            // 
            this.btndoW.Location = new System.Drawing.Point(230, 323);
            this.btndoW.Name = "btndoW";
            this.btndoW.Size = new System.Drawing.Size(75, 23);
            this.btndoW.TabIndex = 1;
            this.btndoW.Text = "Do...While";
            this.btndoW.UseVisualStyleBackColor = true;
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(334, 323);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(75, 23);
            this.btnfor.TabIndex = 2;
            this.btnfor.Text = "For";
            this.btnfor.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(440, 323);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(550, 323);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(165, 70);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(92, 13);
            this.lblnumero.TabIndex = 5;
            this.lblnumero.Text = "Digite um número:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(168, 138);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(58, 13);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "Resultado:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(259, 70);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 7;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(259, 131);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresultado.Size = new System.Drawing.Size(100, 79);
            this.txtresultado.TabIndex = 8;
            // 
            // Fatoral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndoW);
            this.Controls.Add(this.btnwhile);
            this.Name = "Fatoral";
            this.Text = "Fatoral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndoW;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtresultado;
    }
}