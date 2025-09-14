using System;

public class Lecturer : ResearchAssociate  {
	private List<Course> courses;
    public Lecturer(string name, string email, string fieldOfStudy):base(name, email, fieldOfStudy)
    {

    }
	public List<Course> Courses
    {
		get { return courses; }
		set { courses = value; }
	}
	public void AddCourse(Course course) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void DeleteCourse(Course course) {
		throw new System.NotImplementedException("Not implemented");
	}
}
