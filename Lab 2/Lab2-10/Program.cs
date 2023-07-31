using System;

namespace Lab2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that gets a students 4 marks and prints out a grade for the individual grades. mark >= 70 = A, mark >= 60 = B, mark >= 50 = C, mark >= 40 = D, mark < 40 = F

            int mark = 0;
            for (int i = 0; i < 4; i++)
            {
                // Make a switch statement
                switch (i)
                {
                    case 0:
                        Console.Write("Enter mark : ");
                        mark = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Marks for Computer Science: {GetGrade(mark)}");
                        break;
                    case 1:
                        Console.Write("Enter mark : ");
                        mark = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Marks for Professional Development: {GetGrade(mark)}");
                        break;
                    case 2:
                        Console.Write("Enter mark : ");
                        mark = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Marks for C Programming: {GetGrade(mark)}");
                        break;
                    case 3:
                        Console.Write("Enter mark : ");
                        mark = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Marks for Mathamatics: {GetGrade(mark)}");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
        static string GetGrade(int mark1)
        {
            if (mark1 >= 75)
            {
                return "A";
            }
            else if (mark1 >= 65)
            {
                return "B";
            }
            else if (mark1 >= 55)
            {
                return "C";
            }
            else if (mark1 >= 45)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
