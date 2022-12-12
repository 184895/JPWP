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

        int score;
        int life;
        Random rand = new Random();
        bool gameOver;

        int spawnTimer=0;
        int food_rand;

        int ktoreFood;


        public Form1()
        {
            InitializeComponent();
            RestartGame();
            menuInt();
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
            lifetxt.Text = "Life: " + life;
            if (life == 2)
            {
                hpImage3.Visible = false;
            }
            else if (life == 1)
            {
                hpImage2.Visible = false;
            }
            else if (life == 0)
            {
                hpImage1.Visible = false;
            }



            if (life == 0)                              // inicjacja przegranej
            {
                gameOver = true;
            }

            if (gameOver == true)                       // wykonanie przegranej
            {
                gameTimer.Stop();
                points.Text = "Score: " + score + "Game over";

                foreach(Control x in this.Controls)
                {
                    if (x.Tag is "GoodFood")
                    {
                        x.Top = rand.Next(1300, 1400);
                        x.Left = rand.Next(5, 500);
                    }
                    if (x.Tag is "BadFood")
                    {
                        x.Top = rand.Next(1300, 1400);
                        x.Left = rand.Next(5, 500);
                    }
                }

            }

            if (score == 5)                       // wykonanie wygranej
            {
                gameTimer.Stop();
                points.Text = "Score: " + score + "you won";

                foreach (Control x in this.Controls)
                {
                    if (x.Tag is "GoodFood")
                    {
                        x.Top = rand.Next(1300, 1400);
                        x.Left = rand.Next(5, 500);
                    }
                    if (x.Tag is "BadFood")
                    {
                        x.Top = rand.Next(1300, 1400);
                        x.Left = rand.Next(5, 500);
                    }
                }

            }


            if(spawnTimer==0 & gameOver == false)
            {
                spawnItem();    
            }

            if(spawnTimer == 50)
            {
                despawnItem();
                spawnTimer = -1;
            }

            Console.WriteLine(spawnTimer);

            spawnTimer++;
            //foreach (Control x in this.Controls)                                                         //// tutaj spwan jedzenia z timerem gdzie *jesli nie klikne w czasie 5s respawn i -1hp *jesli klikne < 5s respawn i +1 punkt
            //// potrzebny 2 timer by uniezaleznmic sie od timera main
            //{

            //}

        }

        private void ClickGoodFood(object sender, EventArgs e)          //inicializacja klikniecia dobrej zywnosci
        {
            if (gameOver == false)
            {
                var GoodFood = (PictureBox)sender;

               GoodFood.Top = rand.Next(1300, 1400);
                GoodFood.Left = rand.Next(5, 500);
                spawnTimer = 0;

                score += 1;
            }

        }

        private void ClickBadFood(object sender, EventArgs e)           //inicjalizacja klikniecia dobrej zywnosci
        {
            if(gameOver == false)
            {
                var BadFood = (PictureBox)sender;
                BadFood.Top = rand.Next(1300, 1400);
                BadFood.Left = rand.Next(5, 500);
                spawnTimer = 0;


                life -= 1;
            }
        }

        private void RestartGame()              //restart 
        {
            score = 0;
            life = 3;
            gameOver = false;



            foreach(Control x in this.Controls)
            {
                if(x.Tag is "GoodFood")
                {
                    x.Top = rand.Next(1300, 1400);
                    x.Left = rand.Next(5, 500);
                }
                if (x.Tag is "BadFood")
                {
                    x.Top = rand.Next(1300, 1400);
                    x.Left = rand.Next(5, 500);
                }

            }

            gameTimer.Start();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuInt();
        }

        private void menuInt()   //inicjalizacja menu
        {
            gameTimer.Stop();

            foreach (Control x in this.Controls)
            {
                if (x.Tag is "GoodFood")
                {
                    x.Top = rand.Next(1300, 1400);
                    x.Left = rand.Next(5, 500);
                }
                if (x.Tag is "BadFood")
                {
                    x.Top = rand.Next(1300, 1400);
                    x.Left = rand.Next(5, 500);
                }
            }

            jakGrac.Enabled = true;
            jakGrac.Visible = true;
            start.Enabled = true;
            start.Visible = true;

            hpImage1.Visible = false;
            hpImage2.Visible = false;
            hpImage3.Visible = false;

            jablko_opis.Visible = false;
            banan_opis.Visible = false;
            marchew_opis.Visible = false;
            arbuz_opis.Visible = false;
            brokul_opis.Visible = false;
            zdrowaZywnosc_opis.Visible = false;
            NieZdrowaZywnosc_opis.Visible = false;
            pizza_opis.Visible = false;
            burger_opis.Visible = false;

            Opis_gry.Visible = false;

            exitImg.Visible = true;
            exitImg.Enabled = true;

            points.Visible = false;
            lifetxt.Visible = false;
        }

        private void jakGrac_Click(object sender, EventArgs e)
        {
            jablko_opis.Visible = true;
            banan_opis.Visible = true;
            marchew_opis.Visible = true;
            arbuz_opis.Visible = true;
            brokul_opis.Visible = true;
            zdrowaZywnosc_opis.Visible = true;
            NieZdrowaZywnosc_opis.Visible = true;
            pizza_opis.Visible = true;
            burger_opis.Visible = true;
            Opis_gry.Visible = true;

            jakGrac.Enabled = false;
            jakGrac.Visible = false;
            start.Enabled = false;
            start.Visible = false;

            exitImg.Visible = false;
            exitImg.Enabled = false;

            zdrowaZywnosc_opis.Left = 200;
            zdrowaZywnosc_opis.Top = 10;

            jablko.Top = 50;
            jablko.Left = 10;
            jablko.Enabled  = false;
            jablko_opis.Top = 100;
            jablko_opis.Left = 200;

            banan.Top = 200;
            banan.Left = 10;
            banan.Enabled = false;
            banan_opis.Top = 250;
            banan_opis.Left = 200;

            marchewka.Top = 350;
            marchewka.Left = 10;
            marchewka.Enabled = false;
            marchew_opis.Top = 420;
            marchew_opis.Left= 200;

            brokul.Top = 500;
            brokul.Left = 10;  
            brokul.Enabled = false;
            brokul_opis.Top = 590;
            brokul_opis.Left = 200;
            
            arbuz.Top = 650;
            arbuz.Left = 10;   
            arbuz.Enabled = false;
            arbuz_opis.Top = 760;
            arbuz_opis.Left = 200;

            NieZdrowaZywnosc_opis.Top = 10;
            NieZdrowaZywnosc_opis.Left = 900;

            burger.Top = 50;
            burger.Left = 750;
            burger.Enabled = false;
            burger_opis.Top = 100;
            burger_opis.Left = 950;

            pizza.Top = 200;
            pizza.Left = 750;
            pizza.Enabled = false;
            pizza_opis.Top = 250;
            pizza_opis.Left = 950;

        }

        private void start_Click(object sender, EventArgs e)
        {
            jakGrac.Enabled = false;
            jakGrac.Visible = false;
            start.Enabled = false;
            start.Visible = false;
            points.Visible = true;
            lifetxt.Visible = true;
            exitImg.Visible = false;
            exitImg.Enabled = false;

            hpImage1.Visible = true;
            hpImage2.Visible = true;
            hpImage3.Visible = true;

            jablko.Enabled = true;
            brokul.Enabled = true;
            banan.Enabled = true;
            arbuz.Enabled = true;
            marchewka.Enabled = true;

            burger.Enabled = true;
            pizza.Enabled = true;

            RestartGame();
            spawnTimer = 0;
        }

        private void spawnItem()   ///spawn itemow
        {
            food_rand = rand.Next(1, 8);

            if(food_rand == 1)
            {
                jablko.Top = rand.Next(1, 500);
                jablko.Left = rand.Next(1, 500);
                ktoreFood = 1;
            }
            else if(food_rand == 2)
            {
                marchewka.Top = rand.Next(1, 500);
                marchewka.Left = rand.Next(1, 500);
                ktoreFood = 2;
            }
            else if (food_rand == 3)
            {
                brokul.Top = rand.Next(1, 500);
                brokul.Left = rand.Next(1, 500);
                ktoreFood = 3;
            }
            else if (food_rand == 4)
            {
                banan.Top = rand.Next(1, 500);
                banan.Left = rand.Next(1, 500);
                ktoreFood = 4;
            }
            else if (food_rand == 5)
            {
                arbuz.Top = rand.Next(1, 500);
                arbuz.Left = rand.Next(1, 500);
                ktoreFood = 5;
            }
            else if (food_rand == 6)
            {
                burger.Top = rand.Next(1, 500);
                burger.Left = rand.Next(1, 500);
                ktoreFood = 6;
            }
            else if (food_rand == 7)
            {
                pizza.Top = rand.Next(1, 500);
                pizza.Left = rand.Next(1, 500);
                ktoreFood = 7;
            }
        }

        private void despawnItem()    //despawn itemow
        {
            if(ktoreFood==1)
            {
                jablko.Top = 1400;
                jablko.Left = 1400;
                life--;
            }
            else if(ktoreFood==2)
            {
                marchewka.Top = 1400;
                marchewka.Left = 1400;
                life--;
            }
            else if (ktoreFood == 3)
            {
                brokul.Top = 1400;
                brokul.Left = 1400;
                life--;
            }
            else if (ktoreFood == 4)
            {
                banan.Top = 1400;
                banan.Left = 1400;
                life--;
            }
            else if (ktoreFood == 5)
            {
                arbuz.Top = 1400;
                arbuz.Left = 1400;
                life--;
            }
            else if (ktoreFood == 6)
            {
                burger.Top = 1400;
                burger.Left = 1400;
            }
            else if (ktoreFood == 7)
            {
                pizza.Top = 1400;
                pizza.Left = 1400;
            }

        }

        private void exitImg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
