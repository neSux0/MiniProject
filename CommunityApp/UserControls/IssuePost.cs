using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommunityAppMiniProjectWinForms.Classes;

namespace CommunityAppMiniProjectWinForms.Forms
{
    public partial class IssuePost : UserControl
    {
        public IssuePost(Issue issue)
        {
            InitializeComponent();

            DescriptionLabel.Text = issue.Description;
            LocationLabel.Text = issue.Location;
            StatusLabel.Text = issue.WorkStatus.ToString();
            PictureBox1.Image = issue.GetImage;
        }

    }
}
