﻿
namespace Weekly_Practice
{
    partial class CalvinsGame
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
            this.snakeBase = new System.Windows.Forms.PictureBox();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.food = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.snakeBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            this.SuspendLayout();
            // 
            // snakeBase
            // 
            this.snakeBase.BackColor = System.Drawing.Color.Red;
            this.snakeBase.Location = new System.Drawing.Point(252, 251);
            this.snakeBase.Name = "snakeBase";
            this.snakeBase.Size = new System.Drawing.Size(25, 25);
            this.snakeBase.TabIndex = 0;
            this.snakeBase.TabStop = false;
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 50;
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // food
            // 
            this.food.Image = global::Weekly_Practice.Properties.Resources.appleImage;
            this.food.Location = new System.Drawing.Point(584, 161);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(20, 20);
            this.food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.food.TabIndex = 1;
            this.food.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // CalvinsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.snakeBase);
            this.Controls.Add(this.food);
            this.Name = "CalvinsGame";
            this.Text = "CalvinsGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalvinsGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.snakeBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snakeBase;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.PictureBox food;
        private System.Windows.Forms.Label label1;
    }
}