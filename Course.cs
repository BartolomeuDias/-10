using System;

public class Course {
	private int id;
	private String name;
	private float weeklyDuration;

	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public String GetName() {
		return this.name;
	}
	public void SetName(ref String name) {
		this.name = name;
	}
	public float GetWeeklyDuration() {
		return this.weeklyDuration;
	}
	public void SetWeeklyDuration(ref float weeklyDuration) {
		this.weeklyDuration = weeklyDuration;
	}

	private Lecturer[] lecturers;

}
