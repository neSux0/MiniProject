using System;
using System.DirectoryServices;

public class User
{
	private int nextUserId = 1000; //id starts at 1000
	private int _UserId; //will likely be randomly generated for identification.
	private string _username { get; set; } //will prompt user to create
	private string _password { get; set; } //will promp user to create

    //Department privlege. If false, they are a community user. if true, they are department user.
    private bool _IsDepartment { get; set; } //Account Type
	public User(string username, string password)
	{
		_UserId = nextUserId++; //once assigned increment it.
		_username = username;
		_password = password;
	}

	//makes username readable.
	public string Username
	{
		get { return _username; }
	}
    //makes id readable.
    public int UserId
    {
        get { return _UserId; }
    }
}
