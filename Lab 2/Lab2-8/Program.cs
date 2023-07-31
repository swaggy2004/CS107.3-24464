using System;

namespace Lab2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Enter a whole number: ");
                num = int.Parse(Console.ReadLine());
            } while (num >= 0);
        }
    }
}
