using System;
namespace CommunityAppMiniProjectWinForms.Classes;
public class Issue
{
	private static int nextIssueId = 1;
	private int _IssueID { get; set; } //will likely increment starting from 1.
	private string _description { get; set; }
	private string _location { get; set; }
	private string _ImageFilePath { get; set; }
	private DateTime _DateTime { get; set; }
	private string _severity { get; set; }
	private IssueStatus _WorkStatus { get; set; }
	private string _UserReported { get; set; } //User that created the issue. Stores their id. 
	private int _NumofConfirmVotes { get; set; } //the number of users that agrees of the ongoing issue.
	private int _NumofCompleteVotes { get; set; } //the number of users who agree that the work order is completed.

    public Issue()
    {
        _WorkStatus = IssueStatus.Submitted;
    }

	//====================ACCESSORS========================
	public string Description
	{
		get { return _description; }
	}
    public string Location
    {
        get { return _location; }
    }

    public IssueStatus WorkStatus
    {
        get { return _WorkStatus; }
    }

	public int ConfirmVotes
	{
		get { return _NumofConfirmVotes; }
	}

	public DateTime DataTime
	{
		get {return _DateTime; }
	}
}
