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
    public partial class Multiplayer : Form
    {
        Tabuleiro tab;

        public Multiplayer()
        {
            InitializeComponent();

            tab = new Tabuleiro();
            tab.rst(ref pnlHashtag);
            
        }
        private void btnVoltaPrinc_Click(object sender, EventArgs e)
        {
            Main back = new Main();
            this.Hide();
            back.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Multiplayer_Load(object sender, EventArgs e)
        {

        }
    }
}
