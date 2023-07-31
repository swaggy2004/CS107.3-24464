using System;

namespace Lab2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Enter a number: ");
            num = double.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("Is divisible by 5");
            }
            else
            {
                Console.WriteLine("Isn't divisible by 5");
            }
            Console.ReadLine();
        }
    }
}
