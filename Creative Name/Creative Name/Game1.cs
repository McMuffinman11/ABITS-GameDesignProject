using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;


// Get absolute value from times, then give a score based on difference
// Display
namespace Creative_Name
{
    public partial class Game1 : Form
    {
        Random rand = new Random();
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
            confetti.Visible = false;
            angry.Visible = false;
            music();
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
                confetti.Visible = true;
                laugh();
            }
            else if (absoluteTimeDifference <= 30 && absoluteTimeDifference > 5)
            {
                Score = 15;
                confetti.Visible = true;
                laugh();
            }
            else if (absoluteTimeDifference > 30 && absoluteTimeDifference <= 50)
            {
                Score = 10;
                confetti.Visible = true;
                laugh();
            }
            else
            {
                Score = 5;
                angry.Visible = true;
                grumble();
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

        private void laugh()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\zackfrey\Desktop\Project Sounds\laugh.wav");
            player.Play();
        }

        private void music()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\zackfrey\Desktop\Project Sounds\music.wav");
            player.Play();
        }

        private void grumble()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\zackfrey\Desktop\Project Sounds\grumble.wav");
            player.Play();
        }
    }
}
