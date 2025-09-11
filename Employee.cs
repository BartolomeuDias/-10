using System;

public abstract class Employee {
	private String ssNo;
	private String name;
	private String email;
	protected static_int counter;

	public int GetSsNo() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetSsNo(ref int ssNo) {
		throw new System.NotImplementedException("Not implemented");
	}
	public String GetName() {
		return this.name;
	}
	public void SetName(ref String name) {
		this.name = name;
	}
	public String GetEmail() {
		return this.email;
	}
	public void SetEmail(ref String email) {
		this.email = email;
	}

	private Faculty leads;

}
