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
            i = num - 1;
            
            while (i > 0)
            {
                x = num * i;
                
                txtresultado.Text = String.Concat(txtresultado.Text, "\r\n", num, "x", i, "=", x.ToString());
                i--;
                
            }
        }
    }
}
