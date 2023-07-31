using System;

namespace Lab3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (; num != 0; num /= 10)
            {
                total += num % 10;
            }
            Console.WriteLine($"The total is {total}");
            Console.ReadLine();
        }
    }
}
