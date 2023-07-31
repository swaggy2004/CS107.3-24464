using System;

namespace Lab1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.Write("Enter a value for first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value for second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The total is {num1 + num2}");
            Console.ReadKey();
        }
    }
}
