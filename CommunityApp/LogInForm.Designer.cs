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
            LogInBtn.Location = new Point(308, 299);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(112, 34);
            LogInBtn.TabIndex = 0;
            LogInBtn.Text = "Log In";
            LogInBtn.UseVisualStyleBackColor = true;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(24, 0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(95, 25);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(27, 11);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(91, 25);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(13, 54);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(150, 31);
            UserNameTextBox.TabIndex = 3;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(17, 70);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(150, 31);
            PasswordTextbox.TabIndex = 4;
            // 
            // LogInTitle
            // 
            LogInTitle.AutoSize = true;
            LogInTitle.FlatStyle = FlatStyle.Flat;
            LogInTitle.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInTitle.ForeColor = Color.Firebrick;
            LogInTitle.Location = new Point(181, 104);
            LogInTitle.Name = "LogInTitle";
            LogInTitle.Size = new Size(363, 42);
            LogInTitle.TabIndex = 5;
            LogInTitle.Text = "Log Into The Community";
            // 
            // usernamepanel
            // 
            usernamepanel.Controls.Add(UserNameLabel);
            usernamepanel.Controls.Add(UserNameTextBox);
            usernamepanel.Location = new Point(599, 161);
            usernamepanel.Name = "usernamepanel";
            usernamepanel.Size = new Size(177, 107);
            usernamepanel.TabIndex = 6;
            // 
            // passwordpanel
            // 
            passwordpanel.Controls.Add(PasswordLabel);
            passwordpanel.Controls.Add(PasswordTextbox);
            passwordpanel.Location = new Point(450, 288);
            passwordpanel.Name = "passwordpanel";
            passwordpanel.Size = new Size(184, 123);
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
