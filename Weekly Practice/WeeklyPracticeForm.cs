using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekly_Practice
{
    
    public partial class WeeklyPracticeForm : Form
    {
        int targetTime;
        Random rnd = new Random();
        int timerInterval;
        int score;

        public WeeklyPracticeForm()
        {
            InitializeComponent();
            targetTime = rnd.Next(200, 400);
            targetTimeLabel.Text = targetTime.ToString();
        }

        private void WeeklyPracticeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                snakeBasePB.Left -= 10;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerInterval ++;
            currentTimeLabel.Text = timerInterval.ToString();
        }

        private void WeeklyPracticeForm_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            int currentTimeInt = Int32.Parse(currentTimeLabel.Text);
            score = Math.Abs(targetTime - currentTimeInt);
            scoreLabel.Text = score.ToString();
        }
    }
}
