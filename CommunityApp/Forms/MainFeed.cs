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
            FeedPanel.Controls.Clear(); //this needs to be added to prevent duplicates posting.
            foreach (Issue issue in AppData.IssuesList)
            {
                IssuePost post = new IssuePost(issue);
                FeedPanel.Controls.Add(post);
            }
        }

        private void AddIssueBtn_Click(object sender, EventArgs e)
        {
            CreateIssueForm createForm = new CreateIssueForm();

            createForm.ShowDialog();

            LoadIssues(); //once the create form closes, it reloads the issues.
        }
    }
}
