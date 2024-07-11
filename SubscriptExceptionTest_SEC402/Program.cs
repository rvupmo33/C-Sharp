namespace SubscriptExceptionTest_SEC402;

class Program
{
    static void Main(string[] args)
    {
        double[] doubleArray = [1.1, 2.1, 3.1, 4.1, 5.2, 6.2, 7.2, 8.2, 9.3, 10.3];

        for (int i =0; i < doubleArray.Length;)
        {
            try
            {
                Console.Write("Enter an index value: ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The value at that index is {doubleArray[input]}");
                i++;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"--> Index number was out of bounds of range!");
            }   
        }
    }
}