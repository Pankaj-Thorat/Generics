using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class StringMaximum
    {
        public static string FindMax(string num1, string num2, string num3)
        {
            string max = num1;

            if (num2.CompareTo(max) > 0)
            {
                max = num2;
            }

            if (num3.CompareTo(max) > 0)
            {
                max = num3;
            }

            return max;
        }
    }
}
