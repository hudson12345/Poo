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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projetoCarrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 tela = new Form1();
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
