using System;

namespace Lab2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius of circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Area is {Math.PI * Math.Pow(radius, 2)}");
            Console.WriteLine($"The Circumference is {2 * Math.PI * radius}");
            Console.ReadLine();
        }
    }
}
