namespace CourseClass_SEC402;

public class Course
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public string Prerequisites { get; set; }
    public int Semester { get; set; }

    public Course(string code, string description, string name, string prerequisites, int semester)
    {
        Code = code;
        Description = description;
        Name = name;
        Prerequisites = prerequisites;
        Semester = semester;
    }
}