namespace FlightSystem_SEC402;

internal class Flight
{
    private string flightNumber;
    private int availableSeats;
    
    public string FlightNumber { get; set; }
    public int AvailableSeats { get; set; }

    public Flight(string flightNumber, int availableSeats)
    {
        this.FlightNumber = flightNumber;
        this.AvailableSeats = availableSeats;
    }

    public void Booking(int numSeats, string customerName)
    {
        if (numSeats > 0 && availableSeats <= numSeats)
        {
            AvailableSeats -= numSeats;
            Console.WriteLine($"{customerName}, your booking was successful.\nBooking information: {customerName} - flight: {FlightNumber}");
        }
        else if (numSeats <= 0)
        {
            Console.WriteLine("Invalid number of seats. Please enter a valid number.");
        }
        else
        {
            Console.WriteLine("Booking could not be completed due to insufficient seats.");
        }
    }

    public bool CheckFlightStatus(string queryFlightNumber, string customerName)
    {
        if (queryFlightNumber == FlightNumber)
        {
            Console.WriteLine($"Available seats: {AvailableSeats}");
            Console.WriteLine("Thank you for choosing our airline!");
            return true;
        }
        else
        {
            Console.WriteLine("The flight number is incorrect!");
            return false;
        }
    }
    
}