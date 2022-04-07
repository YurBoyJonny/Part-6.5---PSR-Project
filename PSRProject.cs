using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Part_6._5___PSR_Project
{
    public partial class PSRProject : Form
    {
        Random generator = new Random();
        int playerChoice;
        int playerScore = 0;
        int opponentScore = 0;

        public PSRProject()
        {
            InitializeComponent();
        }
        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.ROCK;
            playerChoice = 1;
        }
        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.PAPERS;
            playerChoice = 2;
        }
        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.SCISSORS;
            playerChoice = 3;
        }
        private int duration = 5;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            duration = 5;
            countDownTimer.Tick += new EventHandler(count_down);
            countDownTimer.Interval = 1000;
            countDownTimer.Start();
        }
        private void count_down(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                countDownTimer.Stop();
                int opponentResult = generator.Next(1, 4);
                if (opponentResult == 1)
                {
                    imgOpponent.Image = Properties.Resources.ROCK;
                }
                else if (opponentResult == 2)
                {
                    imgOpponent.Image = Properties.Resources.PAPERS;
                }
                else if (opponentResult == 3)
                {
                    imgOpponent.Image = Properties.Resources.SCISSORS;
                }

                if (opponentResult == playerChoice)
                {
                    lblResult.Text = "Tie!";
                }
                else if (opponentResult == 1 && playerChoice == 3 || opponentResult == 2 && playerChoice == 1 || opponentResult == 3 && playerChoice == 2)
                {
                    lblResult.Text = "Lose!";
                    opponentScore += 1;
                }
                else if (opponentResult == 3 && playerChoice == 1 || opponentResult == 1 && playerChoice == 2 || opponentResult == 2 && playerChoice == 3)
                {
                    lblResult.Text = "Win!";
                    playerScore += 1;
                }
            }
            else if (duration > 0)
            {
                duration--;
                txtCountDown.Text = duration.ToString();
            }
        }
    }
}
