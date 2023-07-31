using System;

namespace Lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int count = 0;
            Console.Write("Enter a word: ");
            word = Console.ReadLine();
            word = word.ToLower();
            vowles = "aeiou";
            foreach (word in vowles)
            {
                count++;
            }
            Console.WriteLine($"The total number of voweles is {count}");
            Console.ReadKey();
        }
    }
}
