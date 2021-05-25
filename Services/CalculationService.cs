using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Services
{
    class CalculationService
    {

        public static void Max(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void Sum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
    }
}
