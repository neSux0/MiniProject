namespace CommunityAppMiniProjectWinForms.Forms
{
    partial class MainFeed
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
            FeedPanel = new FlowLayoutPanel();
            MainFeedTitleLabel = new Label();
            AddIssueBtn = new Button();
            SuspendLayout();
            // 
            // FeedPanel
            // 
            FeedPanel.AutoScroll = true;
            FeedPanel.FlowDirection = FlowDirection.TopDown;
            FeedPanel.Location = new Point(3, 68);
            FeedPanel.Name = "FeedPanel";
            FeedPanel.Size = new Size(800, 383);
            FeedPanel.TabIndex = 1;
            FeedPanel.WrapContents = false;
            // 
            // MainFeedTitleLabel
            // 
            MainFeedTitleLabel.AutoSize = true;
            MainFeedTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MainFeedTitleLabel.ForeColor = Color.Firebrick;
            MainFeedTitleLabel.Location = new Point(209, 19);
            MainFeedTitleLabel.Name = "MainFeedTitleLabel";
            MainFeedTitleLabel.Size = new Size(240, 32);
            MainFeedTitleLabel.TabIndex = 2;
            MainFeedTitleLabel.Text = "What issue is there?";
            // 
            // AddIssueBtn
            // 
            AddIssueBtn.Location = new Point(472, 19);
            AddIssueBtn.Name = "AddIssueBtn";
            AddIssueBtn.Size = new Size(112, 34);
            AddIssueBtn.TabIndex = 3;
            AddIssueBtn.Text = "Add";
            AddIssueBtn.UseVisualStyleBackColor = true;
            // 
            // MainFeed
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddIssueBtn);
            Controls.Add(MainFeedTitleLabel);
            Controls.Add(FeedPanel);
            Name = "MainFeed";
            Text = "MainFeed";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel FeedPanel;
        private Label MainFeedTitleLabel;
        private Button AddIssueBtn;
    }
}