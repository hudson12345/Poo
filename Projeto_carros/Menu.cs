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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projetoCarrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carros tela = new Carros();
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projetoNadadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nadador tela = new Nadador();
            tela.Show();
        }
    }
}
