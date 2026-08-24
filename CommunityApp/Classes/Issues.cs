using System;

public class Issues
{
	private int _IssueID { get; set; } //will likely increment starting from 1.
	private string _description { get; set; }
	private string _location { get; set; }
	private string _ImageFilePath { get; set; }
	public DateTime _DataTime { get; set; }
	public string _severity { get; set; }
	public string _WorkStatus { get; set; }
	private int _UserReported { get; set; } //User that created the issue. Stores their id. 
	public int _NumofConfirmVotes { get; set; } //the number of users that agrees of the ongoing issue.
	public int _NumofCompleteVotes { get; set; } //the number of users who agree that the work order is completed.


	public Issues()
	{
		_WorkStatus = "pending";
	}
}
