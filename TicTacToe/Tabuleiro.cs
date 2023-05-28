using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class Tabuleiro
    {
        public System.Windows.Forms.Button[,] tabuleiro = new System.Windows.Forms.Button[4, 4];
        public string jogador = "O"; // altera a cada click do jogador

        public Tabuleiro()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = new System.Windows.Forms.Button();
                }
            }

        }//cria os botoes  
        public void rst(ref Panel panel)
        {
            int x1, x2, x3;
            x1 = 12; x2 = 12; x3 = 12;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j].Width = 136;
                    tabuleiro[i, j].Height = 125;
                    tabuleiro[i, j].BackColor = System.Drawing.Color.White;
                    tabuleiro[i, j].ForeColor = System.Drawing.Color.Black;
                    tabuleiro[i, j].Font = new Font("Commodore 64 Pixeled", 20, FontStyle.Bold, GraphicsUnit.Point);
                    if (i == 0)
                    {//linha 1
                        tabuleiro[i, j].Location = new System.Drawing.Point(x1, 54);
                        x1 += 141;

                    }
                    else if (i == 1)
                    {//linha 2
                        tabuleiro[i, j].Location = new System.Drawing.Point(x2, 185);
                        x2 += 141;
                    }
                    else
                    {//linha 3
                        tabuleiro[i, j].Location = new System.Drawing.Point(x3, 316);
                        x3 += 141;
                    }
                    tabuleiro[i, j].Click += new System.EventHandler(ClickButton);
                    panel.Controls.Add(tabuleiro[i, j]);
                }
            }
        }//renderiza as lacunas do game
        public void jogadorA(ref string j)
        {
            if (j == "X")
            {
                j = "O";
            }
            else
            {
                j = "X";
            }
        }//ficar trocando entre X e O
        public void ClickButton(Object sender, System.EventArgs e)
        {
            jogadorA(ref jogador);
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {
                btn.Text = jogador;
                if (vencedor(jogador) == 0)
                {
                    GameOver gm = new GameOver("   A tie    ");
                    gm.Show();
                }
                else if(vencedor(jogador)!=-100) {
                    GameOver gm = new GameOver("Winner: "+jogador);
                    gm.Show();
                }
            }
        }
        public int vencedor(string jogador)
        {
            if (horizontal(jogador) || vertical(jogador) || diagonal(jogador) || diagonalInversa(jogador))
            {
                if(jogador == "X")
                {
                    return 1;
                }
                else { return -1; }
            }
            else
            {
                bool acabou = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tabuleiro[i, j].Text.Equals(""))
                        {
                            acabou = false;
                        }
                    }
                }
                if (acabou) { return 0; }
                else { return -100; };
            }
        }
        //funcao para mudar o texto dos botoes
        public bool horizontal(string jogador)
        {
            for(int i = 0; i < 3;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (tabuleiro[i, j].Text != jogador)
                    {
                        break;//vai para proxima linha
                    }
                    if (j == 2)//se varreu toda a linha e chegou no final tudo e igual
                    {
                        return true;
                    }
                }    
            }
            return false;
        } //verificar se fechou alguma linha
        public bool vertical(string jogador)
        {
          for(int i = 0; i < 3; i++)
            {
                for (int j =0;j<3; j++)
                {
                    if (tabuleiro[j,i].Text != jogador)
                    {
                        break;
                    }
                    if (j == 2)//se chegou aqui e pq tudo e igual
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //verificar se fechou alguma coluna
        public bool diagonal(string jogador)
        {
          for(int i = 0; i < 3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if(i==j)
                    {
                        if (tabuleiro[i,j].Text != jogador)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }//verifica se fechou alguma diagonal
        public bool diagonalInversa(string jogador)
        {
            if (tabuleiro[0,2].Text == tabuleiro[2,0].Text && tabuleiro[0, 2].Text == jogador && tabuleiro[1,1].Text == jogador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
