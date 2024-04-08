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
    public partial class Carros : Form
    {
        public Carros()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double salfixo, valcarros, ncarro, saltotal, salmaisc, comissao;
            salfixo = Convert.ToDouble(txtsalario.Text);
            valcarros = Convert.ToDouble(txtvalcarros.Text);
            ncarro = Convert.ToDouble(txtncarro.Text);
            comissao = Convert.ToDouble(txtcomissao.Text);
            saltotal = salfixo + ncarro + comissao;
            salmaisc =  valcarros * 0.05 + comissao + salfixo;
            txtsaltotal.Text = saltotal.ToString();
            txtsalmaisc.Text = salmaisc.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcomissao.Clear();
            txtvalcarros.Clear();
            txtsalario.Clear();
            txtncarro.Clear();
            txtsalmaisc.Clear();
            txtsaltotal.Clear();

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tela1 = new Menu();
            tela1.Show();
        }
    }
}
