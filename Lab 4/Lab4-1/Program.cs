using System;

namespace Lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // No parameter and no return type
            ConvertValues ObjValue = new ConvertValues();
            ObjValue.killometerTOmeter();

            // With parameter and no return type
            Console.WriteLine("This is outside the method!");
            Console.Write("Enter distance is Kilometer: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            ObjValue.killometerTOmeter(distance);

            //  With parameter and with return type
            Console.Write("Enter distance is Kilometer: ");
            float distance1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"This is the value in {ObjValue.killometerTOmeter(distance1)}");
            Console.ReadLine();

        }
    }
}
