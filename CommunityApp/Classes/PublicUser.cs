using System;

public class PublicUser : User
{
	private bool _ConfirmedVotedStatus = false;
	private bool _CompletedVotedStatus = false;
	public PublicUser(string name, string password) : base(name,password)
	{

	}


	//=========Accessor==============
	public bool ConfirmedVotedStatus
	{
		get { return _ConfirmedVotedStatus; }
	}
    public bool CompletedVotedStatus
    {
        get { return _CompletedVotedStatus; }
    }
}
