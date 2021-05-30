using System;
using System.Windows.Forms;
using NLog;
using NFS.Properties;
namespace NFS
{
    
    public partial class MainForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public MainForm()
        {
            InitializeComponent();
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            logger.Info("Exit btn is clicked;");
            logger.Info("Exit From Application;");
            Application.Exit();
        }
        private void StatisticButton_Click(object sender, EventArgs e)
        {

        }

        private void LeaderboardButton_Click(object sender, EventArgs e)
        {
            logger.Info("Leaderboard btn is clicked;");
            this.Hide();
            logger.Info("MainForm is Hide;");
            using LeaderboardForm leaderboardForm = new LeaderboardForm();
            var result = leaderboardForm.ShowDialog();
            logger.Info("Open leaderboardForm;");

            if (result == DialogResult.OK)
            {
                this.Show();
                logger.Info("Show MainForm;");
            }
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            logger.Info("Settings btn is clicked;");
            this.Hide();
            using SettingsForm settingsForm = new SettingsForm {};
            logger.Info("Open SettingsForm;");
            var result = settingsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Show();
                logger.Info("Show MainForm;");
            }
            else if(result == DialogResult.No)
            {
                LoginForm loginForm = new LoginForm();

                loginForm.Show();
                this.Close();
                logger.Info("LoginForm is open;\n");
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            logger.Info("Start game btn is clicked;");
            this.Hide();
            logger.Info("MainForm is Hide;");
            using (Game game = new Game())
            {
                game.player.login = LoginData.Default.login;

                logger.Info("Open game window;");
                var result = game.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.Show();
                    logger.Info("Show MainForm;");
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Info("Exit From MainForm;");
        }
    }
}
