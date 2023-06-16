using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result = 0;
            Console.Write("Enter 1 for Addition\nEnter 2 for Subtraction\nEnter 3 for Multiplication\nEnter 4 for Division\n");
            Console.Write("Enetr your choice: ");
            int op = int.Parse(Console.ReadLine());
            Console.Write("Enter Numebr 1: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            float n2 = float.Parse(Console.ReadLine());

            CalculateValues ObjCal = new CalculateValues();

            switch (op)
            {
                case 1:
                    result = ObjCal.Add(n1, n2);
                    break;
                case 2:
                    result = ObjCal.Subtract(n1, n2);
                    break;
                case 3:
                    result = ObjCal.Multiply(n1, n2);
                    break;
                case 4:
                    result = ObjCal.Divide(n1, n2);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine($"Your answer is: {result}");
            Console.ReadKey();
        }
    }
}
