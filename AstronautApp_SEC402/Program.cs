namespace AstronautApp_SEC402;

class Program
{
    static void Main(string[] args)
    {
        List<Astronaut> astronauts = new List<Astronaut>();
        Astronaut a;
        
        a = Astronaut.CreateAstronaut("Yuri Gagarin", "Russian");
        if(a != null) // 1
            astronauts.Add(a);
        
        a = Astronaut.CreateAstronaut("Alan Shepard", "American");
        if(a != null) // 2
            astronauts.Add(a);
        
        a = Astronaut.CreateAstronaut("Virgil Grissom", "American");
        if(a != null) // 3
            astronauts.Add(a);
        
        a = Astronaut.CreateAstronaut("Gherman Titov", "Russian");
        if(a != null) // 4
            astronauts.Add(a);
        
        a = Astronaut.CreateAstronaut("John Glenn", "American");
        if(a != null) // 5
            astronauts.Add(a);
        
        a = Astronaut.CreateAstronaut("Scott Carpenter", "American");
        if(a != null) // 6
            astronauts.Add(a);
        
        Console.WriteLine("Only 5 astronauts were created");
        int count = 1;
        foreach (var astronaut in astronauts)
        {
            Console.WriteLine($"{count++} {astronaut.ToString()}");
        }
        
        Console.WriteLine("Now the 6th astronaut will be created");
        Astronaut.SetMax(6);
        astronauts.Add(Astronaut.CreateAstronaut("Scott Carpenter", "American")); // 6
        //now 6 astronaut created
        count = 1;
        foreach (var astronaut in astronauts)
        {
        Console.WriteLine($"{count++} {astronaut.ToString()}");
        }
        
    }
}