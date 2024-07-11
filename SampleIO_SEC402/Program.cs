namespace SampleIO_SEC402;

class Program
{
    static void Main(string[] args)
    {
        WriteFile();
        ReadFile();
    }

    static void WriteFile()
    {
        string fileName = "my-file.txt";

        StreamWriter writer = new StreamWriter(fileName);
        
        writer.WriteLine("This is sentence 1");
        writer.WriteLine("Second sentence!");
        
        writer.Close();
    }

    static void ReadFile()
    {
        string filename = "my-file.txt";

        StreamReader reader = new StreamReader(filename); 

        string line = reader.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            
            line = reader.ReadLine();
        }
        reader.Close();
    }
    
}