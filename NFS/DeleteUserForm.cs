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

        public string login = Settings.Default.login;
        public string password = Settings.Default.pass;
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
           
            logger.Info(";");
            DB db = new DB();
            db.DeleteUser(login);
            Settings.Default.pass = "";
            Settings.Default.login = "";
            this.DialogResult = DialogResult.Yes;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(login + password);
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
