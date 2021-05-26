using System;
using System.Windows.Forms;
using NLog;

namespace NFS
{
    public partial class StartForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public StartForm()
        {
            logger.Info("\n\n\n" +
                        "----NFS----");
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                logger.Info("Loading is successful!");
                label1.Text = @"Successful";
                startButton.Enabled = true;
            }
            else
            {
                progressBar1.Value += 1;
            }
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            logger.Info("Start btn is click;");
            
            LoginForm loginForm = new LoginForm();
            
            loginForm.Show();
            this.Hide();
            logger.Info("LoginForm is open;\n");
        }
    }
}
