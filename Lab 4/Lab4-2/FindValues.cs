using System;

namespace Lab4_2
{
    internal class FindValues
    {
        public double FindArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public double FindCircumference(double r)
        {
            return 2 * Math.PI * r;
        }
    }
}
