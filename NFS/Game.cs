using System;
using System.Drawing;
using System.Windows.Forms;
using NFS.Properties;
using NLog;

namespace NFS
{
    public partial class Game : Form
    {
        public class Player
        {
            public string login;
            public int playerSpeed = 12;
            public bool goleft;
            public bool goright;
            public int score;

            public void GoLeft(PictureBox player_box)
            {
                if (goleft == true && player_box.Left > 60)
                {
                    player_box.Left -= playerSpeed;
                }
            }

            public void GoRight(PictureBox player_box)
            {
                if (goright == true && player_box.Left < 455)
                {
                    player_box.Left += playerSpeed;
                }
            }
        }

        public Player player = new Player();
        private int _roadSpeed;
        private int _trafficSpeed;
        private int _carImage;
        private Random rand = new Random();
        private Random carPosition = new Random();

        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Game()
        {
            InitializeComponent();
            ResetGame();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    player.goleft = true;
                    break;
                case Keys.Right:
                case Keys.D:
                    player.goright = true;
                    break;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    player.goleft = false;
                    break;
                case Keys.Right:
                case Keys.D:
                    player.goright = false;
                    break;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = player_box.Left.ToString();
            //txtScore.Text = @"Score: " + player.score;
            player.score++;

            player.GoLeft(player_box);
            player.GoRight(player_box);



            roadTrack1.Top += _roadSpeed;
            roadTrack2.Top += _roadSpeed;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            AI1.Top += _trafficSpeed;
            AI2.Top += _trafficSpeed;


            if (AI1.Top > 530)
            {
                ChangeAiCars(AI1);
            }

            if (AI2.Top > 530)
            {
                ChangeAiCars(AI2);
            }

            if (player_box.Bounds.IntersectsWith(AI1.Bounds) || player_box.Bounds.IntersectsWith(AI2.Bounds))
            {
                GameOver();
            }

            if (player.score > 40 && player.score < 500)
            {
                award.Image = Resources.bronze;
            }


            if (player.score > 500 && player.score < 2000)
            {
                award.Image = Resources.silver;
                _roadSpeed = 20;
                _trafficSpeed = 22;
            }

            if (player.score > 2000)
            {
                award.Image = Resources.gold;
                _trafficSpeed = 27;
                _roadSpeed = 25;
            }
        }

        private void ChangeAiCars(PictureBox tempCar)
        {

            _carImage = rand.Next(1, 9);

            tempCar.Image = _carImage switch
            {
                1 => Resources.ambulance,
                2 => Resources.carGreen,
                3 => Resources.carGrey,
                4 => Resources.carOrange,
                5 => Resources.carPink,
                6 => Resources.CarRed,
                7 => Resources.carYellow,
                8 => Resources.TruckBlue,
                9 => Resources.TruckWhite,
                _ => tempCar.Image
            };

            tempCar.Top = carPosition.Next(100, 400) * -1;


            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(60, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 455);
            }
        }

        private void GameOver()
        {
            logger.Info("Game over;");
            DB db = new DB();
            db.SetCountOfGames(player.login);
            logger.Info($"Set new score - { player.score} to {player.login};");
            db.SetScore(player.login, player.score);

            PlaySound();
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
            player.score = 0;
            award.Image = Resources.bronze;

            _roadSpeed = 12;
            _trafficSpeed = 15;

            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);

            gameTimer.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private static void PlaySound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Resources.hit);
            playCrash.Play();

        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}