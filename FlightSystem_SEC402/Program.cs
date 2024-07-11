namespace FlightSystem_SEC402;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our flight system!");
        Console.WriteLine("_______________________________________________");
        
        Console.WriteLine("Please enter your flight number: ");
        string flightNumber = Console.ReadLine();

        int availableSeats = 0;
        while (true)
        {
            Console.WriteLine("Enter the Number of Available Seats: ");
            try
            {
                availableSeats = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input - Please enter a valid number.");
            }
        }

        Flight flight1 = new Flight(flightNumber, availableSeats);
        
        int numSeats = 0;
        while (true)
        {
            Console.WriteLine("Enter number of seats you would like to book: ");
            try
            {
                numSeats = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Invalid input - Please enter a valid number.");
            }
        }

        Console.WriteLine("Please enter your name: ");
        string customerName = Console.ReadLine();
        
        Console.WriteLine("_______________________________________________");
        flight1.Booking(numSeats, customerName);
        Console.WriteLine("_______________________________________________");
        
        Console.WriteLine("Enter the flight number to check flight status: ");
        string queryFlightNumber = Console.ReadLine();
        
        flight1.CheckFlightStatus(queryFlightNumber, customerName);

    }
}