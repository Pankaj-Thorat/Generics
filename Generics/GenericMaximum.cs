﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericMax<T> where T : IComparable
    {
        public T s1, s2, s3;
        
        public static T GenericFindMax(T s1, T s2, T s3)
        {
            T max = s1;

            if (s2.CompareTo(max) > 0)
            {
                max = s2;
            }

            if (s3.CompareTo(max) > 0)
            {
                max = s3;
            }

            return max;
        }
        
        
    }
}