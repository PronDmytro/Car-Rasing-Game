using System;
using System.Windows.Forms;
using NFS.Properties;
using NLog;

namespace NFS
{
    public partial class SettingsForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

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
            logger.Info("ChangeUsername btn is click;");
            this.Hide();
            using UserNameChangeForm userNameChangeForm = new UserNameChangeForm {};
            logger.Info("Open userNameChangeForm;");
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
            logger.Info("ChangePass btn is click;");
            this.Hide();
            using PasswordChangeForm passwordChangeForm = new PasswordChangeForm {};
            logger.Info("Open ChangePass;");
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
            logger.Info("ChangeEmail btn is click;");
            using EmailChangeForm emailChangeForm = new EmailChangeForm {};
            logger.Info("Open ChangeEmail;");
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
        private void DeleteUserAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            logger.Info("DeleteUserAccount btn is click;");
            using DeleteUserForm deleteUserForm = new DeleteUserForm {};
            logger.Info("Open DeleteUserAccountForm;");
            var result = deleteUserForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.No;
                logger.Info("Accepted user deleting;");
            }
            else if (result == DialogResult.No)
            {
                this.Show();
                logger.Info("Not accepted user deleting; ");
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
                LoginData.Default.pass = "";
                LoginData.Default.login = "";
            }
            else if (result == DialogResult.No)
            {
                logger.Info("LogOut not accepted; ");
            }
            
        }
    }
}
