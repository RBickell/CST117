using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int player = 2;
        public int turns = 0;
        public int x1 = 0;
        public int o2 = 0;
        public int Dg = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            TbXWon.Text = x1.ToString();
            TBOWon.Text = o2.ToString();
            TbDrawGame.Text = Dg.ToString();
        }

        private void NewGame()
        {
            player = 2;
            turns = 0;
            Btn00.Text = "";
            Btn01.Text = "";
            Btn02.Text = "";
            Btn10.Text = "";
            Btn11.Text = "";
            Btn12.Text = "";
            Btn20.Text = "";
            Btn21.Text = "";
            Btn22.Text = "";
            TbXWon.Text = x1.ToString();
            TBOWon.Text = o2.ToString();
            TbDrawGame.Text = Dg.ToString();
        }

        private bool CheckDrawGame()
        {
            if ((turns == 9) && CheckWinner() == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckWinner()
        {
            if ((Btn00.Text == Btn01.Text) && (Btn01.Text == Btn02.Text) && Btn00.Text != "")
                return true;
            else if ((Btn10.Text == Btn11.Text) && (Btn11.Text == Btn12.Text) && Btn10.Text != "")
                return true;
            else if ((Btn20.Text == Btn21.Text) && (Btn21.Text == Btn22.Text) && Btn20.Text != "")
                return true;
            
            if ((Btn00.Text == Btn10.Text) && (Btn10.Text == Btn20.Text) && Btn00.Text != "")
                return true;
            else if ((Btn01.Text == Btn11.Text) && (Btn11.Text == Btn21.Text) && Btn01.Text != "")
                return true;
            else if ((Btn02.Text == Btn12.Text) && (Btn12.Text == Btn22.Text) && Btn02.Text != "")
                return true;

            if ((Btn00.Text == Btn11.Text) && (Btn11.Text == Btn22.Text) && Btn00.Text != "")
                return true;
            else if ((Btn20.Text == Btn11.Text) && (Btn11.Text == Btn02.Text) && Btn20.Text != "")
                return true;
            else
                return false;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else 
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }

                if (CheckDrawGame() == true)
                {
                    MessageBox.Show("Tie Game");
                    Dg++;
                    NewGame();
                }

                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X won! Winner, Winner Chicken Dinner!");
                        x1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O won! Winner, Winner Chicken Dinner!");
                        o2++;
                        NewGame();
                    }
                }
            }
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            x1 = o2 = Dg = 0;
            NewGame();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
