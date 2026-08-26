using CommunityAppMiniProjectWinForms.Classes;
using CommunityAppMiniProjectWinForms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommunityAppMiniProjectWinForms.Forms
{
    public partial class MainFeed : Form
    {
        public MainFeed()
        {
            InitializeComponent();
            LoadIssues();
        }

        private void LoadIssues()
        {
            foreach (Issue issue in AppData.IssuesList)
            {
                IssuePost post = new IssuePost(issue);

                FeedPanel.Controls.Add(post);
            }
        }

    }
}
