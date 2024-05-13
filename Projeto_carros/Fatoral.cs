using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_carros
{
    public partial class Fatoral : Form
    {
        public Fatoral()
        {
            InitializeComponent();
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            double num, i, x;
            
            num = Convert.ToDouble(txtnumero.Text);
            i = num- 1;
            x = num * i;
            txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", num, " x ", i, " = ", x.ToString());
            i--;

            while (i > 0)
            {
                
                x = x * i;
                
                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", x / i, " x ", i, " = ", x.ToString());
                i--;
                
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tela1 = new Menu();
            tela1.Show();
        }

        private void btndoW_Click(object sender, EventArgs e)
        {
            double num, x, i;

            num = Convert.ToDouble(txtnumero.Text);
            i = num - 1;
            x = num * i;
            txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", num, " x ", i, " = ", x.ToString());
            i--;

            do
            {
                x = x * i;

                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", x / i, " x ", i, " = ", x.ToString());
                i--;
            } while (i > 0);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            double num, i, x;

            num = Convert.ToDouble(txtnumero.Text);
            i = num - 1;
            x = num * i;
            txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", num, " x ", i, " = ", x.ToString());


            for(i = num - 2; i > 0; i--)
            {
                x = x * i;

                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", x / i, " x ", i, " = ", x.ToString());
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtresultado.Clear();
            txtnumero.Focus();
        }
    }
}
