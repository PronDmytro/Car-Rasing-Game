﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace NFS
{
    
    public partial class MainForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public string login;
        public string password;
        public MainForm(string login, string password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
            logger.Info("Data transfer is successful;");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            logger.Info("Exit btn is clicked;");
            Application.Exit();
        }
        private void StatisticButton_Click(object sender, EventArgs e)
        {

        }

        private void LeaderboardButton_Click(object sender, EventArgs e)
        {

        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            logger.Info("Settings btn is clicked;");
            this.Hide();
            using (SettingsForm settingsForm = new SettingsForm())
            {
                settingsForm.login = login;
                settingsForm.password = password;
                logger.Info("Open SettingsForm;");
                var result = settingsForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                   this.Show();
                   logger.Info("Show MainForm;");
                }
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            logger.Info("Start game btn is clicked;");
            this.Hide();
            logger.Info("MainForm is Hide;");
            using (Game game = new Game())
            {
                game.player.login = login;

                logger.Info("Open game window;");
                var result = game.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.Show();
                    logger.Info("Show MainForm;");
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logger.Info("Exit From Application;");
            Application.Exit();
        }
    }
}
