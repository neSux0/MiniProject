using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using CommunityAppMiniProjectWinForms.Classes;
using CommunityAppMiniProjectWinForms.Data;

namespace CommunityAppMiniProjectWinForms.Forms
{
    public partial class IssuePost : UserControl
    {
        private Issue CurrIssue; //will be used to store the issue thats passed into issuepost.
        public IssuePost(Issue issue)
        {
            CurrIssue = issue;
            InitializeComponent();

            //assigns the data from the CURRENT issue to a control post.
            DescriptionDisplay.Text = CurrIssue.Description;
            LocationDisplay.Text = CurrIssue.Location;
            StatusDisplay.Text = CurrIssue.WorkStatus.ToString();
            CreateIssueTimeDisplay.Text = CurrIssue.CreatedAt.ToString();
            PictureBox1.Image = CurrIssue.GetImage;
            VoteCountDisplay.Text = CurrIssue.GetConfirmVoteCount.ToString();
        }

        private void AgreeBtn_Click(object sender, EventArgs e)
        {
            if(!CurrIssue.UserLiked.Contains(AppData.GetCurrentUser.Username))
            {
                CurrIssue.AddLikedUser(AppData.GetCurrentUser.Username);
            }
            else if(CurrIssue.UserLiked.Contains(AppData.GetCurrentUser.Username))
            {
                CurrIssue.RemoveLikedUser(AppData.GetCurrentUser.Username);
            }
            VoteCountDisplay.Text = CurrIssue.GetConfirmVoteCount.ToString();
        }
    }
}
