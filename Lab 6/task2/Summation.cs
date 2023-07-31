using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Summation : GetNumbers
    {
        public Summation()
        {
            Console.WriteLine("Addition is " + (num1 + num2));
            Console.ReadKey();
        }
    }
}
