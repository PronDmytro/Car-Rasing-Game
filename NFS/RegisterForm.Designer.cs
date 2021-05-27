
namespace NFS
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logInLabel = new System.Windows.Forms.Label();
            this.passErrorLabel = new System.Windows.Forms.Label();
            this.passErrorPicture = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorPicture = new System.Windows.Forms.PictureBox();
            this.confirmPassField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.logInLabel);
            this.panel1.Controls.Add(this.passErrorLabel);
            this.panel1.Controls.Add(this.passErrorPicture);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.errorPicture);
            this.panel1.Controls.Add(this.confirmPassField);
            this.panel1.Controls.Add(this.emailField);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.ButtonRegister);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 497);
            this.panel1.TabIndex = 1;
            // 
            // logInLabel
            // 
            this.logInLabel.AutoSize = true;
            this.logInLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logInLabel.Location = new System.Drawing.Point(133, 468);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(191, 19);
            this.logInLabel.TabIndex = 16;
            this.logInLabel.Text = "Already have an account?";
            this.logInLabel.Click += new System.EventHandler(this.LogInLabel_Click);
            // 
            // passErrorLabel
            // 
            this.passErrorLabel.AutoSize = true;
            this.passErrorLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passErrorLabel.Location = new System.Drawing.Point(133, 249);
            this.passErrorLabel.Name = "passErrorLabel";
            this.passErrorLabel.Size = new System.Drawing.Size(197, 14);
            this.passErrorLabel.TabIndex = 15;
            this.passErrorLabel.Text = "The passwords fields do not match";
            this.passErrorLabel.Visible = false;
            // 
            // passErrorPicture
            // 
            this.passErrorPicture.Image = global::NFS.Properties.Resources.error;
            this.passErrorPicture.Location = new System.Drawing.Point(111, 247);
            this.passErrorPicture.Name = "passErrorPicture";
            this.passErrorPicture.Size = new System.Drawing.Size(16, 16);
            this.passErrorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passErrorPicture.TabIndex = 14;
            this.passErrorPicture.TabStop = false;
            this.passErrorPicture.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(133, 364);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(191, 14);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.Text = "Please enter a valid email address";
            this.errorLabel.Visible = false;
            // 
            // errorPicture
            // 
            this.errorPicture.Image = global::NFS.Properties.Resources.error;
            this.errorPicture.Location = new System.Drawing.Point(111, 362);
            this.errorPicture.Name = "errorPicture";
            this.errorPicture.Size = new System.Drawing.Size(16, 16);
            this.errorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorPicture.TabIndex = 12;
            this.errorPicture.TabStop = false;
            this.errorPicture.Visible = false;
            // 
            // confirmPassField
            // 
            this.confirmPassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPassField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.confirmPassField.Location = new System.Drawing.Point(110, 266);
            this.confirmPassField.MaxLength = 18;
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.Size = new System.Drawing.Size(297, 33);
            this.confirmPassField.TabIndex = 3;
            this.confirmPassField.Text = "Confirm Password";
            this.confirmPassField.TextChanged += new System.EventHandler(this.CheckPassFields);
            this.confirmPassField.Enter += new System.EventHandler(this.ConfirmPassField_Enter);
            this.confirmPassField.Leave += new System.EventHandler(this.ConfirmPassField_Leave);
            // 
            // emailField
            // 
            this.emailField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailField.Location = new System.Drawing.Point(110, 328);
            this.emailField.MaxLength = 32;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(297, 33);
            this.emailField.TabIndex = 5;
            this.emailField.Text = "Email";
            this.emailField.TextChanged += new System.EventHandler(this.EmailField_TextChanged);
            this.emailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.emailField.Leave += new System.EventHandler(this.EmailField_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NFS.Properties.Resources.mail;
            this.pictureBox3.Location = new System.Drawing.Point(40, 317);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.DarkOrange;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonRegister.Location = new System.Drawing.Point(40, 416);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(367, 36);
            this.ButtonRegister.TabIndex = 5;
            this.ButtonRegister.Text = "Register Now";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // passField
            // 
            this.passField.AccessibleDescription = "";
            this.passField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passField.Location = new System.Drawing.Point(110, 213);
            this.passField.MaxLength = 18;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(297, 33);
            this.passField.TabIndex = 2;
            this.passField.Text = "Password";
            this.passField.TextChanged += new System.EventHandler(this.CheckPassFields);
            this.passField.Enter += new System.EventHandler(this.PassField_Enter);
            this.passField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NFS.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(40, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // userNameField
            // 
            this.userNameField.BackColor = System.Drawing.SystemColors.Window;
            this.userNameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userNameField.Location = new System.Drawing.Point(110, 139);
            this.userNameField.MaxLength = 18;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(297, 33);
            this.userNameField.TabIndex = 1;
            this.userNameField.Text = "Name";
            this.userNameField.TextChanged += new System.EventHandler(this.CheckFields);
            this.userNameField.Enter += new System.EventHandler(this.UserNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.UserNameField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NFS.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(40, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 75);
            this.panel2.TabIndex = 1;
            // 
            // LabelClose
            // 
            this.LabelClose.AutoSize = true;
            this.LabelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClose.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelClose.Location = new System.Drawing.Point(417, 8);
            this.LabelClose.Name = "LabelClose";
            this.LabelClose.Size = new System.Drawing.Size(22, 25);
            this.LabelClose.TabIndex = 7;
            this.LabelClose.Text = "x";
            this.LabelClose.Click += new System.EventHandler(this.LabelClose_Click);
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
            this.label1.Text = "Register";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 495);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPassField;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox errorPicture;
        private System.Windows.Forms.Label passErrorLabel;
        private System.Windows.Forms.PictureBox passErrorPicture;
        private System.Windows.Forms.Label logInLabel;
    }
}