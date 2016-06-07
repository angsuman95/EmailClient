namespace EmailProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.recipiantsTB = new System.Windows.Forms.TextBox();
            this.recipiantsLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTB = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.bodyTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.CredentialsGB = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CredentialsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipiantsTB
            // 
            this.recipiantsTB.Location = new System.Drawing.Point(5, 25);
            this.recipiantsTB.Multiline = true;
            this.recipiantsTB.Name = "recipiantsTB";
            this.recipiantsTB.Size = new System.Drawing.Size(231, 64);
            this.recipiantsTB.TabIndex = 0;
            this.toolTip1.SetToolTip(this.recipiantsTB, "When providing multiple email addresses you must separate each with a \';\'");
            // 
            // recipiantsLabel
            // 
            this.recipiantsLabel.AutoSize = true;
            this.recipiantsLabel.Location = new System.Drawing.Point(2, 7);
            this.recipiantsLabel.Name = "recipiantsLabel";
            this.recipiantsLabel.Size = new System.Drawing.Size(60, 13);
            this.recipiantsLabel.TabIndex = 1;
            this.recipiantsLabel.Text = "Recipiants:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(5, 99);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Subject:";
            // 
            // subjectTB
            // 
            this.subjectTB.Location = new System.Drawing.Point(57, 96);
            this.subjectTB.Name = "subjectTB";
            this.subjectTB.Size = new System.Drawing.Size(179, 20);
            this.subjectTB.TabIndex = 3;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(5, 124);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(34, 13);
            this.bodyLabel.TabIndex = 4;
            this.bodyLabel.Text = "Body:";
            // 
            // bodyTB
            // 
            this.bodyTB.Location = new System.Drawing.Point(8, 141);
            this.bodyTB.Multiline = true;
            this.bodyTB.Name = "bodyTB";
            this.bodyTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bodyTB.Size = new System.Drawing.Size(228, 208);
            this.bodyTB.TabIndex = 5;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(65, 19);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(157, 20);
            this.emailTB.TabIndex = 6;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(65, 51);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(157, 20);
            this.passwordTB.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(3, 54);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // CredentialsGB
            // 
            this.CredentialsGB.Controls.Add(this.emailLabel);
            this.CredentialsGB.Controls.Add(this.passwordTB);
            this.CredentialsGB.Controls.Add(this.passwordLabel);
            this.CredentialsGB.Controls.Add(this.emailTB);
            this.CredentialsGB.Location = new System.Drawing.Point(8, 355);
            this.CredentialsGB.Name = "CredentialsGB";
            this.CredentialsGB.Size = new System.Drawing.Size(228, 82);
            this.CredentialsGB.TabIndex = 10;
            this.CredentialsGB.TabStop = false;
            this.CredentialsGB.Text = "Credentials";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(3, 22);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email:";
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailButton.Image")));
            this.sendEmailButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendEmailButton.Location = new System.Drawing.Point(99, 443);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(137, 23);
            this.sendEmailButton.TabIndex = 11;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 473);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.CredentialsGB);
            this.Controls.Add(this.bodyTB);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.subjectTB);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.recipiantsLabel);
            this.Controls.Add(this.recipiantsTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Email Sender";
            this.CredentialsGB.ResumeLayout(false);
            this.CredentialsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recipiantsTB;
        private System.Windows.Forms.Label recipiantsLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTB;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.TextBox bodyTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.GroupBox CredentialsGB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button sendEmailButton;
    }
}

