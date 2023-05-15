using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MaxNumber
    {
       
        public static int FindMax(int num1, int num2, int num3)
        {
            int max = num1;

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

