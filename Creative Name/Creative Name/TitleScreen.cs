using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Creative_Name
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
            whatever();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            click();
            this.Close();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            click();
            Game1 game  = new Game1();
            game.ShowDialog();

        }
        private void whatever()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\zackfrey\Desktop\Project Sounds\ticktock.wav");
            player.Play();
        }

        private void click()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\zackfrey\Desktop\Project Sounds\click.wav");
            player.Play();
        }

        private void TitleScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
