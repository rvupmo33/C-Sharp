namespace Exception1_SEC402;

class Program
{
    static void Main(string[] args)
    {
        // DivisionNoHandling();
        // DivisionWithExceptionHandling();
        // DivisionWithExceptionHandlingMoreInfo();
        // DivisionWithExceptionHandlingThrow();
        // GeneratingException();
        // HandlingRandomException();

    }
    // ----------------------------------------------------
    static int Division(int top, int bottom) => top / bottom; 
    // ----------------------------------------------------
    static void DivisionNoHandling() 
    { 
        //call the Division method with argument 1 and 0 
        //this will terminate your application  //Worked
        Division(1, 0);
    } 
    // ----------------------------------------------------
    static void DivisionWithExceptionHandling() 
    { 
        //call the Division method with argument 1 and 0 
        //You will catch the exception and do nothing 
        //Your application should not crash  //Worked
        try
        {
            Division(1, 0);
        }
        catch (Exception ex)
        {
            
        }
    } 
    // ----------------------------------------------------
    static void DivisionWithExceptionHandlingMoreInfo() 
    { 
        //call the Division method with argument 1 and 0 
        //You will catch the exception and print the associated message 
        //your application should not crash  //Worked
        try
        {
            Division(1, 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    } 
    // ----------------------------------------------------
    static void DivisionWithExceptionHandlingThrow() 
    { 
        //call the Division method with argument 1 and 0 
        //You will catch the exception and print the associated message 
        //You should create and throw a new exception 
        //your application will crash  //Worked
        try
        {
            Division(1, 0);
        }
        catch (Exception ex)
        {
                Console.WriteLine("Exception: " + ex.Message);
                throw new Exception("This is a new exception.");
        }
    } 
    // ----------------------------------------------------
    static void GeneratingException() 
    { 
        //You should create and throw a new exception 
        //your application will crash  //Worked
        throw new Exception("This is a new exception.");
    } 
    // ----------------------------------------------------
    static void HandlingRandomException () 
    { 
        //You should call the method below and catch all the possible
        //exceptions individually and display a sensible output 
        //your application will not crash  //Worked
        try
        {
            GeneratingRandomException();
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Exception: IndexOutOfRangeException");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Exception: NullReferenceException");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Exception: InvalidOperationException");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Exception: ArithmeticException");
        }
        catch (FormatException)
        {
            Console.WriteLine("Exception:FormatException");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Exception: InvalidCastException");
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("Exception: OutOfMemoryException");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    } 
    static void GeneratingRandomException() 
    { 
        int exceptionType = new Random().Next() % 7; 
        switch(exceptionType) 
        { 
            case 0: 
                throw new IndexOutOfRangeException(); 
            case 1: 
                throw new NullReferenceException(); 
            case 2: 
                throw new InvalidOperationException(); 
            case 3: 
                throw new ArithmeticException(); 
            case 4: 
                throw new FormatException(); 
            case 5: 
                throw new InvalidCastException(); 
            case 6: 
                throw new OutOfMemoryException(); 
        } 
    } 
    // ----------------------------------------------------
}