using System;

public class Lecturer : Research_associate  {
	private Course courses;

	public Course GetCourses() {
		return this.courses;
	}
	public void SetCourses(ref Course courses) {
		this.courses = courses;
	}
	public void AddCourse(ref Course course) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void DeleteCourse(ref Course course) {
		throw new System.NotImplementedException("Not implemented");
	}
	public Lecturer(ref int ssNo, ref String name, ref String email) {
		throw new System.NotImplementedException("Not implemented");
	}

}
