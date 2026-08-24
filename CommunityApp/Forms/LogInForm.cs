namespace CommunityApp
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void UserNameTextBox_Enter(object sender, EventArgs e)
        {
            //This brings the username text label to the upper top of textbox.
            UserNameLabel.Top = 4;
            UserNameLabel.Font = new Font(UserNameLabel.Font.FontFamily, 6, FontStyle.Bold);

            UserNameTextBox.Top = 20;
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Focus();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
            PasswordTextbox.Focus();
        }

        private void PasswordTextbox_Enter(object sender, EventArgs e)
        {
            //This brings the password text label to the upper top of textbox.
            PasswordLabel.Top = 4;
            PasswordLabel.Font = new Font(PasswordLabel.Font.FontFamily, 6, FontStyle.Bold);

            PasswordTextbox.Top = 20;
        }






        //=============HELPER METHOD==================================//
    }
}
