using System;

public class University {
	private String name;
	private Faculty faculties;

	public String GetName() {
		return this.name;
	}
	public void SetName(ref String name) {
		this.name = name;
	}
	public Faculty GetFaculties() {
		return this.faculties;
	}
	public void SetFaculties(ref Faculty faculties) {
		this.faculties = faculties;
	}
	public void AddFaculty(ref Faculty faculty) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void RemoveFaculty(ref Faculty faculty) {
		throw new System.NotImplementedException("Not implemented");
	}

	private Faculty[] facultys;

}
