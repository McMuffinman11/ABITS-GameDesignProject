using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Get absolute value from times, then give a score based on difference
// Display
namespace Creative_Name
{
    public partial class Game1 : Form
    { Random rand = new Random();
        int targetTime;
        int counter;
        int absoluteTimeDifference;
        int Score;
        Random redRand = new Random();
        Random greenRand = new Random();
        Random blueRand = new Random();

        public Game1()
        {
            InitializeComponent();
            targetTime = rand.Next(0, 1000);
            RandomTimeLabel.Text = targetTime.ToString();
        }

        private void Game1Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            CurrentTimeLabel.Text = counter.ToString();
        }

        private void Game1_MouseClick(object sender, MouseEventArgs e)
        {
            Game1Timer.Stop();
            absoluteTimeDifference = Math.Abs(targetTime - counter);
            if (absoluteTimeDifference <= 5)
            {
                Score = 20;
            }
            else if(absoluteTimeDifference <= 30 && absoluteTimeDifference > 5)
            {
                Score = 15;
            }
            else if (absoluteTimeDifference > 30 && absoluteTimeDifference <= 50)
            {
                Score = 10;
            }
            else
            {
                Score = 5;
            }
            string scoreMessage = "Score: " + Score;
            ScoreLabel.Text = scoreMessage;
        }

        private void BackgroundColorTimer_Tick(object sender, EventArgs e)
        {
            int randomRed = redRand.Next(230, 256);
            int randomGreen = greenRand.Next(230, 256);
            int randomBlue = blueRand.Next(230, 256);
            this.BackColor = Color.FromArgb(randomRed, randomGreen, randomBlue);
        }
    }
}
