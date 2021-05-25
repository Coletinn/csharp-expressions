using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using Project.Services;


namespace Project
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        public static int globalValue = 3;

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            op += CalculationService.Max;

            op(a,b);
        }
    }
}
