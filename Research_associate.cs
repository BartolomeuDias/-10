using System;

public class ResearchAssociate : Employee  {
	private string fieldOfStudy;
	private List<Project> projects;
    public ResearchAssociate(string name, string email, string fieldOfStudy): base(name, email)
    {
		this.fieldOfStudy = fieldOfStudy;
    }
	public string FieldOfStudy
    {
		get { return fieldOfStudy; }
		set { fieldOfStudy = value; }
	}
	public List<Project> Projects
    {
		get { return projects; }
		set { projects = value; }
	}
	public void StartProject(Project project) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void FinishProject(Project project) {
		throw new System.NotImplementedException("Not implemented");
	}
}
