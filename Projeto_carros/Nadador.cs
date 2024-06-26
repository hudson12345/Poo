﻿using System;
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
            double distancia;
            distancia = Convert.ToDouble(txtdistancia.Text);
            if (distancia < 800)
            {
                txtpremiacao.Text = "Seu  prêmio é de R$5.000";
            }
            else if (distancia >= 800 && distancia <= 1500)
            {
                txtpremiacao.Text = "Seu  prêmio é de R$10.000";
            }
            else if (distancia > 1500)
            {
                txtpremiacao.Text = "Seu prêmio é de R$15.000";
            }
            else 
            {
                txtpremiacao.Text = "Valores inválidos";
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tela1 = new Menu();
            tela1.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdistancia.Clear();
            txtpremiacao.Clear();
        }
    }
}
