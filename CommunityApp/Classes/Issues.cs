using System;
namespace CommunityAppMiniProjectWinForms.Classes;
public class Issues
{
	private static int nextIssueId = 1;
	private int _IssueID { get; set; } //will likely increment starting from 1.
	private string _description { get; set; }
	private string _location { get; set; }
	private string _ImageFilePath { get; set; }
	private DateTime _DataTime { get; set; }
	private string _severity { get; set; }
	private IssueStatus _WorkStatus { get; set; }
	private int _UserReported { get; set; } //User that created the issue. Stores their id. 
	private int _NumofConfirmVotes { get; set; } //the number of users that agrees of the ongoing issue.
	private int _NumofCompleteVotes { get; set; } //the number of users who agree that the work order is completed.


}
