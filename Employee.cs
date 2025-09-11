using System;

public abstract class Employee {

    protected int ssNo;
    protected string name;
    protected string email;
	protected int counter;

	public int SsNo
	{
		get { return ssNo; }
		set { ssNo = value; }
	}
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	public string Email
	{
		get { return email; }
		set { email = value; }
	}
	public int Counter
	{
		get { return counter; }
		set { counter = value; }
	}
}
