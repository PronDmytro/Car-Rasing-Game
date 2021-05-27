
namespace NFS
{
    partial class PasswordChangeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmNewPassField = new System.Windows.Forms.TextBox();
            this.passErrorLabel = new System.Windows.Forms.Label();
            this.passErrorPicture = new System.Windows.Forms.PictureBox();
            this.newPassField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.confirmNewPassField);
            this.panel1.Controls.Add(this.passErrorLabel);
            this.panel1.Controls.Add(this.passErrorPicture);
            this.panel1.Controls.Add(this.newPassField);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.NoButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 357);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // confirmNewPassField
            // 
            this.confirmNewPassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmNewPassField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmNewPassField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.confirmNewPassField.Location = new System.Drawing.Point(110, 195);
            this.confirmNewPassField.MaxLength = 18;
            this.confirmNewPassField.Name = "confirmNewPassField";
            this.confirmNewPassField.Size = new System.Drawing.Size(297, 33);
            this.confirmNewPassField.TabIndex = 3;
            this.confirmNewPassField.Text = "Confirm New Password";
            this.confirmNewPassField.TextChanged += new System.EventHandler(this.CheckPassFields);
            this.confirmNewPassField.Enter += new System.EventHandler(this.ConfirmNewPassField_Enter);
            this.confirmNewPassField.Leave += new System.EventHandler(this.ConfirmNewPassField_Leave);
            // 
            // passErrorLabel
            // 
            this.passErrorLabel.AutoSize = true;
            this.passErrorLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passErrorLabel.Location = new System.Drawing.Point(132, 178);
            this.passErrorLabel.Name = "passErrorLabel";
            this.passErrorLabel.Size = new System.Drawing.Size(197, 14);
            this.passErrorLabel.TabIndex = 20;
            this.passErrorLabel.Text = "The passwords fields do not match";
            this.passErrorLabel.Visible = false;
            this.passErrorLabel.Click += new System.EventHandler(this.passErrorLabel_Click);
            // 
            // passErrorPicture
            // 
            this.passErrorPicture.Image = global::NFS.Properties.Resources.error;
            this.passErrorPicture.Location = new System.Drawing.Point(110, 176);
            this.passErrorPicture.Name = "passErrorPicture";
            this.passErrorPicture.Size = new System.Drawing.Size(16, 16);
            this.passErrorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passErrorPicture.TabIndex = 19;
            this.passErrorPicture.TabStop = false;
            this.passErrorPicture.Visible = false;
            this.passErrorPicture.Click += new System.EventHandler(this.passErrorPicture_Click);
            // 
            // newPassField
            // 
            this.newPassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.newPassField.Location = new System.Drawing.Point(110, 142);
            this.newPassField.MaxLength = 18;
            this.newPassField.Name = "newPassField";
            this.newPassField.Size = new System.Drawing.Size(297, 33);
            this.newPassField.TabIndex = 2;
            this.newPassField.Text = "New Password";
            this.newPassField.TextChanged += new System.EventHandler(this.CheckPassFields);
            this.newPassField.Enter += new System.EventHandler(this.NewPassField_Enter);
            this.newPassField.Leave += new System.EventHandler(this.NewPassField_Leave);
            // 
            // passField
            // 
            this.passField.AccessibleDescription = "";
            this.passField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passField.Location = new System.Drawing.Point(110, 103);
            this.passField.MaxLength = 18;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(297, 33);
            this.passField.TabIndex = 1;
            this.passField.Text = "Password";
            this.passField.TextChanged += new System.EventHandler(this.passField_TextChanged);
            this.passField.Enter += new System.EventHandler(this.PassField_Enter);
            this.passField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NFS.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(40, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.DarkOrange;
            this.OkButton.Enabled = false;
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OkButton.Location = new System.Drawing.Point(243, 281);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(164, 36);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "Confirm";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.DarkOrange;
            this.NoButton.FlatAppearance.BorderSize = 0;
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoButton.Location = new System.Drawing.Point(40, 281);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(164, 36);
            this.NoButton.TabIndex = 4;
            this.NoButton.Text = "Cancel";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 75);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 357);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PasswordChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordChangeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordChangeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label passErrorLabel;
        private System.Windows.Forms.PictureBox passErrorPicture;
        private System.Windows.Forms.TextBox newPassField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox confirmNewPassField;
    }
}