using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    internal class ArrayCal
    {
        public void Array() 
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write($"Enter a value for {i}: ");
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
        }
    }
}
