using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;
using NFS.Properties;

namespace NFS
{
    public partial class UserNameChangeForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public string login = Settings.Default.login;
        public string password = Settings.Default.pass;
        public UserNameChangeForm()
        {
            InitializeComponent();
        }
        private void CheckFields(object sender, EventArgs e)
        {
            if (confirmPassField.Text == "" || nameField.Text == "")
            {
                OkButton.Enabled = false;
            }
            else if (confirmPassField.Text != "" && confirmPassField.Text != @"Confirm Password" &&
                     nameField.Text != "" && nameField.Text != @"New Name")
            {
                OkButton.Enabled = true;
            }
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
        private void NoButton_Click(object sender, EventArgs e)
        {
            logger.Info("UserNameChange is cancel;");
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            logger.Info("UserNameChange is confim;");
            if (password != confirmPassField.Text)
            {
                MessageBox.Show(@"Incorrect password");
                return;
            }
            this.DialogResult = DialogResult.OK;
            DB db = new DB();
            db.SetName(login, nameField.Text);
            Close();
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == @"New Name")
            {
                nameField.Text = "";
                nameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameField.Text))
            {
                nameField.Text = @"New Name";
                nameField.ForeColor = SystemColors.WindowFrame;
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
            }
        }

        private void UserNameChangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Info("Exit from UserNameChangeForm;");
        }
    }
}
