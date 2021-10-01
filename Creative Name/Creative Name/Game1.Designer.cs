
namespace Creative_Name
{
    partial class Game1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Game1Timer = new System.Windows.Forms.Timer(this.components);
            this.RandomTimeLabel = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ThisIsCTLabel = new System.Windows.Forms.Label();
            this.ThisIsTTLabel = new System.Windows.Forms.Label();
            this.BackgroundColorTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Game1Timer
            // 
            this.Game1Timer.Enabled = true;
            this.Game1Timer.Interval = 1;
            this.Game1Timer.Tick += new System.EventHandler(this.Game1Timer_Tick);
            // 
            // RandomTimeLabel
            // 
            this.RandomTimeLabel.AutoSize = true;
            this.RandomTimeLabel.Location = new System.Drawing.Point(862, 155);
            this.RandomTimeLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.RandomTimeLabel.Name = "RandomTimeLabel";
            this.RandomTimeLabel.Size = new System.Drawing.Size(56, 67);
            this.RandomTimeLabel.TabIndex = 0;
            this.RandomTimeLabel.Text = "0";
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(243, 155);
            this.CurrentTimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(56, 67);
            this.CurrentTimeLabel.TabIndex = 1;
            this.CurrentTimeLabel.Text = "0";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(565, 303);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(56, 67);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "0";
            // 
            // ThisIsCTLabel
            // 
            this.ThisIsCTLabel.AutoSize = true;
            this.ThisIsCTLabel.Location = new System.Drawing.Point(126, 69);
            this.ThisIsCTLabel.Name = "ThisIsCTLabel";
            this.ThisIsCTLabel.Size = new System.Drawing.Size(325, 67);
            this.ThisIsCTLabel.TabIndex = 3;
            this.ThisIsCTLabel.Text = "Current Time:";
            // 
            // ThisIsTTLabel
            // 
            this.ThisIsTTLabel.AutoSize = true;
            this.ThisIsTTLabel.Location = new System.Drawing.Point(748, 69);
            this.ThisIsTTLabel.Name = "ThisIsTTLabel";
            this.ThisIsTTLabel.Size = new System.Drawing.Size(295, 67);
            this.ThisIsTTLabel.TabIndex = 4;
            this.ThisIsTTLabel.Text = "Target Time:";
            // 
            // BackgroundColorTimer
            // 
            this.BackgroundColorTimer.Enabled = true;
            this.BackgroundColorTimer.Interval = 1200;
            this.BackgroundColorTimer.Tick += new System.EventHandler(this.BackgroundColorTimer_Tick);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 67F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1198, 483);
            this.Controls.Add(this.ThisIsTTLabel);
            this.Controls.Add(this.ThisIsCTLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.RandomTimeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(11);
            this.Name = "Game1";
            this.Text = "Game1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Game1Timer;
        private System.Windows.Forms.Label RandomTimeLabel;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ThisIsCTLabel;
        private System.Windows.Forms.Label ThisIsTTLabel;
        private System.Windows.Forms.Timer BackgroundColorTimer;
    }
}