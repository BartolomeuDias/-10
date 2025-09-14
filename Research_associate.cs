using System;

public class ResearchAssociate : Employee  {
	private string fieldOfStudy;
	private List<Project> projects;
    public ResearchAssociate(int ssNo, string name, string email, string fieldOfStudy)
    {
        this.ssNo = ssNo;
		this.name = name;
		this.email = email;
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
