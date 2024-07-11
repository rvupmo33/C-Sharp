namespace AstronautApp_SEC402;

internal class Astronaut
{
    // private string name;
    // private string nationality;
    private static int count =0;
    private static int max = 5;
    
    // Auto implemented property:
    public string Name { get; set; }
    public string Nationality { get; set; }

    private Astronaut(string name, string nationality)
    {
        Name = name;
        Nationality = nationality;
    }

    public static Astronaut CreateAstronaut(string name, string nationality)
    {
        if (count < max)
        {
            Astronaut a = new Astronaut(name,nationality);
            count++;
            return a;
        }
        else
        {
            return null;
        }
    }

    public override string ToString()
    {
        return $"Astronaut's Name: {Name} - Nationality: {Nationality}";
    }

    public static void SetMax(int max)
    {
        Astronaut.max = max;
    }
    
}