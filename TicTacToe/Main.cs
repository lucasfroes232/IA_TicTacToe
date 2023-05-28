using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Main : Form
    {
        private Tabuleiro tabuleiro= new Tabuleiro();
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            Creditos devs = new Creditos();
            this.Hide();
            devs.ShowDialog();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Multiplayer game = new Multiplayer();
            this.Hide();
            game.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IaInteligente game = new IaInteligente();
            this.Hide();
            game.ShowDialog();
        }
    }
}
