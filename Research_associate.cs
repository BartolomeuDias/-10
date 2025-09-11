using System;

public class Research_associate : Employee  {
	private String fieldOfStudy;
	private Project projects;

	public String GetFieldOfStudy() {
		return this.fieldOfStudy;
	}
	public void SetFieldOfStudy(ref String fieldOfStudy) {
		this.fieldOfStudy = fieldOfStudy;
	}
	public Project GetProjects() {
		return this.projects;
	}
	public void SetProjects(ref Project projects) {
		this.projects = projects;
	}
	public void StartProject(ref Project project) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void FinishProject(ref Project project) {
		throw new System.NotImplementedException("Not implemented");
	}
	public Research_associate(ref int ssNo, ref String name, ref String email) {
		throw new System.NotImplementedException("Not implemented");
	}

	private Institute[] institutes;

}
