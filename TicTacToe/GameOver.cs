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
    public partial class GameOver : Form
    {
        public GameOver(string vencedor)
        {
            InitializeComponent();
            lbWinner.Text = vencedor;
        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltaPrinc_Click(object sender, EventArgs e)
        {
            
            Application.Restart();
           
        }
    }
}
