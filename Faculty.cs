using System;

public class Faculty {
	private Employee dean;
	private String name;
	private Institute institutes;

	public Employee GetDean() {
		return this.dean;
	}
	public void SetDean(ref Employee employee) {
		this.dean = employee;
	}
	public String GetName() {
		return this.name;
	}
	public void SetName(ref String name) {
		this.name = name;
	}
	public Institute GetInstitutes() {
		return this.institutes;
	}
	public void SetInstitutes(ref Institute institutes) {
		this.institutes = institutes;
	}
	public void AddInstitute(ref Institute institute) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void RemoveInstitute(ref Institute institute) {
		throw new System.NotImplementedException("Not implemented");
	}
	public Faculty(ref Employee dean, ref String name) {
		throw new System.NotImplementedException("Not implemented");
	}

	private University university;

	private Employee leads;

}
