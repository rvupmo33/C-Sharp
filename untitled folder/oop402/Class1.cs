using oop402.models;

namespace oop402;

public class Class1
{
    static void Main(string[] args)
    {
        Person me = new Person();
        me.Name = "Nura";
        me.DateOfBirth = new DateTime(2005, 09, 19);

        Person john = new Person("John");
    }
}