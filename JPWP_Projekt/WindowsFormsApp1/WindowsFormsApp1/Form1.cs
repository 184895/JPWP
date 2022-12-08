using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int speed;
        int score;
        int life;
        Random rand = new Random();
        bool gameOver;












        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainTimeEvent(object sender, EventArgs e)
        {
            points.Text = "Score: " + score;

            if (gameOver == true)
            {
                gameTimer.Stop();
                points.Text = "Score: " + score + "Game over";
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    
                }
            }

        }

        private void ClickGoodFood(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                var GoodFood = (PictureBox)sender;

               GoodFood.Top = rand.Next(750, 1000);
                GoodFood.Left = rand.Next(5, 500);

                score += 1;
            }

        }

        private void ClickBadFood(object sender, EventArgs e)
        {
            if(gameOver == false)
            {
                life -= 1;
            }
        }

        private void RestartGame()
        {
            speed = 5;
            score = 0;
            gameOver = false;



            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Top = rand.Next(750, 1000);
                    x.Left = rand.Next(5, 500);
                }
            }

            gameTimer.Start();
        }
    }
}
