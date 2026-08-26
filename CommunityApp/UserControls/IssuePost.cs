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

            //assigns the data from the CURRENT issue to a control post.
            DescriptionDisplay.Text = issue.Description;
            LocationDisplay.Text = issue.Location;
            StatusDisplay.Text = issue.WorkStatus.ToString();
            CreateIssueTimeDisplay.Text = issue.CreatedAt.ToString();
            PictureBox1.Image = issue.GetImage;
        }

    }
}
