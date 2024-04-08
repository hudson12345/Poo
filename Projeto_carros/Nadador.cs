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
    public partial class Nadador : Form
    {
        public Nadador()
        {
            InitializeComponent();
        }

        private void btnpremiacao_Click(object sender, EventArgs e)
        {
            double distancia, premiacao;
            distancia = Convert.ToDouble(txtdistancia.Text);
            if (distancia < 800) { 
            premiacao = 5000
            }
        }
    }
}
