using System;

public class University {
	private string name;
	private List<Faculty> faculties;

	public University(string name)
	{
		this.name = name;
	}
	public string Name
    {
		get { return name; }
		set { name = value; }
	}
	public List<Faculty> Faculties
    {
		get { return faculties; }
		set { faculties = value; }
	}
	public void AddFaculty(Faculty faculty) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void RemoveFaculty(Faculty faculty) {
		throw new System.NotImplementedException("Not implemented");
	}
}
