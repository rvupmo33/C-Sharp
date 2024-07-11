namespace ComplexApp_SEC402;

public class Complex
{
    public int Real { get; }
    public int Imaginary { get; }
    
    public double Modulus
    {
        get
        {
            return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
        }
    }

    public double Argument
    {
        get
        {
            return Math.Atan(Imaginary/Real);
        }
    }

    public static Complex Zero
    {
        get
        {
            Complex result = new Complex();
            return new Complex(0,0);
        }
    }
    public Complex()
    {
        Real = 1;
        Imaginary = 1;
    }

    public Complex(int real = 0, int imaginary = 0)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public override string ToString()
    {
        return $"({Real},{Imaginary})";
    }
    
    public static Complex operator +(Complex lhs, Complex rhs)
    {
        int newReal = lhs.Real + rhs.Real;
        int newImaginary = lhs.Imaginary + rhs.Imaginary;
        return new Complex(newReal,newImaginary);
    }

    public static Complex operator -(Complex lhs, Complex rhs)
    {
        int newReal = lhs.Real - rhs.Real;
        int newImaginary = lhs.Imaginary - rhs.Imaginary;
        return new Complex(newReal,newImaginary);
    }

    public static bool operator ==(Complex lhs, Complex rhs)
    {
        if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public static bool operator !=(Complex lhs, Complex rhs)
    {
        if (lhs.Real != rhs.Real || lhs.Imaginary != rhs.Imaginary)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}