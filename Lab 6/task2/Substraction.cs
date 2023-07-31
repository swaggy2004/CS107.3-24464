using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Substraction : GetNumbers
    {
        public Substraction() 
        {
            Console.WriteLine("Substraction is " +  (num1 - num2));
            Console.ReadKey(); 
        }
    }
}
