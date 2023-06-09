using System;

namespace Lab4_1
{
    internal class ConvertValues
    {
        public void killometerTOmeter()
        {
            Console.Write("Enter Killometer value: ");
            double killometer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The value is meter is {killometer * 1000}");
        }

        public void killometerTOmeter(double d)
        {
            Console.WriteLine($"The value is meter is {d * 1000}");
        }

        public float killometerTOmeter(float distance)
        {
            return distance * 1000;
        }
    }
}
