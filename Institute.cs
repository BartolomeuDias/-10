using System;

public class Institute {

	private string name;
	private string address;
	private List<ResearchAssociate> employees;

    public Institute(string name, string address)
    {
		Name = name;
		Address = address;
    }
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	public string Address
    {
		get { return address; }
		set { address = value; }
	}
	public List<ResearchAssociate> GetEmployees() {
		return employees;
	}
	public void SetEmployees(List<ResearchAssociate> employees) {
		this.employees = employees;
	}
	public void HireEmployee(ResearchAssociate employee) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void FireEmployee(ResearchAssociate employee) {
		throw new System.NotImplementedException("Not implemented");
	}
}
