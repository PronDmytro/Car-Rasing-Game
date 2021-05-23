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
    
    public partial class MainForm : Form
    {
        public string login;
        public string password;
        public MainForm(string login, string password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
            MessageBox.Show(login + " - " + password);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SettingsForm settingsForm = new SettingsForm())
            {
                settingsForm.login = login;
                settingsForm.password = password;
                var result = settingsForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                   this.Show();
                }
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Game game = new Game())
            {
                game.login = login;
                
                var result = game.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }
    }
}
