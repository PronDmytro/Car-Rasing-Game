using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;
using NLog;

namespace NFS
{
    public partial class LoginForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public LoginForm()
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
        private void LabelClose_Click(object sender, EventArgs e)
        {
            logger.Info("LabelClose is clicked;");
            logger.Info("Exit From Application;");
            Application.Exit();
        }

        private void CheckFields()
        {
            if (loginField.Text != "" && loginField.Text != @"Email" && passField.Text != "" &&
                passField.Text != @"Password" && new EmailAddressAttribute().IsValid(loginField.Text)) 
            {
                ButtonLogin.Enabled = true;
            }
            else
            {
                ButtonLogin.Enabled = false;
            }
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            logger.Info("Login btn is click;");
            DB db = new DB();
            int req = db.IsLogin(loginField.Text, passField.Text);
            
            if (req == 0)
            {
                logger.Error("Invalid user or password!");
                MessageBox.Show("ERROR! Invalid user or password!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(req == -1)
            {
                return;
            }
            logger.Info($"{loginField.Text} is entered itno the account");
            logger.Info("Open MainForm");
            MainForm mainFormform = new MainForm(this.loginField.Text, this.passField.Text);
            this.Close();
            mainFormform.ShowDialog();
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == @"Email")
            {
                loginField.ForeColor = Color.Black;
                loginField.Text = "";
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == @"Password")
            {
                passField.ForeColor = Color.Black;
                passField.Text = "";
                passField.UseSystemPasswordChar = true;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginField.Text))
            {
                loginField.ForeColor = SystemColors.WindowFrame;
                loginField.Text = @"Email";

                errorLabel.Visible = false;
                errorPicture.Visible = false;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passField.Text))
            {
                passField.UseSystemPasswordChar = false;
                passField.ForeColor = SystemColors.WindowFrame;
                passField.Text = @"Password";
            }
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
            if (!new EmailAddressAttribute().IsValid(loginField.Text) && loginField.Text != "")
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

        private void PassField_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void ForgotPassLabel_Click(object sender, EventArgs e)
        {
            logger.Info("Click on ForgotPassLabel;");
            DB db = new DB();
            int req = db.IsUserExist(loginField.Text);

            if (req == 0)
            {
                logger.Info("Entered unvalid email!");
                MessageBox.Show(@"Enter your valid email!");
                return;
            }
            else if (req == -1)
            {
                return;
            }

            Random rnd = new Random();
            int value = rnd.Next(1000, 9999);
            Email email = new Email();
            email.SendResetPassEmail(loginField.Text, value);
            
            db.SetPassword(loginField.Text, value.ToString());
           
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            logger.Info("Click on SignUpLabel;");
            
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Close();
            logger.Info("Open RegisterForm;\n");
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Info("Exit From LoginForm;");
        }
    }
}
