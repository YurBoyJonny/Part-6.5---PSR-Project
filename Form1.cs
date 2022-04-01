using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6._5___PSR_Project
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.ROCK;
        }
        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.PAPERS;
        }
        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.EdSciss;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int opponentResult = generator.Next(1,4);
            string playerChoice = radRock;
            

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
                imgOpponent.Image = Properties.Resources.EdSciss;
            }


            if (opponentResult == playerChoice)
            {
                lblResult.Text = "TIE";
            }

        }
    }
}
