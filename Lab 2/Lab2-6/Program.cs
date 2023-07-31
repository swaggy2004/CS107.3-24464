using System;

namespace Lab2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tot = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} Enter a number: ");
                tot += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The total is {tot}");
            Console.WriteLine($"The avergae is {(double)tot / 10.0}");
            Console.ReadKey();

        }
    }
}
