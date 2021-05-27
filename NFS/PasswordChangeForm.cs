using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace NFS
{
    public partial class PasswordChangeForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public string login;
        public string password;
        public PasswordChangeForm()
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
            logger.Info("PasswordChange is confim;");
            if (password != passField.Text)
            {
                logger.Warn("PasswordChange not successful because incorrect password;");
                MessageBox.Show(@"Incorrect password!");
                return;
            }

            if (password == newPassField.Text)
            {
                logger.Warn("PasswordChange not successful because the new password matches the old one;");
                MessageBox.Show(@"The new password matches the old one!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            DB db = new DB();
            db.SetPassword(login, newPassField.Text);
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            logger.Info("PasswordChange is cancel;");
            this.DialogResult = DialogResult.No;
            Close();
        }
        private void CheckPassFields(object sender, EventArgs e)
        {
            if (newPassField.Text != confirmNewPassField.Text && confirmNewPassField.UseSystemPasswordChar &&
                newPassField.UseSystemPasswordChar)
            {
                OkButton.Enabled = false;

                passErrorLabel.Visible = true;
                passErrorPicture.Visible = true;
            }
            else
            {
                OkButton.Enabled = true;
                passErrorLabel.Visible = false;
                passErrorPicture.Visible = false;
            }
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

        private void NewPassField_Enter(object sender, EventArgs e)
        {
            if (newPassField.Text == @"New Password")
            {
                newPassField.Text = "";
                newPassField.ForeColor = Color.Black;
                newPassField.UseSystemPasswordChar = true;
            }
        }

        private void NewPassField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newPassField.Text))
            {
                newPassField.UseSystemPasswordChar = false;
                newPassField.Text = @"New Password";
                newPassField.ForeColor = SystemColors.WindowFrame;

                passErrorLabel.Visible = false;
                passErrorPicture.Visible = false;
            }
        }

        private void ConfirmNewPassField_Enter(object sender, EventArgs e)
        {
            if (confirmNewPassField.Text == @"Confirm New Password")
            {
                confirmNewPassField.Text = "";
                confirmNewPassField.ForeColor = Color.Black;
                confirmNewPassField.UseSystemPasswordChar = true;
            }
        }

        private void confirmNewPassField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirmNewPassField.Text))
            {
                confirmNewPassField.UseSystemPasswordChar = false;
                confirmNewPassField.Text = @"Confirm New Password";
                confirmNewPassField.ForeColor = SystemColors.WindowFrame;

                passErrorLabel.Visible = false;
                passErrorPicture.Visible = false;
            }
        }

        private void PasswordChangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Info("Exit From PasswordChangeForm;");
        }
    }
}
