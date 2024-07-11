namespace SampleIO2_SEC402;

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
        
        //Declare and initialize the object to write to:
        // Add true after 'filename' to append to document!
        StreamWriter writer = new StreamWriter(fileName);
        
        //Do some writing:
        writer.WriteLine(":)");
        writer.WriteLine(":(");
        writer.WriteLine(":O");
        writer.WriteLine(";)");
        
        //Close file
        writer.Close(); 
    }

    static void ReadFile()
    {
        string fileName = "my-file.txt";

        StreamReader reader = new StreamReader(fileName);

        string line = reader.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
             line = reader.ReadLine();

        }
        
        reader.Close();
    }
}