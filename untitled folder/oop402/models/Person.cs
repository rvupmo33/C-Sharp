namespace oop402.models;

public class Person
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public int Age
    {
        get
        {
            int Age = DateTime.Now.Year - this.DateOfBirth.Year;

            if (DateTime.Now.DayOfYear < this.DateOfBirth.DayOfYear)
            {
                Age--;
            }
            return Age;
        }
    }

    public Person()
    {
        // Initalization logic
    }

    public Person(string name)
    {
        // Initalization logic
        this.Name = name;
    }
}