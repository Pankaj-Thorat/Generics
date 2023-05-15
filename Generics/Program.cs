using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxNumber maxNumber = new MaxNumber();
            // Test cases
            int testCase1 = MaxNumber.FindMax(10, 5, 3);
            Console.WriteLine("Max number: " + testCase1);  // Expected output: 10

            int testCase2 = MaxNumber.FindMax(7, 15, 8);
            Console.WriteLine("Max number: " + testCase2);  // Expected output: 15

            int testCase3 = MaxNumber.FindMax(4, 9, 12);
            Console.WriteLine("Max number: " + testCase3);  // Expected output: 12
        }
    }
}
