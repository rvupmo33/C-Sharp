using System.Text.Json;

namespace CourseClass_SEC402;

class Program
{
    static void Main(string[] args)
    {
        List<Course> myCourses = new List<Course>();
        
        myCourses.Add(new Course("COMP100", "Intro to Programming", "Programming I", "None", 1));
        myCourses.Add(new Course("MATH101", "Calculus I", "Introduction to Calculus", "None", 1));
        myCourses.Add(new Course("PHYS101", "Physics I", "Fundamentals of Physics", "None", 1));
        myCourses.Add(new Course("CHEM101", "Chemistry I", "Basic Chemistry Concepts", "None", 1));
        myCourses.Add(new Course("ENG101", "English Composition", "Writing and Composition Skills", "None", 1));
        
        SaveCourses("ListOfCourses.json", myCourses);
        
        List<Course> mySavedCourse =ReadCourses("ListOfCourses.json");

        foreach (Course course in mySavedCourse)
        {
            Console.WriteLine(course.Name);
        }
        
    }
    public static void SaveCourses(string fileName, List<Course> listOfCourses)
    {
        StreamWriter writer = new StreamWriter(fileName);

        foreach (Course c in listOfCourses)
        {
            string courseJson = JsonSerializer.Serialize(c);
            writer.WriteLine(courseJson);
            Console.WriteLine(courseJson);
        }
        
        writer.Close();
    }

    public static List<Course> ReadCourses(string fileName)
    {
        List<Course> list = new List<Course>();
        
        StreamReader reader = new StreamReader(fileName);

        string line = reader.ReadLine();

        while (line != null)
        {
            Course c = JsonSerializer.Deserialize<Course>(line);
            list.Add(c);

            line = reader.ReadLine();
        }
        reader.Close();
        return list;
    }
    
    
}