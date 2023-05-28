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
    public partial class IaInteligente : Form
    {
        MiniMax jogo;
        public IaInteligente()
        {
            InitializeComponent();
            jogo = new MiniMax();
            jogo.rst(ref pnlMini);
            
        }

        private void btnVoltaPrinc_Click(object sender, EventArgs e)
        {
            Main back = new Main();
            this.Hide();
            back.ShowDialog();
        }
    }
}
