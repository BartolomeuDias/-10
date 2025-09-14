using System;
using System.Xml.Linq;

public class Faculty {
	private Dean dean;
	private string name;
	private List<Institute> institutes;

    public Faculty(string name, Dean dean)
    {
        Dean = dean;
        Name = name;
        institutes = new List<Institute>();
    }
	public Dean Dean
	{
		get { return dean; }
		set { dean = value; }
	}
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	public List<Institute> GetInstitutes() {
		return this.institutes;
	}
	public void SetInstitutes(List<Institute> institutes) {
		this.institutes = institutes;
	}
	public void AddInstitute(ref Institute institute) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void RemoveInstitute(ref Institute institute) {
		throw new System.NotImplementedException("Not implemented");
	}
}
