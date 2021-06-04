using System;
using System.Drawing;
using System.Windows.Forms;
using NFS.Properties;
using NLog;

namespace NFS
{
    public partial class DeleteUserForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public string login = LoginData.Default.login;
        public string password = LoginData.Default.pass;
        public DeleteUserForm()
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
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (password != passField.Text)
            {
                MessageBox.Show(@"Incorrect password!");
                return;
            }
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result =
                MessageBox.Show($@"Do you really want delete account???{Environment.NewLine}All data will be deleted!{Environment.NewLine}Continue?",
                    @"Account Deleting", buttons);
            if (result == DialogResult.Yes)
            {
                logger.Info("User deleting;");
                DB db = new DB();
                db.DeleteUser(login);
                LoginData.Default.pass = "";
                LoginData.Default.login = "";
                this.DialogResult = DialogResult.Yes;
            }
            else if (result == DialogResult.No)
            {
                logger.Info("Account Deleting not accepted; ");
            }
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }
        private void PassField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == @"Password")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
                passField.UseSystemPasswordChar = true;
            }
        }
        private void PassField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passField.Text))
            {
                passField.UseSystemPasswordChar = false;
                passField.Text = @"Password";
                passField.ForeColor = SystemColors.WindowFrame;

                passErrorLabel.Visible = false;
                passErrorPicture.Visible = false;
            }
        }
        private void ConfirmPassField_Enter(object sender, EventArgs e)
        {
            if (confirmPassField.Text == @"Confirm Password")
            {
                confirmPassField.Text = "";
                confirmPassField.ForeColor = Color.Black;
                confirmPassField.UseSystemPasswordChar = true;
            }
        }
        private void ConfirmPassField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirmPassField.Text))
            {
                confirmPassField.UseSystemPasswordChar = false;
                confirmPassField.Text = @"Confirm Password";
                confirmPassField.ForeColor = SystemColors.WindowFrame;

                passErrorLabel.Visible = false;
                passErrorPicture.Visible = false;
            }
        }
        private void CheckFields(object sender, EventArgs e)
        {
            if (confirmPassField.Text != passField.Text && passField.UseSystemPasswordChar &&
                confirmPassField.UseSystemPasswordChar)
            {
                OkButton.Enabled = false;

                passErrorLabel.Visible = true;
                passErrorPicture.Visible = true;
            }
            else
            {
                passErrorLabel.Visible = false;
                passErrorPicture.Visible = false;
            }
            if (passField.Text != "" && passField.Text != @"Password" && confirmPassField.Text != "" &&
                confirmPassField.Text != @"Confirm Password")
            {
                OkButton.Enabled = true;
            }
            else
            {
                OkButton.Enabled = false;
            }
        }
    }
}
