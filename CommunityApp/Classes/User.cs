using System;
using System.DirectoryServices;

public class User
{
	private int nextUserId = 1000; //id starts at 1000
	private int _UserId { get; set; } //will likely be randomly generated for identification.
	private string _username { get; set; } //will prompt user to create
	private string _password { get; set; } //will promp user to create

    //Department privlege. Set to fault on default. If false, they are a community user. if true, they are department user.
    bool IsDepartment { get; set; } = false; //Account Type
	public User(int id, string username, string password)
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
