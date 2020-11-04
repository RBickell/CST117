using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersie6__Dice_roll
{
    public partial class DiceGame : Form
    {
        int dice1= new int();
        int dice2= new int();
        int dice1val;
        int dice2val;
        int DiceSum;
        int count;
        Random rand;

        public DiceGame()
        {
            InitializeComponent();
        }

        private void DiceGame_Load(object sender, EventArgs e)
        {
            Dice1Label.Image = Excersie6__Dice_roll.Properties.Resources.dice0;
            Dice2Label.Image = Excersie6__Dice_roll.Properties.Resources.dice0;

        }
        private void RollDice()
        {
            rand = new Random();
            dice1 = rand.Next(1, 7);
            dice2 = rand.Next(1, 7);
            dice1val = dice1;
            dice2val = dice2;

            if (dice1 == 1)
                Dice1Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice1;
            else if (dice1 == 2)
                Dice1Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice2;
            else if (dice1 == 3)
                Dice1Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice3;
            else if (dice1 == 4)
                Dice1Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice4;
            else if (dice1 == 5)
                Dice1Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice5;
            else
                Dice1Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice6;

            if (dice2 == 1)
                Dice2Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice1;
            else if (dice2 == 2)
                Dice2Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice2;
            else if (dice2 == 3)
                Dice2Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice3;
            else if (dice2 == 4)
                Dice2Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice4;
            else if (dice2 == 5)
                Dice2Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice5;
            else
                Dice2Label.Image = Excersie6__Dice_roll.Properties.Resources.Dice6;

        }
        private void RollButton_Click(object sender, EventArgs e)
        {
            count = 0;
            DiceSum = 0;
            for (count = 0; DiceSum != 2; count++)
            {
                RollDice();
                DiceSum = dice1val + dice2val;
            }
            
            MessageTextBox.Text= "It took " + count + " rolls to get snake eyes.";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Dice1Label.Image = Excersie6__Dice_roll.Properties.Resources.dice0;
            Dice2Label.Image = Excersie6__Dice_roll.Properties.Resources.dice0;
        }
    }
}
