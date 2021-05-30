using System;
using System.Drawing;
using System.Windows.Forms;
using NFS.Properties;
using NLog;

namespace NFS
{
    public partial class RegisterForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public RegisterForm()
        {
            InitializeComponent();
            if (passField.Text == "" || passField.Text == ""||confirmPassField.Text==""||emailField.Text == ""|| !new Email().IsValidEmail(emailField.Text))
            {
                ButtonRegister.Enabled = false;
            }
            else
            {
                ButtonRegister.Enabled = true;
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
        private void LabelClose_Click(object sender, EventArgs e)
        {
            logger.Info("LabelClose is clicked;");
            logger.Info("Exit From Application");
            Application.Exit();
        }

        private void UserNameField_Enter(object sender, EventArgs e)
        {
            if(userNameField.Text == @"Name")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
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

        private void ConfirmPassField_Enter(object sender, EventArgs e)
        {
            if (confirmPassField.Text == @"Confirm Password")
            {
                confirmPassField.Text = "";
                confirmPassField.ForeColor = Color.Black;
                confirmPassField.UseSystemPasswordChar = true;
            }
        }

        private void EmailField_Enter(object sender, EventArgs e)
        {

            if (emailField.Text == @"Email")
            {
                emailField.Text = "";
                emailField.ForeColor = Color.Black;
            }
        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameField.Text))
            {
                userNameField.Text = @"Name";
                userNameField.ForeColor = SystemColors.WindowFrame;
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

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailField.Text))
            {
                emailField.Text = @"Email";
                emailField.ForeColor = SystemColors.WindowFrame;

                errorLabel.Visible = false;
                errorPicture.Visible = false;
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            logger.Info("Register btn is click;");

            DB db = new DB();
            int req = db.IsUserExist(emailField.Text);
            if (req == 1)
            {
                logger.Warn("Register is failed because user with this e-mail address already exists;");
                MessageBox.Show("A user with this e-mail address already exists, please try the forgot password option!");
                return;
            }
            else if (req == -1)
            {
                return;
            }
            
            db.AddUser(emailField.Text, passField.Text, userNameField.Text);
            LoginData.Default.login = emailField.Text;
            LoginData.Default.pass = passField.Text;
            MainForm form = new MainForm();
            this.Hide();
            form.ShowDialog();
            logger.Info("Open MainForm;");
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {
            CheckFields(this, e);
            if (!new Email().IsValidEmail(emailField.Text) && emailField.Text != "")
            {
                errorLabel.Visible = true;
                errorPicture.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
                errorPicture.Visible = false;
            }
        }

        private void CheckFields(object sender, EventArgs e)
        {
            if (confirmPassField.Text != passField.Text && passField.UseSystemPasswordChar &&
                confirmPassField.UseSystemPasswordChar)
            {
                ButtonRegister.Enabled = false;

                passErrorLabel.Visible = true;
                passErrorPicture.Visible = true;
            }
            else
            {
                passErrorLabel.Visible = false;
                passErrorPicture.Visible = false;
            }
            if (emailField.Text != "" && emailField.Text != @"Email" && passField.Text != "" &&
                passField.Text != @"Password" && confirmPassField.Text != "" &&
                confirmPassField.Text != @"Confirm Password" && userNameField.Text != "" &&
                userNameField.Text != @"Name" && new Email().IsValidEmail(emailField.Text)) 
            {
                ButtonRegister.Enabled = true;
            }
            else
            {
                ButtonRegister.Enabled = false;
            }
        }
        

        private void LogInLabel_Click(object sender, EventArgs e)
        {
            logger.Info("Click on LogInLabel;");
            
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
            logger.Info("Open LoginForm;");
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logger.Info("Exit From RegisterForm;");
        }
    }
}
