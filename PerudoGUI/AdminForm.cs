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
        static string lastBetBy;
        static string lastBet;
        enum currentPlayer {Player1, Player2, Player3, Player4, Player5, Player6};
        enum steenType { pacos, tweeen, drieen, vieren, vijfen, zessen };

        int pacos;  //Number of Pacos
        int tweeen; //Number of Twos
        int drieen; //Number of Threes
        int vieren; //Number of Fours
        int vijfen; //Number of Fives
        int zessen; //Number of Sixes

        public AdminForm()
        {
            lg = new Logic(this); 
            InitializeComponent();
            rollDices();
        }

        public void rollDices() {
            lg.rollDices();             //Roll the dices
        }

        public void showPictures(int[] dices1, int[] dices2, int[] dices3, int[] dices4, int[] dices5, int[] dices6)
        {
            pacos = 0;
            tweeen = 0;
            drieen = 0;
            vieren = 0;
            vijfen = 0;
            zessen = 0;

            int[][] opperArray = { dices1, dices2, dices3, dices4, dices5, dices6 };

            Bitmap[] images = { Properties.Resources.Perudo1, Properties.Resources.Perudo2, Properties.Resources.Perudo3, Properties.Resources.Perudo4, Properties.Resources.Perudo5, Properties.Resources.Perudo6 };
            
            //Pictureboxes of the admin overview
            PictureBox[] p1Overviewboxes = { OverviewPlayer1Dice1, OverviewPlayer1Dice2, OverviewPlayer1Dice3, OverviewPlayer1Dice4, OverviewPlayer1Dice5 };
            PictureBox[] p2Overviewboxes = { OverviewPlayer2Dice1, OverviewPlayer2Dice2, OverviewPlayer2Dice3, OverviewPlayer2Dice4, OverviewPlayer2Dice5 };
            PictureBox[] p3Overviewboxes = { OverviewPlayer3Dice1, OverviewPlayer3Dice2, OverviewPlayer3Dice3, OverviewPlayer3Dice4, OverviewPlayer3Dice5 };
            PictureBox[] p4Overviewboxes = { OverviewPlayer4Dice1, OverviewPlayer4Dice2, OverviewPlayer4Dice3, OverviewPlayer4Dice4, OverviewPlayer4Dice5 };
            PictureBox[] p5Overviewboxes = { OverviewPlayer5Dice1, OverviewPlayer5Dice2, OverviewPlayer5Dice3, OverviewPlayer5Dice4, OverviewPlayer5Dice5 };
            PictureBox[] p6Overviewboxes = { OverviewPlayer6Dice1, OverviewPlayer6Dice2, OverviewPlayer6Dice3, OverviewPlayer6Dice4, OverviewPlayer6Dice5 };

            //Pictureboxes of the player views
            PictureBox[] p1boxes = { player1Dice1, player1Dice2, player1Dice3, player1Dice4, player1Dice5 };
            PictureBox[] p2boxes = { player2Dice1, player2Dice2, player2Dice3, player2Dice4, player2Dice5 };
            PictureBox[] p3boxes = { player3Dice1, player3Dice2, player3Dice3, player3Dice4, player3Dice5 };
            PictureBox[] p4boxes = { player4Dice1, player4Dice2, player4Dice3, player4Dice4, player4Dice5 };
            PictureBox[] p5boxes = { player5Dice1, player5Dice2, player5Dice3, player5Dice4, player5Dice5 };
            PictureBox[] p6boxes = { player6Dice1, player6Dice2, player6Dice3, player6Dice4, player6Dice5 };

            //Loop through all the dices of each player and assign them to a picturebox
            for (int i = 0; i < 5; i++)
            {
                p1Overviewboxes[i].Image = images[dices1[i] - 1];
                p2Overviewboxes[i].Image = images[dices2[i] - 1];
                p3Overviewboxes[i].Image = images[dices3[i] - 1];
                p4Overviewboxes[i].Image = images[dices4[i] - 1];
                p5Overviewboxes[i].Image = images[dices5[i] - 1];
                p6Overviewboxes[i].Image = images[dices6[i] - 1];

                p1boxes[i].Image = images[dices1[i] - 1];
                p2boxes[i].Image = images[dices2[i] - 1];
                p3boxes[i].Image = images[dices3[i] - 1];
                p4boxes[i].Image = images[dices4[i] - 1];
                p5boxes[i].Image = images[dices5[i] - 1];
                p6boxes[i].Image = images[dices6[i] - 1];
            }


            for (int a = 0; a < 6; a++) //Loop through all dices and count them
            {
                for (int i = 0; i < 5; i++)
                {
                    switch (opperArray[a][i]) { 
                        case 1:
                            pacos += 1;
                            break;
                        case 2:
                            tweeen += 1;
                            break;
                        case 3:
                            drieen += 1;
                            break;
                        case 4:
                            vieren += 1;
                            break;
                        case 5:
                            vijfen += 1;
                            break;
                        case 6:
                            zessen += 1;
                            break;
                    }
                }
            }

            //Calculate the amount of each dice
            overviewAantalPacosText.Text = pacos.ToString();
            overviewAantalTweeenText.Text = tweeen.ToString();
            overviewAantalDrieeenText.Text = drieen.ToString();
            overviewAantalVierenText.Text = vieren.ToString();
            overviewAantalVijfenText.Text = vijfen.ToString();
            overviewAantalZessenText.Text = zessen.ToString();

            //Calculate the amount of each dice + pacos
            overviewAantalPacosPlusPacosText.Text = pacos.ToString();
            overviewAantalTweeenPlusPacosText.Text = (tweeen + pacos).ToString();
            overviewAantalDrieeenPlusPacosText.Text = (drieen + pacos).ToString();
            overviewAantalVierenPlusPacosText.Text = (vieren + pacos).ToString();
            overviewAantalVijfenPlusPacosText.Text = (vijfen + pacos).ToString();
            overviewAantalZessenPlusPacosText.Text = (zessen + pacos).ToString();

            overviewLastBetByText.Text = "Player 1";
            overviewLastBetAantalText.Text = "25";
            overviewLastBetTypeText.Text = steenType.drieen.ToString();
            Console.WriteLine(currentPlayer.Player1);

            compareAmount(pacos, tweeen, drieen, vieren, vijfen, zessen, 25, steenType.drieen);
            
        }

        private void overviewRollDiceButton_Click(object sender, EventArgs e)
        {
            rollDices();
           
        }

        private void player1Dudo_Click(object sender, EventArgs e)
        {
            
        }

        public bool compareAmount(int aantalpacos, int aantaltweeen, int aantaldrieen, int aantalvieren, int aantalvijfen, int aantalzessen, int betaantal, steenType type){
            
            

            return true;
        }
    }
}
