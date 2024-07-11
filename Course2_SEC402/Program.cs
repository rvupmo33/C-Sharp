using System.Text.Json;

namespace Course2_SEC402;

class Program
{
    static void Main(string[] args)
    {

        List<Course> myCourses = new List<Course>();

        myCourses.Add( new Course("COMP100", "Intro to Programming", "Programming 1","",1));
        myCourses.Add(new Course("COMP200", "Data Structures", "Advanced Programming", "", 2));
        myCourses.Add(new Course("MATH150", "Calculus I", "Mathematics", "MATH101", 1));
        myCourses.Add(new Course("ENG220", "Modern Literature", "Literature", "", 2));
        myCourses.Add(new Course("PHYS201", "Physics II", "Science", "PHYS101", 2));
        
        SaveCourses("ListOfCourses.json", myCourses);
        ReadCourses("ListOfCourses.json");
    }

    public static void SaveCourses(string fileName, List<Course> listOfCourses)
    {
        StreamWriter writer = new StreamWriter(fileName);

        foreach (Course course in listOfCourses)
        {
            string courseJson = JsonSerializer.Serialize(course);
            writer.WriteLine(courseJson);
            Console.WriteLine(courseJson);
        }
        writer.Close();
    }

    public static List<Course> ReadCourses(string filename)
    {
        List<Course> list = new List<Course>();
        StreamReader reader = new StreamReader(filename);

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