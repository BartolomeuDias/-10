using System;

public class Participation {
	private int hours;
	private ResearchAssociate researchAssociate;
	private Project project;
	public int Hours
	{
		get { return hours; }
		set { hours = value; }
	}
	public ResearchAssociate ResearchAssociate
    {
		get { return researchAssociate; }
		set { researchAssociate = value; }
	}
	public Project Project
    {
		get { return project; }
		set { project = value; }
	}
}
