using System;

public class PublicUser : User
{
	private bool _VotedStatus = false;
	public PublicUser(string name, string password) : base(name,password)
	{

	}


	//=========Accessor==============
	public bool VotedStatus
	{
		get { return _VotedStatus; }
	}
}
