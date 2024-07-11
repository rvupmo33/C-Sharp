namespace CarDemoApp_SEC402;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Camaro", 25);
        Car car2 = new Car("Aston Martin");

        Console.WriteLine("Before incrementation:");
        Console.WriteLine($"CAR1 - Model: {car1.Model} - KilometersPerLitre: {car1.KilometersPerLitre}");
        Console.WriteLine($"CAR2 - Model: {car2.Model} - KilometersPerLitre: {car2.KilometersPerLitre}");

        car1++;
        car2++;
        
        Console.WriteLine("");
        Console.WriteLine("After incrementation:");
        Console.WriteLine($"CAR1 - Model: {car1.Model} - KilometersPerLitre: {car1.KilometersPerLitre}");
        Console.WriteLine($"CAR2 - Model: {car2.Model} - KilometersPerLitre: {car2.KilometersPerLitre}");
        
    }
}