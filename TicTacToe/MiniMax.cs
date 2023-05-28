using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class MiniMax
    {
        public System.Windows.Forms.Button[,] tabuleiro = new System.Windows.Forms.Button[3, 3];
        public string jogador = "O";
        public MiniMax()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = new System.Windows.Forms.Button();
                }
            }
            

        }
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
                        if(j == 0) { 
                        }
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
            

        }//renderiza os botoes na tela
         //colocar funcao para os botoes

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
        }//alterar valor do jogador (X/O)
        public int vencedor()
        {
            if (horizontal("X") || vertical("X") || diagonal("X") || diagonalInversa("X"))
            {
                return -1;
            }else if(horizontal("O") || vertical("O") || diagonal("O") || diagonalInversa("O"))
            {
                return 1;
            }
            else
            {
                bool acabou = true;
                for (int i=0; i < 3; i++)
                {
                    for(int j=0; j < 3; j++)
                    {
                        if (tabuleiro[i, j].Text.Equals(""))
                        {
                            acabou = false;
                        }
                    }
                }
                if(acabou) { return 0; }
                else { return -100; };
            }
        }//retorna 1 se X,-1 se O, -100 E

        /*++++++CHECAR VITORIA ++++++++*/
        public bool horizontal(string jogador)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
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
        }
        public bool vertical(string jogador)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[j, i].Text != jogador)
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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        if (tabuleiro[i, j].Text != jogador)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public bool diagonalInversa(string jogador)
        {
            if (tabuleiro[0, 2].Text == tabuleiro[2, 0].Text && tabuleiro[0, 2].Text == jogador && tabuleiro[1, 1].Text == jogador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*++++++++++++++++++++++++++++*/

        /*Metodos para o jogo funca caralho*/
        public void ClickButton(Object sender, System.EventArgs e)
        {

            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {
                btn.Text = "X";
            }
        
                Monstro();
            
        }

        public void Monstro()
        {

            int maiorScore = -1000;//guardar o valor da melhor jogada
            int[] jogada = new int[2];//guardar a pos da jogada

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[i, j].Text.Equals(""))//se tiver vazio coloca X
                    {
                        tabuleiro[i, j].Text = "O";

                        int score = minimax(tabuleiro, 0,false);// jogo,profundidade da arvore, proximo a jogar(T = X,F = O)
                        tabuleiro[i, j].Text = "";
                        if (score > maiorScore)//se a jogada for 1(melhor para o X) joga
                        {                      //como nao estamos tratando a profundidade pega a PRIMEIRA arvore com possibilidade de vitoria
                            maiorScore = score;
                            jogada[0] = i; jogada[1] = j;
                        }
                    }
                }
            }
            tabuleiro[jogada[0], jogada[1]].Text = "O";
            if (vencedor() == 1)
            {
                GameOver f = new GameOver("Winner: O");
                f.Show();

            }
            else if (vencedor() == -1)
            {
                GameOver f = new GameOver("Winner: X");
                f.Show();
               
            }else if (vencedor() == 0)
            {
                GameOver f = new GameOver("  A tie  ");
                f.Show();
            }

        }

        public int minimax(System.Windows.Forms.Button[,] tabuleiro, int profundidade, bool isMaximizing)
        {

            int resultado = vencedor();//se teve algum vencedor com a jogada,retorna o valor 
            if (resultado != -100)
            {
                //MessageBox.Show(resultado.ToString());
                return resultado;
            }
            if (isMaximizing)//recursao com a proxima jogada sendo de O(queremos o maior valor)
            {
                int maiorScore = -1000;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tabuleiro[i, j].Text.Equals(""))
                        {
                            tabuleiro[i, j].Text = "O";
                            int score = minimax(tabuleiro, profundidade + 1, false);
                            tabuleiro[i, j].Text = "";
                            if (score > maiorScore)
                            {
                                maiorScore = score;
                            }
                        }
                    }
                }
                return maiorScore;
            }
            else//recursao com a proxima jogada sendo de X(queremos o menor valor)
            {
                int maiorScore = 1000;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        if (tabuleiro[i, j].Text.Equals(""))
                        {
                            tabuleiro[i, j].Text = "X";
                            int score = minimax(tabuleiro, profundidade + 1, true);
                            tabuleiro[i, j].Text = "";
                            if (maiorScore > score)
                            {
                                maiorScore = score;
                            }
                        }
                    }
                }
                return maiorScore;
            }

        }

    }
}


