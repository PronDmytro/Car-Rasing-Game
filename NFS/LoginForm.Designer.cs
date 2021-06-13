
namespace NFS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.forgotPassLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorPicture = new System.Windows.Forms.PictureBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.signUpLabel);
            this.panel1.Controls.Add(this.forgotPassLabel);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.errorPicture);
            this.panel1.Controls.Add(this.ButtonLogin);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.loginField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 497);
            this.panel1.TabIndex = 0;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpLabel.Location = new System.Drawing.Point(132, 466);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(174, 19);
            this.signUpLabel.TabIndex = 13;
            this.signUpLabel.Text = "Don\'t have an account?";
            this.signUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // forgotPassLabel
            // 
            this.forgotPassLabel.AutoSize = true;
            this.forgotPassLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotPassLabel.Location = new System.Drawing.Point(110, 285);
            this.forgotPassLabel.Name = "forgotPassLabel";
            this.forgotPassLabel.Size = new System.Drawing.Size(129, 18);
            this.forgotPassLabel.TabIndex = 12;
            this.forgotPassLabel.Text = "Forgot Password?";
            this.forgotPassLabel.Click += new System.EventHandler(this.ForgotPassLabel_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(132, 175);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(191, 14);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "Please enter a valid email address";
            this.errorLabel.Visible = false;
            // 
            // errorPicture
            // 
            this.errorPicture.Image = global::NFS.Properties.Resources.error;
            this.errorPicture.Location = new System.Drawing.Point(110, 173);
            this.errorPicture.Name = "errorPicture";
            this.errorPicture.Size = new System.Drawing.Size(16, 16);
            this.errorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorPicture.TabIndex = 10;
            this.errorPicture.TabStop = false;
            this.errorPicture.Visible = false;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLogin.Location = new System.Drawing.Point(40, 412);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(367, 36);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passField.Location = new System.Drawing.Point(110, 245);
            this.passField.MaxLength = 18;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(297, 33);
            this.passField.TabIndex = 3;
            this.passField.Text = "Password";
            this.passField.TextChanged += new System.EventHandler(this.PassField_TextChanged);
            this.passField.Enter += new System.EventHandler(this.PassField_Enter);
            this.passField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NFS.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(40, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginField.Location = new System.Drawing.Point(110, 139);
            this.loginField.MaxLength = 32;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(297, 33);
            this.loginField.TabIndex = 2;
            this.loginField.Text = "Email";
            this.loginField.TextChanged += new System.EventHandler(this.LoginField_TextChanged);
            this.loginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.LoginField_Leave);
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
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 493);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelClose;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox errorPicture;
        private System.Windows.Forms.Label forgotPassLabel;
        private System.Windows.Forms.Label signUpLabel;
    }
}