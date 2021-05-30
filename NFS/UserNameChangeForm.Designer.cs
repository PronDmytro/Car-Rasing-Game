
namespace NFS
{
    partial class UserNameChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserNameChangeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmPassField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(440, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.confirmPassField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.NoButton);
            this.panel1.Controls.Add(this.nameField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 363);
            this.panel1.TabIndex = 1;
            // 
            // confirmPassField
            // 
            this.confirmPassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPassField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.confirmPassField.Location = new System.Drawing.Point(110, 194);
            this.confirmPassField.MaxLength = 18;
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.Size = new System.Drawing.Size(297, 33);
            this.confirmPassField.TabIndex = 2;
            this.confirmPassField.Text = "Confirm Password";
            this.confirmPassField.TextChanged += new System.EventHandler(this.CheckFields);
            this.confirmPassField.Enter += new System.EventHandler(this.ConfirmPassField_Enter);
            this.confirmPassField.Leave += new System.EventHandler(this.ConfirmPassField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NFS.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(40, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.DarkOrange;
            this.OkButton.Enabled = false;
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OkButton.Location = new System.Drawing.Point(243, 287);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(164, 36);
            this.OkButton.TabIndex = 4;
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
            this.NoButton.Location = new System.Drawing.Point(40, 287);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(164, 36);
            this.NoButton.TabIndex = 3;
            this.NoButton.Text = "Cancel";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameField.Location = new System.Drawing.Point(110, 106);
            this.nameField.MaxLength = 32;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(297, 33);
            this.nameField.TabIndex = 1;
            this.nameField.Text = "New Name";
            this.nameField.TextChanged += new System.EventHandler(this.CheckFields);
            this.nameField.Enter += new System.EventHandler(this.NameField_Enter);
            this.nameField.Leave += new System.EventHandler(this.NameField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NFS.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(40, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 75);
            this.panel2.TabIndex = 1;
            // 
            // UserNameChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 363);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserNameChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserName Change";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserNameChangeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox confirmPassField;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}