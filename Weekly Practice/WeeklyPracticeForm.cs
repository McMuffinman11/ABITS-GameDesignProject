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
        public WeeklyPracticeForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            CalvinsGame cg = new CalvinsGame();
            cg.ShowDialog();
        }
    }
}
