using System;
using System.Net.NetworkInformation;
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
               
                IPStatus status = IPStatus.TimedOut;
                try
                {
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(@"google.com");
                    status = reply.Status;
                }
                catch { }
                if (status != IPStatus.Success)
                {
                    logger.Warn("No internet connection available");
                    label1.Text = @"No internet connection available";
                    MessageBox.Show(@"Check your internet connection!", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar1.Value = 0;
                    startButton.Enabled = true;
                    startButton.Text = @"Refresh";
                }
                else
                {
                    startButton.Enabled = true;
                    logger.Info("Loading is successful!");
                    label1.Text = @"Successful";
                }
            }
            else
            {
                progressBar1.Value += 1;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            logger.Info("Start btn is click;");
            if (startButton.Text== @"Refresh")
            {
                timer1.Start();
                label1.Text = @"Loading...";
                startButton.Text = @"Start";
                startButton.Enabled = false;
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                
                loginForm.Show();
                this.Hide();
                logger.Info("LoginForm is open;\n");
            }
            
        }
    }
}
