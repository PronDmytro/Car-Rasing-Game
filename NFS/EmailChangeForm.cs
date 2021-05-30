using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;
using NFS.Properties;
using NLog;

namespace NFS
{
    public partial class EmailChangeForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public string login = LoginData.Default.login;
        public string password = LoginData.Default.pass;
        public EmailChangeForm()
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
            logger.Info("EmailChange is confim;");
            if (password != confirmPassField.Text)
            {
                MessageBox.Show(@"Incorrect password");
                return;
            }
            this.DialogResult = DialogResult.OK;
            DB db = new DB();
            db.SetEmail(login, emailField.Text);
            LoginData.Default.login = emailField.Text;
            Close();
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            logger.Info("EmailChange is cancel;");
            this.DialogResult = DialogResult.No;
            Close();
        }
        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == @"New Email")
            {
                emailField.ForeColor = Color.Black;
                emailField.Text = "";
            }
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailField.Text))
            {
                emailField.ForeColor = SystemColors.WindowFrame;
                emailField.Text = @"New Email";
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

        private void EmailChangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Info("Exit From EmailChangeForm;");
        }
        private void CheckFields(object sender, EventArgs e)
        {

            if (emailField.Text == "" || confirmPassField.Text == "" || !new EmailAddressAttribute().IsValid(emailField.Text))
            {
                OkButton.Enabled = false;
            }
            else if( confirmPassField.Text != @"Confirm Password" && emailField.Text != @"New Email" && new EmailAddressAttribute().IsValid(emailField.Text))
            {
                OkButton.Enabled = true;
            }
        }
    }
}
