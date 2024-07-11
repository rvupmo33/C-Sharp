namespace AtomClass_SEC402;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class Atom
{
    public string Name { get; set; }
    public string Symbol { get; set; }
    public int Proton { get; set; }
    public int Neutron { get; set; }
    public double Weight { get; set; }

    public Atom()
    {
        
    }

    public Atom(string name, int proton, int neutron, double weight, string symbol)
    {
        Name = name;
        Symbol = symbol;
        Proton = proton;
        Neutron = neutron;
        Weight = weight;
    }

    public static Atom Parse(string line)
    {
        string[] parts = line.Split(' ');
        if (parts.Length != 5)
        {
            throw new ArgumentException("The line did not have 5 parts after it was split.");
        }

        string name = parts[0];
        int proton = int.Parse(parts[1]);
        int neutron = int.Parse(parts[2]);
        double weight = double.Parse(parts[3]);
        string symbol = parts[4];
        
        return new Atom(name, proton, neutron, weight, symbol);
    }

    public override string ToString()
    {
        return $"Name: {Name} - Symbol: {Symbol} - Proton: {Proton} - Neutron: {Neutron} - Weight: {Weight}";
    }
    
}