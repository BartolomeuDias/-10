using System;
using System.Xml.Linq;

public class Faculty {
	private Employee dean;
	private string name;
	private List<Institute> institutes;

    public Faculty(Employee dean, string name)
    {
        Dean = dean;
        Name = name;
        institutes = new List<Institute>();
    }
	public Employee Dean
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
