namespace CommunityAppMiniProjectWinForms.Forms
{
    partial class CreateIssueForm
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
            CreateIssueTitleLabel = new Label();
            DescriptionLabel2 = new Label();
            IssueDescriptionTextbox = new TextBox();
            CreateIssueLocation = new Label();
            CreateIssueLocationTextbox = new TextBox();
            CreateIssuePicture = new Label();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            CreateIssuePostBtn = new Button();
            CreateIssueCloseBtn = new Button();
            CreateIssueClearImageBtn = new Button();
            CreateIssueUploadBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CreateIssueTitleLabel
            // 
            CreateIssueTitleLabel.AutoSize = true;
            CreateIssueTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CreateIssueTitleLabel.ForeColor = Color.Firebrick;
            CreateIssueTitleLabel.Location = new Point(241, 40);
            CreateIssueTitleLabel.Name = "CreateIssueTitleLabel";
            CreateIssueTitleLabel.Size = new Size(240, 32);
            CreateIssueTitleLabel.TabIndex = 3;
            CreateIssueTitleLabel.Text = "What issue is there?";
            // 
            // DescriptionLabel2
            // 
            DescriptionLabel2.AutoSize = true;
            DescriptionLabel2.Location = new Point(89, 98);
            DescriptionLabel2.Name = "DescriptionLabel2";
            DescriptionLabel2.Size = new Size(503, 25);
            DescriptionLabel2.TabIndex = 4;
            DescriptionLabel2.Text = "Describe the issue in a few words (pothole, flood, wildlife, etc):";
            // 
            // IssueDescriptionTextbox
            // 
            IssueDescriptionTextbox.Location = new Point(88, 141);
            IssueDescriptionTextbox.Name = "IssueDescriptionTextbox";
            IssueDescriptionTextbox.Size = new Size(466, 31);
            IssueDescriptionTextbox.TabIndex = 5;
            // 
            // CreateIssueLocation
            // 
            CreateIssueLocation.AutoSize = true;
            CreateIssueLocation.Location = new Point(89, 196);
            CreateIssueLocation.Name = "CreateIssueLocation";
            CreateIssueLocation.Size = new Size(173, 25);
            CreateIssueLocation.TabIndex = 6;
            CreateIssueLocation.Text = "What is the location:";
            // 
            // CreateIssueLocationTextbox
            // 
            CreateIssueLocationTextbox.Location = new Point(94, 234);
            CreateIssueLocationTextbox.Name = "CreateIssueLocationTextbox";
            CreateIssueLocationTextbox.Size = new Size(460, 31);
            CreateIssueLocationTextbox.TabIndex = 7;
            // 
            // CreateIssuePicture
            // 
            CreateIssuePicture.AutoSize = true;
            CreateIssuePicture.Location = new Point(89, 286);
            CreateIssuePicture.Name = "CreateIssuePicture";
            CreateIssuePicture.Size = new Size(229, 25);
            CreateIssuePicture.TabIndex = 8;
            CreateIssuePicture.Text = "Upload an image (optional)";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(103, 326);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 112);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // CreateIssuePostBtn
            // 
            CreateIssuePostBtn.Location = new Point(388, 347);
            CreateIssuePostBtn.Name = "CreateIssuePostBtn";
            CreateIssuePostBtn.Size = new Size(112, 34);
            CreateIssuePostBtn.TabIndex = 10;
            CreateIssuePostBtn.Text = "Post";
            CreateIssuePostBtn.UseVisualStyleBackColor = true;
            CreateIssuePostBtn.Click += CreateIssuePostBtn_Click;
            // 
            // CreateIssueCloseBtn
            // 
            CreateIssueCloseBtn.Location = new Point(536, 347);
            CreateIssueCloseBtn.Name = "CreateIssueCloseBtn";
            CreateIssueCloseBtn.Size = new Size(112, 34);
            CreateIssueCloseBtn.TabIndex = 11;
            CreateIssueCloseBtn.Text = "Exit";
            CreateIssueCloseBtn.UseVisualStyleBackColor = true;
            CreateIssueCloseBtn.Click += CreateIssueCloseBtn_Click;
            // 
            // CreateIssueClearImageBtn
            // 
            CreateIssueClearImageBtn.Location = new Point(103, 326);
            CreateIssueClearImageBtn.Name = "CreateIssueClearImageBtn";
            CreateIssueClearImageBtn.Size = new Size(20, 35);
            CreateIssueClearImageBtn.TabIndex = 12;
            CreateIssueClearImageBtn.Text = "X";
            CreateIssueClearImageBtn.UseVisualStyleBackColor = true;
            CreateIssueClearImageBtn.Click += CreateIssueClearImageBtn_Click;
            // 
            // CreateIssueUploadBtn
            // 
            CreateIssueUploadBtn.Font = new Font("Segoe UI", 7F);
            CreateIssueUploadBtn.Location = new Point(151, 370);
            CreateIssueUploadBtn.Name = "CreateIssueUploadBtn";
            CreateIssueUploadBtn.Size = new Size(61, 25);
            CreateIssueUploadBtn.TabIndex = 13;
            CreateIssueUploadBtn.Text = "Upload";
            CreateIssueUploadBtn.UseVisualStyleBackColor = true;
            CreateIssueUploadBtn.Click += CreateIssueUploadBtn_Click;
            // 
            // CreateIssueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateIssueUploadBtn);
            Controls.Add(CreateIssueClearImageBtn);
            Controls.Add(CreateIssueCloseBtn);
            Controls.Add(CreateIssuePostBtn);
            Controls.Add(pictureBox1);
            Controls.Add(CreateIssuePicture);
            Controls.Add(CreateIssueLocationTextbox);
            Controls.Add(CreateIssueLocation);
            Controls.Add(IssueDescriptionTextbox);
            Controls.Add(DescriptionLabel2);
            Controls.Add(CreateIssueTitleLabel);
            Name = "CreateIssueForm";
            Text = "CreateIssueForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateIssueTitleLabel;
        private Label DescriptionLabel2;
        private TextBox IssueDescriptionTextbox;
        private Label CreateIssueLocation;
        private TextBox CreateIssueLocationTextbox;
        private Label CreateIssuePicture;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button CreateIssuePostBtn;
        private Button CreateIssueCloseBtn;
        private Button CreateIssueClearImageBtn;
        private Button CreateIssueUploadBtn;
    }
}