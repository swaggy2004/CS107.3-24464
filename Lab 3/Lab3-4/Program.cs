using System;

namespace Lab3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.Write("Enter a starting number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter a ending number: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    total += i;
                }
            }
            Console.WriteLine($"The total is {total}");
            Console.Read();
        }
    }
}
