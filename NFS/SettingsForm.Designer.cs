
namespace NFS
{
    partial class SettingsForm
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
            this.returnButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteUserAccountButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.changeUsernameButton = new System.Windows.Forms.Button();
            this.changeEmailButton = new System.Windows.Forms.Button();
            this.changePassButton = new System.Windows.Forms.Button();
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
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.DarkOrange;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnButton.Location = new System.Drawing.Point(40, 449);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(367, 36);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return to main menu";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.deleteUserAccountButton);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.changeUsernameButton);
            this.panel1.Controls.Add(this.changeEmailButton);
            this.panel1.Controls.Add(this.changePassButton);
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 497);
            this.panel1.TabIndex = 2;
            // 
            // deleteUserAccountButton
            // 
            this.deleteUserAccountButton.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteUserAccountButton.FlatAppearance.BorderSize = 0;
            this.deleteUserAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserAccountButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteUserAccountButton.Location = new System.Drawing.Point(40, 309);
            this.deleteUserAccountButton.Name = "deleteUserAccountButton";
            this.deleteUserAccountButton.Size = new System.Drawing.Size(367, 36);
            this.deleteUserAccountButton.TabIndex = 4;
            this.deleteUserAccountButton.Text = "Delete user account";
            this.deleteUserAccountButton.UseVisualStyleBackColor = false;
            this.deleteUserAccountButton.Click += new System.EventHandler(this.DeleteUserAccountButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.DarkOrange;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOutButton.Location = new System.Drawing.Point(40, 366);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(367, 36);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // changeUsernameButton
            // 
            this.changeUsernameButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changeUsernameButton.FlatAppearance.BorderSize = 0;
            this.changeUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUsernameButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeUsernameButton.Location = new System.Drawing.Point(40, 120);
            this.changeUsernameButton.Name = "changeUsernameButton";
            this.changeUsernameButton.Size = new System.Drawing.Size(367, 36);
            this.changeUsernameButton.TabIndex = 1;
            this.changeUsernameButton.Text = "Change username";
            this.changeUsernameButton.UseVisualStyleBackColor = false;
            this.changeUsernameButton.Click += new System.EventHandler(this.ChangeUsernameButton_Click);
            // 
            // changeEmailButton
            // 
            this.changeEmailButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changeEmailButton.FlatAppearance.BorderSize = 0;
            this.changeEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeEmailButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeEmailButton.Location = new System.Drawing.Point(40, 246);
            this.changeEmailButton.Name = "changeEmailButton";
            this.changeEmailButton.Size = new System.Drawing.Size(367, 36);
            this.changeEmailButton.TabIndex = 3;
            this.changeEmailButton.Text = "Change email";
            this.changeEmailButton.UseVisualStyleBackColor = false;
            this.changeEmailButton.Click += new System.EventHandler(this.ChangeEmailButton_Click);
            // 
            // changePassButton
            // 
            this.changePassButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changePassButton.FlatAppearance.BorderSize = 0;
            this.changePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePassButton.Location = new System.Drawing.Point(40, 186);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(367, 36);
            this.changePassButton.TabIndex = 2;
            this.changePassButton.Text = "Change password";
            this.changePassButton.UseVisualStyleBackColor = false;
            this.changePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 497);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button changeUsernameButton;
        private System.Windows.Forms.Button changeEmailButton;
        private System.Windows.Forms.Button deleteUserAccountButton;
        private System.Windows.Forms.Button logOutButton;
    }
}