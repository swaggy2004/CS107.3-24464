using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Multipication : GetNumbers
    {
        public Multipication()
        {
            Console.WriteLine("Multipication is " + (num1 * num2));
            Console.ReadKey();
        }
    }
}
