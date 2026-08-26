namespace CommunityAppMiniProjectWinForms.Forms
{
    partial class IssuePost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBox1 = new PictureBox();
            DescriptionLabel = new Label();
            LocationLabel = new Label();
            StatusLabel = new Label();
            AgreeBtn = new Button();
            StatusDisplay = new Label();
            VoteCountDisplay = new Label();
            DescriptionDisplay = new Label();
            LocationDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Location = new Point(73, 32);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(479, 205);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.ForeColor = Color.Firebrick;
            DescriptionLabel.Location = new Point(124, 303);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(106, 25);
            DescriptionLabel.TabIndex = 1;
            DescriptionLabel.Text = "Description:";
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.ForeColor = Color.Firebrick;
            LocationLabel.Location = new Point(147, 348);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(83, 25);
            LocationLabel.TabIndex = 2;
            LocationLabel.Text = "Location:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.ForeColor = Color.Firebrick;
            StatusLabel.Location = new Point(166, 255);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(64, 25);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // AgreeBtn
            // 
            AgreeBtn.BackColor = SystemColors.Window;
            AgreeBtn.FlatAppearance.BorderSize = 0;
            AgreeBtn.FlatStyle = FlatStyle.Flat;
            AgreeBtn.ForeColor = SystemColors.ActiveCaptionText;
            AgreeBtn.Location = new Point(73, 250);
            AgreeBtn.Name = "AgreeBtn";
            AgreeBtn.Size = new Size(30, 34);
            AgreeBtn.TabIndex = 6;
            AgreeBtn.Text = "👍";
            AgreeBtn.UseVisualStyleBackColor = false;
            // 
            // StatusDisplay
            // 
            StatusDisplay.AutoSize = true;
            StatusDisplay.Location = new Point(249, 255);
            StatusDisplay.Name = "StatusDisplay";
            StatusDisplay.Size = new Size(19, 25);
            StatusDisplay.TabIndex = 11;
            StatusDisplay.Text = "-";
            // 
            // VoteCountDisplay
            // 
            VoteCountDisplay.AutoSize = true;
            VoteCountDisplay.Location = new Point(99, 255);
            VoteCountDisplay.Name = "VoteCountDisplay";
            VoteCountDisplay.Size = new Size(22, 25);
            VoteCountDisplay.TabIndex = 12;
            VoteCountDisplay.Text = "0";
            // 
            // DescriptionDisplay
            // 
            DescriptionDisplay.AutoSize = true;
            DescriptionDisplay.Location = new Point(249, 304);
            DescriptionDisplay.Name = "DescriptionDisplay";
            DescriptionDisplay.Size = new Size(19, 25);
            DescriptionDisplay.TabIndex = 13;
            DescriptionDisplay.Text = "-";
            // 
            // LocationDisplay
            // 
            LocationDisplay.AutoSize = true;
            LocationDisplay.Location = new Point(249, 348);
            LocationDisplay.Name = "LocationDisplay";
            LocationDisplay.Size = new Size(19, 25);
            LocationDisplay.TabIndex = 14;
            LocationDisplay.Text = "-";
            // 
            // IssuePost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(LocationDisplay);
            Controls.Add(DescriptionDisplay);
            Controls.Add(VoteCountDisplay);
            Controls.Add(StatusDisplay);
            Controls.Add(AgreeBtn);
            Controls.Add(StatusLabel);
            Controls.Add(LocationLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(PictureBox1);
            Name = "IssuePost";
            Size = new Size(625, 425);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureBox1;
        private Label DescriptionLabel;
        private Label LocationLabel;
        private Label StatusLabel;
        private Button AgreeBtn;
        private RichTextBox richTextBox1;
        private Label StatusDisplay;
        private Label VoteCountDisplay;
        private Label DescriptionDisplay;
        private Label LocationDisplay;
    }
}
