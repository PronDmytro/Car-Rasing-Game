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
    public partial class EmailChangeForm : Form
    {
        public string login;
        public string password;
        public EmailChangeForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(password != confirmPassField.Text)
            {
                MessageBox.Show(@"Incorrect password");
                return;
            }
            this.DialogResult = DialogResult.OK;
            DB db = new DB();
            db.SetEmail(login, emailField.Text);
            Close();
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }
        private void EmailField_Enter(object sender, EventArgs e)
        {

        }

        private void EmailField_Leave(object sender, EventArgs e)
        {

        }

        private void ConfirmPassField_Enter(object sender, EventArgs e)
        {

        }

        private void ConfirmPassField_Leave(object sender, EventArgs e)
        {

        }
    }
}
