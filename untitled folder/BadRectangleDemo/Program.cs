using System;

namespace BadRectangleDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BadRectangle smallRectangle = CreateRectangle(4,5);
            DescribeRectangle(smallRectangle);
            CalculateAndDisplayArea(smallRectangle);
        }

        static BadRectangle CreateRectangle(int width, int length)
        {
            BadRectangle rec = new BadRectangle();
            rec.width = width;
            rec.length = length;

            return rec;
        }

        static void DescribeRectangle(BadRectangle rectangle)
        {
            Console.WriteLine($"Width: {rectangle.width} - Length: {rectangle.length}");
        }

        static void CalculateAndDisplayArea(BadRectangle rectangle)
        {
            int area = rectangle.width * rectangle.length;
            Console.WriteLine($"Area is {area}");
        }
    }
    public class BadRectangle
    {
        public int length;
        public int width;
    }
}