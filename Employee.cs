using System;

public abstract class Employee {

    protected int ssNo;
    protected string name;
    protected string email;
	static int counter;

    protected Employee(string name, string email)
    {
        counter++;
        this.ssNo = counter; 
        this.name = name;
        this.email = email;
    }
    public int SsNo
	{
        get { return ssNo; }
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
