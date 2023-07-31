using System;

namespace Lab2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter mark: ");
            int mark = int.Parse(Console.ReadLine());
            if (mark >= 70)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadLine();
        }
    }
}
