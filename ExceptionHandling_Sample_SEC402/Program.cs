namespace ExceptionHandling_Sample_SEC402;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        Console.Write("Enter Int: ");
        try
        {
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The value entered was: {i}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid int!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too large or too small");
        }
        catch (Exception ex)
        {
            Console.WriteLine("A strange error has occured");
        }
        finally
        {
            Console.WriteLine("::> This block will always run!");
        }
        
        
    }
}