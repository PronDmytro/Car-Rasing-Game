
namespace NFS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.statisticButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "NFS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkOrange;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(40, 416);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(367, 36);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.leaderboardButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.statisticButton);
            this.panel1.Controls.Add(this.startGameButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 497);
            this.panel1.TabIndex = 1;
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.BackColor = System.Drawing.Color.DarkOrange;
            this.leaderboardButton.FlatAppearance.BorderSize = 0;
            this.leaderboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderboardButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leaderboardButton.Location = new System.Drawing.Point(40, 177);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(367, 36);
            this.leaderboardButton.TabIndex = 8;
            this.leaderboardButton.Text = "Leaderboard";
            this.leaderboardButton.UseVisualStyleBackColor = false;
            this.leaderboardButton.Click += new System.EventHandler(this.LeaderboardButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.DarkOrange;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.Location = new System.Drawing.Point(40, 319);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(367, 36);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // statisticButton
            // 
            this.statisticButton.BackColor = System.Drawing.Color.DarkOrange;
            this.statisticButton.FlatAppearance.BorderSize = 0;
            this.statisticButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statisticButton.Location = new System.Drawing.Point(40, 240);
            this.statisticButton.Name = "statisticButton";
            this.statisticButton.Size = new System.Drawing.Size(367, 36);
            this.statisticButton.TabIndex = 2;
            this.statisticButton.Text = "Statistic";
            this.statisticButton.UseVisualStyleBackColor = false;
            this.statisticButton.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.DarkOrange;
            this.startGameButton.FlatAppearance.BorderSize = 0;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startGameButton.Location = new System.Drawing.Point(40, 108);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(367, 36);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 75);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button statisticButton;
        private System.Windows.Forms.Button leaderboardButton;
        private System.Windows.Forms.Button settingsButton;
    }
}