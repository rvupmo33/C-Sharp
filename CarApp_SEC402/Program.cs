namespace CarApp_SEC402;

class Program
{
    static void Main(string[] args)
    {
        Car one = new Car(2006, "Toyota", "Corolla", 26_000, true);
        Car two = new Car(2021, "Mazda", "Mazda3", 25_000, true);
        Car three = new Car(2015, "Nissan", "Leaf", 29_010, true);
        Car four = new Car(2020, "Dodge", "Charger", 39_170, true);

        one.Year = 2016;
        
        // Console.WriteLine(one.ToString());
        // Console.WriteLine(two.ToString());
        // Console.WriteLine(three.ToString());
        // Console.WriteLine(four.ToString());

        //declared and created list 
        
        List<Car> cars = new List<Car>();
        
        cars.Add(one);
        cars.Add(two);
        cars.Add(three);
        cars.Add(four);

        foreach (Car myCar in cars)
        {
            Console.WriteLine(myCar.ToString());
        }
    }
}