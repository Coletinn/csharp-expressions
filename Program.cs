using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace Project
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
