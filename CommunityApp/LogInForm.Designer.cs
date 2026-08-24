namespace CommunityApp
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogInBtn = new Button();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextbox = new TextBox();
            LogInTitle = new Label();
            usernamepanel = new Panel();
            passwordpanel = new Panel();
            usernamepanel.SuspendLayout();
            passwordpanel.SuspendLayout();
            SuspendLayout();
            // 
            // LogInBtn
            // 
            LogInBtn.Location = new Point(326, 308);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(112, 34);
            LogInBtn.TabIndex = 0;
            LogInBtn.Text = "Log In";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(3, 3);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(196, 38);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "Username / ID";
            UserNameLabel.Click += UserNameLabel_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 14F);
            PasswordLabel.Location = new Point(3, 3);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(132, 38);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BorderStyle = BorderStyle.None;
            UserNameTextBox.Cursor = Cursors.IBeam;
            UserNameTextBox.Location = new Point(3, 14);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(276, 24);
            UserNameTextBox.TabIndex = 2;
            UserNameTextBox.Enter += UserNameTextBox_Enter;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BorderStyle = BorderStyle.None;
            PasswordTextbox.Location = new Point(8, 20);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(267, 24);
            PasswordTextbox.TabIndex = 4;
            PasswordTextbox.Enter += PasswordTextbox_Enter;
            // 
            // LogInTitle
            // 
            LogInTitle.AutoSize = true;
            LogInTitle.FlatStyle = FlatStyle.Flat;
            LogInTitle.Font = new Font("Arial Narrow", 20F, FontStyle.Bold);
            LogInTitle.ForeColor = Color.Firebrick;
            LogInTitle.Location = new Point(197, 103);
            LogInTitle.Name = "LogInTitle";
            LogInTitle.Size = new Size(405, 46);
            LogInTitle.TabIndex = 5;
            LogInTitle.Text = "Log Into The Community";
            // 
            // usernamepanel
            // 
            usernamepanel.BorderStyle = BorderStyle.FixedSingle;
            usernamepanel.Controls.Add(UserNameLabel);
            usernamepanel.Controls.Add(UserNameTextBox);
            usernamepanel.Cursor = Cursors.IBeam;
            usernamepanel.Location = new Point(251, 169);
            usernamepanel.Name = "usernamepanel";
            usernamepanel.Size = new Size(280, 47);
            usernamepanel.TabIndex = 6;
            // 
            // passwordpanel
            // 
            passwordpanel.BorderStyle = BorderStyle.FixedSingle;
            passwordpanel.Controls.Add(PasswordLabel);
            passwordpanel.Controls.Add(PasswordTextbox);
            passwordpanel.Cursor = Cursors.IBeam;
            passwordpanel.Location = new Point(251, 243);
            passwordpanel.Name = "passwordpanel";
            passwordpanel.Size = new Size(280, 47);
            passwordpanel.TabIndex = 7;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordpanel);
            Controls.Add(usernamepanel);
            Controls.Add(LogInBtn);
            Controls.Add(LogInTitle);
            Name = "LogInForm";
            Text = "LogInForm";
            usernamepanel.ResumeLayout(false);
            usernamepanel.PerformLayout();
            passwordpanel.ResumeLayout(false);
            passwordpanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogInBtn;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextbox;
        private Label LogInTitle;
        private Panel usernamepanel;
        private Panel passwordpanel;
    }
}
