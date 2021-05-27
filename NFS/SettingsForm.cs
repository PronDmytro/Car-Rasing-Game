using System;
using System.Windows.Forms;
using NLog;

namespace NFS
{
    public partial class SettingsForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public string login;
        public string password;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            logger.Info("Return btn is click;");
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ChangeUsernameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using UserNameChangeForm userNameChangeForm = new UserNameChangeForm {login = login, password = password};

            var result = userNameChangeForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using PasswordChangeForm passwordChangeForm = new PasswordChangeForm {login = login, password = password};

            var result = passwordChangeForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void ChangeEmailButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using EmailChangeForm emailChangeForm = new EmailChangeForm {login = login, password = password};

            var result = emailChangeForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            logger.Info("LogOut btn is click;");

            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(@"Do you want Log Out", @"Log Out", buttons);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.No;
                logger.Info("LogOut accepted;");
            }
            else if (result == DialogResult.No)
            {
                logger.Info("LogOut not accepted; ");
            }
            
        }
    }
}
