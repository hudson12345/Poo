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
            double salario, idade, salarioliquido;
            string nome, sexo;
            salario = Convert.ToDouble(txtsalario.Text);
            sexo = Convert.ToString(txtsexo.Text);
            idade = Convert.ToDouble(txtidade.Text);
            nome = Convert.ToString(txtnome.Text);

            if (sexo == "M" && idade >= 30)
            {
                salarioliquido = salario + 100;
                txtsalliquido.Text = nome + ", seu salário líquido é de:" + salarioliquido;
            }
            else if (sexo == "F" && idade < 30)
            {
                salarioliquido = salario + 50;
                txtsalliquido.Text = nome + ", seu salário líquido é de:" + salarioliquido;
            }
            else if (sexo == "F" && idade >= 30)
            {
                salarioliquido = salario + 200;
                txtsalliquido.Text = nome + ", seu salário líquido é de:" + salarioliquido;
            }
            else if (sexo == "M" && idade < 30)
            {
                salarioliquido = salario + 80;
                txtsalliquido.Text = nome + ", seu salário líquido é de:" + salarioliquido;
            }
            else {
                txtsalliquido.Text = "Valores inválidos";
            }
        }

        private void txtsalarioliq_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsalliquido.Clear();
            txtsalario.Clear();
            txtnome.Clear();
            txtidade.Clear();
            txtsexo.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tela1 = new Menu();
            tela1.Show();
        }

        private void Salario_Load(object sender, EventArgs e)
        {

        }
    }
}
