using System;

namespace Lab2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that can take the heigth and length of a rectangle and calculate the area and perimeter.

            Console.Write("Enter heigth of rectangle: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Area is {height * width}");
            Console.WriteLine($"The Perimeter is {(height * 2) + (width * 2)}");
            Console.ReadLine();
        }
    }
}
