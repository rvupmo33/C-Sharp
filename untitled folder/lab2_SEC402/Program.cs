// namespace lab2_SEC402;

class Program
{
    static void Main(string[] args)
    {
        Pet pet1 = new Pet("pet1", 3,"Egyptian Mau");
        Pet pet2 = new Pet("pet2", 5,"Bulldog");
        Pet pet3 = new Pet("pet3", 1,"Parakeet");
        Pet pet4 = new Pet("pet4", 6,"Small Moon Jellyfish");
        
        

        List<Pet> pets = new List<Pet>();


        pets.Add(pet1);
        pets.Add(pet2);
        pets.Add(pet3);
        pets.Add(pet4);
        
        pet1.Train();
        pet2.Train();
        
        pet3.SetOwner("Smith");
        pet4.SetOwner("Amanda");


        foreach (Pet thePet in pets)
        {
            Console.WriteLine(thePet.ToString());
        }

        Console.WriteLine("\nEnter Owner Name: ");
        string ownerName = Console.ReadLine();

        Console.WriteLine($"\nFinding all pets belonging to {ownerName}");
        foreach (Pet thePet in pets)
        {
            if (thePet.Owner == ownerName)
            {
                Console.WriteLine(thePet.ToString());
            }
        }


    }
}