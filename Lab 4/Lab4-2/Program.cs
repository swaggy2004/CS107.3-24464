using System;

namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues ObjCircle = new FindValues();
            Console.WriteLine("Area: {0}", ObjCircle.FindArea(radius));
            Console.WriteLine("Circumference: {0}", ObjCircle.FindCircumference(radius));
            Console.ReadKey();
        }
    }
}
