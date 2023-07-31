using System;

namespace Lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            Console.Write("Enter radius: ");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area is {Math.PI * radius * radius:f3}");
            Console.ReadKey();
        }
    }
}
