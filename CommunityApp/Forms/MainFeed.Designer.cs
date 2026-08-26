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
            IssuesTitleLabel = new Label();
            FeedPanel = new FlowLayoutPanel();
            FeedPanel.SuspendLayout();
            SuspendLayout();
            // 
            // IssuesTitleLabel
            // 
            IssuesTitleLabel.AutoSize = true;
            IssuesTitleLabel.Dock = DockStyle.Fill;
            IssuesTitleLabel.Location = new Point(3, 0);
            IssuesTitleLabel.Name = "IssuesTitleLabel";
            IssuesTitleLabel.Size = new Size(233, 25);
            IssuesTitleLabel.TabIndex = 0;
            IssuesTitleLabel.Text = "What Issues have you seen?";
            // 
            // FeedPanel
            // 
            FeedPanel.AutoScroll = true;
            FeedPanel.Controls.Add(IssuesTitleLabel);
            FeedPanel.Dock = DockStyle.Fill;
            FeedPanel.FlowDirection = FlowDirection.TopDown;
            FeedPanel.Location = new Point(0, 0);
            FeedPanel.Name = "FeedPanel";
            FeedPanel.Size = new Size(800, 450);
            FeedPanel.TabIndex = 1;
            FeedPanel.WrapContents = false;
            // 
            // MainFeed
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FeedPanel);
            Name = "MainFeed";
            Text = "MainFeed";
            FeedPanel.ResumeLayout(false);
            FeedPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label IssuesTitleLabel;
        private FlowLayoutPanel FeedPanel;
    }
}