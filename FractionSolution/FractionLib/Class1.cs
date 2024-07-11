using System;
namespace ClassLibrary1
{
    public class Frac
    {
        public int Top { get; }
        public int Bottom { get; }

        public Frac(int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }
    
        // operator overload
        public static Frac operator +(Frac leftHand, Frac rightHand)
        {
            int newTop = leftHand.Top * rightHand.Top + rightHand.Top * leftHand.Bottom;
            int newBottom = leftHand.Bottom * rightHand.Bottom;
        
            return new Frac(newTop, newBottom);
        }
    
        public static Frac operator -(Frac leftHand, Frac rightHand)
        {
            if ((rightHand.Top / rightHand.Bottom) > (leftHand.Top / leftHand.Bottom))
                throw new Exception("Right hand operand cannot be greater than the left hand operand");

            int newTop = leftHand.Top * rightHand.Top - rightHand.Top * leftHand.Bottom;
            int newBottom = leftHand.Bottom * rightHand.Bottom;
        
            return new Frac(newTop, newBottom);
        }

        public override string ToString()
        {
            return $"{Top}/{Bottom}";
        }
    }
}