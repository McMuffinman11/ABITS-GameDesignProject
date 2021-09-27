
namespace Weekly_Practice
{
    partial class WeeklyPracticeForm
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
            this.snakeBasePB = new System.Windows.Forms.PictureBox();
            this.targetTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.snakeBasePB)).BeginInit();
            this.SuspendLayout();
            // 
            // snakeBasePB
            // 
            this.snakeBasePB.BackColor = System.Drawing.Color.Red;
            this.snakeBasePB.Location = new System.Drawing.Point(654, 261);
            this.snakeBasePB.Name = "snakeBasePB";
            this.snakeBasePB.Size = new System.Drawing.Size(25, 25);
            this.snakeBasePB.TabIndex = 0;
            this.snakeBasePB.TabStop = false;
            this.snakeBasePB.Visible = false;
            // 
            // targetTimeLabel
            // 
            this.targetTimeLabel.AutoSize = true;
            this.targetTimeLabel.Location = new System.Drawing.Point(596, 67);
            this.targetTimeLabel.Name = "targetTimeLabel";
            this.targetTimeLabel.Size = new System.Drawing.Size(29, 31);
            this.targetTimeLabel.TabIndex = 1;
            this.targetTimeLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(72, 67);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(29, 31);
            this.currentTimeLabel.TabIndex = 2;
            this.currentTimeLabel.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(214, 173);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 31);
            this.label.TabIndex = 3;
            this.label.Text = "Score";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(354, 173);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(29, 31);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "0";
            // 
            // WeeklyPracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 320);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.targetTimeLabel);
            this.Controls.Add(this.snakeBasePB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "WeeklyPracticeForm";
            this.Text = "Weekly Practice Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WeeklyPracticeForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WeeklyPracticeForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.snakeBasePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snakeBasePB;
        private System.Windows.Forms.Label targetTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label scoreLabel;
    }
}

