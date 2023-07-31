using System;

namespace Lab1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary;
            double tax;
            Console.Write("Enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the tax rate: ");
            tax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Salary after tax is {salary - ((salary * tax) / 100)}");
            Console.ReadKey();
        }
    }
}
