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
    public partial class Salario : Form
    {
        public Salario()
        {
            InitializeComponent();
        }

        private void btnsalario_Click(object sender, EventArgs e)
        {
            double salario, sexo, idade, nome, salarioliquido;
            salario = Convert.ToDouble(txtsalario.Text);
            sexo = Convert.ToDouble(txtsexo.Text);
            idade = Convert.ToDouble(txtidade.Text);
            nome = Convert.ToDouble(txtnome.Text);
            
        }
    }
}
