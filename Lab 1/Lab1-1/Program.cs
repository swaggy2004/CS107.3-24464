using System;

namespace Lab1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string batch;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your Batch: ");
            batch = Console.ReadLine();
            Console.WriteLine($"Your name is {name} and batch is {batch}");
            Console.ReadKey();
        }
    }
}
