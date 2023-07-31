using System;

namespace Lab2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();
        }
    }
}
