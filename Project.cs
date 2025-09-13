using System;

public class Project {
	private string name;
	private DateTime startDate;
	private DateTime endDate;
	public string Name
    {
		get { return name; }
		set { name = value; }
	}
	public DateTime StartDate
    {
		get { return startDate; }
		set { startDate = value; }
	}
	public DateTime EndDate
    {
		get { return endDate; }
		set { endDate = value; }
	}
}
