using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;
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

        private void LabelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckFields()
        {
            if (loginField.Text == "" || passField.Text == "" || !new EmailAddressAttribute().IsValid(loginField.Text))
            {
                ButtonLogin.Enabled = false;
            }
            else
            {
                ButtonLogin.Enabled = true;
            }
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            logger.Trace($"Login Button is click with paramethrs:login = {loginField.Text}, pass = {passField.Text};");
            DB db = new DB();
            int req = db.IsLogin(loginField.Text, passField.Text);
            if (req == 1)
            {
                MessageBox.Show("ERROR! Invalid user or password!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(req == -1)
            {
                return;
            }
            
            MainForm form = new MainForm(this.loginField.Text, this.passField.Text);
            this.Hide();
            form.ShowDialog();
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

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                 MessageBox.Show(@"Enter your valid email!");
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
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
