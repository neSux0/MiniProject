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
            pictureBox1 = new PictureBox();
            DescriptionLabel = new Label();
            LocationLabel = new Label();
            StatusLabel = new Label();
            ConfirmLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            UploadBtn = new Button();
            AgreeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(106, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 157);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(33, 246);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(106, 25);
            DescriptionLabel.TabIndex = 1;
            DescriptionLabel.Text = "Description:";
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Location = new Point(56, 283);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(83, 25);
            LocationLabel.TabIndex = 2;
            LocationLabel.Text = "Location:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(73, 322);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(64, 25);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // ConfirmLabel
            // 
            ConfirmLabel.AutoSize = true;
            ConfirmLabel.Location = new Point(6, 362);
            ConfirmLabel.Name = "ConfirmLabel";
            ConfirmLabel.Size = new Size(133, 25);
            ConfirmLabel.TabIndex = 4;
            ConfirmLabel.Text = "Confirm Count:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // UploadBtn
            // 
            UploadBtn.BackColor = SystemColors.Window;
            UploadBtn.Location = new Point(136, 209);
            UploadBtn.Name = "UploadBtn";
            UploadBtn.Size = new Size(161, 34);
            UploadBtn.TabIndex = 5;
            UploadBtn.Text = "Upload Image";
            UploadBtn.UseVisualStyleBackColor = false;
            // 
            // AgreeBtn
            // 
            AgreeBtn.BackColor = SystemColors.Window;
            AgreeBtn.Location = new Point(330, 209);
            AgreeBtn.Name = "AgreeBtn";
            AgreeBtn.Size = new Size(112, 34);
            AgreeBtn.TabIndex = 6;
            AgreeBtn.Text = "Confirm";
            AgreeBtn.UseVisualStyleBackColor = false;
            // 
            // IssuePost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AgreeBtn);
            Controls.Add(UploadBtn);
            Controls.Add(ConfirmLabel);
            Controls.Add(StatusLabel);
            Controls.Add(LocationLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(pictureBox1);
            Name = "IssuePost";
            Size = new Size(625, 425);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label DescriptionLabel;
        private Label LocationLabel;
        private Label StatusLabel;
        private Label ConfirmLabel;
        private OpenFileDialog openFileDialog1;
        private Button UploadBtn;
        private Button AgreeBtn;
    }
}
