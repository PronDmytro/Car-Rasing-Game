using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFS
{
    public partial class SettingsForm : Form
    {
        public string login;
        public string password;
        public SettingsForm()
        {
            InitializeComponent();

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ChangeUsernameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (UserNameChangeForm userNameChangeForm = new UserNameChangeForm())
            {
                userNameChangeForm.login = login;
                userNameChangeForm.password = password;

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
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (PasswordChangeForm passwordChangeForm = new PasswordChangeForm())
            {
                passwordChangeForm.login = login;
                passwordChangeForm.password = password;

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
        }

        private void ChangeEmailButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (EmailChangeForm emailChangeForm = new EmailChangeForm())
            {
                emailChangeForm.login = login;
                emailChangeForm.password = password;

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
        }
    }
}
