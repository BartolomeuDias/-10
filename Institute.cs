using System;

public class Institute {
	private String name;
	private String address;
	private ResearchAssociate employees;

	public String GetName() {
		return this.name;
	}
	public void SetName(ref String name) {
		this.name = name;
	}
	public String GetAddress() {
		return this.address;
	}
	public void SetAddress(ref String address) {
		this.address = address;
	}
	public ResearchAssociate GetEmployees() {
		return this.employees;
	}
	public void SetEmployees(ref ResearchAssociate employees) {
		this.employees = employees;
	}
	public void HireEmployee(ref ResearchAssociate employee) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void FireEmployee(ref ResearchAssociate employee) {
		throw new System.NotImplementedException("Not implemented");
	}
	public Institute(ref String name, ref String address) {
		throw new System.NotImplementedException("Not implemented");
	}

	private Faculty faculty;

	private Research_associate[] research_associates;

}
