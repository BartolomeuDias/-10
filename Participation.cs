using System;

public class Participation {
	private int hours;
	private ResearchAssociate researchAssociate;
	private Project project;

	public int GetHours() {
		return this.hours;
	}
	public void SetHours(ref int hours) {
		this.hours = hours;
	}
	public ResearchAssociate GetResearchAssociate() {
		return this.researchAssociate;
	}
	public void SetResearchAssociate(ref ResearchAssociate researchAssociate) {
		this.researchAssociate = researchAssociate;
	}
	public Project GetProject() {
		return this.project;
	}
	public void SetProject(ref Project project) {
		this.project = project;
	}

}
