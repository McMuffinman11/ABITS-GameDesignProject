﻿using System;
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
    public partial class CalvinsGame : Form
    {
        string directionString = "right";
        bool touchingFood;        
        
        public CalvinsGame()
        {
            InitializeComponent();
        }

        private void CalvinsGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                directionString = "left";
            }
            else if (e.KeyCode == Keys.D)
            {
                directionString = "right";
            }
            else if (e.KeyCode == Keys.S)
            {
                directionString = "down";
            }
            else if (e.KeyCode == Keys.W)
            {
                directionString = "up";
            }
        }


        private void movementTimer_Tick(object sender, EventArgs e)
        {
            switch (directionString)
            {
                case "left":
                    snakeBase.Left -= 10;
                    break;
                case "right":
                    snakeBase.Left += 10;
                    break;
                case "down":
                    snakeBase.Top += 10;
                    break;
                case "up":
                    snakeBase.Top -= 10;
                    break;
            }
            touchingFood = isTouchingFood();
            label1.Text = touchingFood.ToString();
            if(touchingFood == true)
            {
                food.Visible = false;
            }
        }

        private bool isTouchingFood()
        {
            if (snakeBase.Left < food.Left + 20 && snakeBase.Left + 20 > food.Left && snakeBase.Top < food.Top + 20 && snakeBase.Top + 20 > food.Top)
            {
                return true;
            }
            else
                return false;
        }


    }
}
