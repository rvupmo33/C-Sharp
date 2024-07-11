namespace ComplexApp_SEC402;

class Program
{
    static void Main(string[] args)
    {
        // Complex c1 = new Complex();
        // Console.WriteLine(c1);
        //
        // Complex c2 = new Complex(10, 7);
        // Console.WriteLine(c2);
        //
        // Complex c3 = c1 - c2;
        // Console.WriteLine(c3);
        //
        // Complex c4 = c1 + c2;
        // Console.WriteLine(c4);
        
        
        // unary operators have 1 argument
        // ex. '++' or '--'
        
        // Binary operators have 2 arguments
        // ex. public static Complex operator +(Complex lhs, Complex rhs)
        
        //Ternary operators have 3 arguments
        // ex. condition? TRUE : FALSE 
        
        Complex c0 = new Complex(-2, 3);
        Complex c1 = new Complex(-2, 3);
        Complex c2 = new Complex(1, -2);
        
        Console.WriteLine($"{c0}");
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        
        Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
        Console.WriteLine($"{c1} - {c2} = {c1 - c2}");
        
        Complex c3 = c1 + c2;
        
        Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2}cis({c3.Argument:f2})");
            
        Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
        Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");
    }
}