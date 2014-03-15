﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerudoGUI
{
    public partial class AdminForm : Form
    {
        Logic lg;

        public AdminForm()
        {
            InitializeComponent();
            rollDices();
        }

        public void rollDices() {
            Logic lg = new Logic(this);
            lg.rollDices();
        }

        public void showPictures(int[] dices1, int[] dices2, int[] dices3, int[] dices4, int[] dices5, int[] dices6) {

            Console.WriteLine(dices1[0] + " - " + dices1[1] + " - " + dices1[2] + " - " + dices1[3] + " - " + dices1[4]);
                        
            Bitmap[] images = {Properties.Resources.Perudo1, Properties.Resources.Perudo2, Properties.Resources.Perudo3, Properties.Resources.Perudo4, Properties.Resources.Perudo5, Properties.Resources.Perudo6};
            PictureBox[] p1boxes = { OverviewPlayer1Dice1, OverviewPlayer1Dice2, OverviewPlayer1Dice3, OverviewPlayer1Dice4, OverviewPlayer1Dice5 };
            PictureBox[] p2boxes = { OverviewPlayer2Dice1, OverviewPlayer2Dice2, OverviewPlayer2Dice3, OverviewPlayer2Dice4, OverviewPlayer2Dice5 };
            PictureBox[] p3boxes = { OverviewPlayer3Dice1, OverviewPlayer3Dice2, OverviewPlayer3Dice3, OverviewPlayer3Dice4, OverviewPlayer3Dice5 };
            PictureBox[] p4boxes = { OverviewPlayer4Dice1, OverviewPlayer4Dice2, OverviewPlayer4Dice3, OverviewPlayer4Dice4, OverviewPlayer4Dice5 };
            PictureBox[] p5boxes = { OverviewPlayer5Dice1, OverviewPlayer5Dice2, OverviewPlayer5Dice3, OverviewPlayer5Dice4, OverviewPlayer5Dice5 };
            PictureBox[] p6boxes = { OverviewPlayer6Dice1, OverviewPlayer6Dice2, OverviewPlayer6Dice3, OverviewPlayer6Dice4, OverviewPlayer6Dice5 };

            for (int i = 0; i < 5; i++){
                p1boxes[i].Image = images[dices1[i] - 1];
                p2boxes[i].Image = images[dices2[i] - 1];
                p3boxes[i].Image = images[dices3[i] - 1];
                p4boxes[i].Image = images[dices4[i] - 1];
                p5boxes[i].Image = images[dices5[i] - 1];
                p6boxes[i].Image = images[dices6[i] - 1];
            }                               
        }

        private void overviewRollDiceButton_Click(object sender, EventArgs e)
        {
            rollDices();
           
        }
    }
}