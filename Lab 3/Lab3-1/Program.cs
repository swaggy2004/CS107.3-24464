using System;

namespace Lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.ReadKey();
        }
    }
}
