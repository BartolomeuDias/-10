using System;

public class Project {
	private String name;
	private Date startDate;
	private Date endDate;

	public String GetName() {
		return this.name;
	}
	public void SetName(ref String name) {
		this.name = name;
	}
	public Date GetStartDate() {
		return this.startDate;
	}
	public void SetStartDate(ref Date startDate) {
		this.startDate = startDate;
	}
	public Date GetEndDate() {
		return this.endDate;
	}
	public void SetEndDate(ref Date endDate) {
		this.endDate = endDate;
	}

	private Research_associate[] research_associates;

}
