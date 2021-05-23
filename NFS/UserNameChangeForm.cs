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
    public partial class UserNameChangeForm : Form
    {
        public string login;
        public string password;
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
            else
            {
                OkButton.Enabled = true;
            }
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
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
    }
}
