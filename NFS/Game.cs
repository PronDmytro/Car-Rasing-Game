using System;
using System.Drawing;
using System.Windows.Forms;
using NFS.Properties;

namespace NFS
{
    public partial class Game : Form
    {
        public string login;
        public class Player
        {
            public int playerSpeed = 12;
            public bool goleft;
            public bool goright;

            public void GoLeft(PictureBox player_box)
            {
                if (goleft == true && player_box.Left > 10)
                {
                    player_box.Left -= playerSpeed;
                }
            }
            public void GoRight(PictureBox player_box)
            {
                if (goright == true && player_box.Left < 415)
                {
                    player_box.Left += playerSpeed;
                }
            }
        }

        Player player = new Player();
        int roadSpeed;
        int trafficSpeed;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();


        public Game()
        {
            InitializeComponent();
            ResetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                player.goleft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                player.goright = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                player.goleft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                player.goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;
            score++;

            player.GoLeft(player_box);
            player.GoRight(player_box);
            
            

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;


            if (AI1.Top > 530)
            {
                changeAIcars(AI1);
            }

            if (AI2.Top > 530)
            {
                changeAIcars(AI2);
            }

            if (player_box.Bounds.IntersectsWith(AI1.Bounds) || player_box.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 500)
            {
                award.Image = Resources.bronze;
            }


            if (score > 500 && score < 2000)
            {
                award.Image = Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }

            if (score > 2000)
            {
                award.Image = Resources.gold;
                trafficSpeed = 27;
                roadSpeed = 25;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {

            carImage = rand.Next(1, 9);

            switch (carImage)
            {

                case 1:
                    tempCar.Image = Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Resources.TruckWhite;
                    break;
            }


            tempCar.Top = carPosition.Next(100, 400) * -1;


            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player_box.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;
        }

        private void ResetGame()
        {

            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            player.goleft = false;
            player.goright = false;
            score = 0;
            award.Image = Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = carPosition.Next(200, 500) *-1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);

            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Resources.hit);
            playCrash.Play();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
