using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //// Test cases
            //int testCase1 = MaxNumber.FindMax(10, 5, 3);
            //Console.WriteLine("int Max number: " + testCase1);  // Expected output: 10

            //int testCase2 = MaxNumber.FindMax(7, 15, 8);
            //Console.WriteLine("int Max number: " + testCase2);  // Expected output: 15

            //int testCase3 = MaxNumber.FindMax(4, 9, 12);
            //Console.WriteLine("int Max number: " + testCase3);  // Expected output: 12

            ////UC 2
            
            ////Test cases
            //float case1 = FloatMaxNumber.FindMax(10.5f, 5.2f, 3.25f);
            //Console.WriteLine("float Max number: " + case1);  // Expected output: 10.5

            //float case2 = FloatMaxNumber.FindMax(7.35f, 15.45f, 8.89f);
            //Console.WriteLine("float Max number: " + case2);  // Expected output: 15.45

            //float case3 = FloatMaxNumber.FindMax(4.94f, 9.48f, 12.36f);
            //Console.WriteLine("float Max number: " + case3);  // Expected output: 12.36

            ////UC3
            
            ////Test cases
            //string s1 = StringMaximum.FindMax("Apple", "Peach", "Banana");
            //Console.WriteLine("string Maximum: " + s1);  // Expected output: Peach

            //string s2 = StringMaximum.FindMax("Apple", "Banana", "Peach");
            //Console.WriteLine("string Maximum: " + s2);  // Expected output: Peach

            //string s3 = StringMaximum.FindMax( "Peach", "Apple", "Banana");
            //Console.WriteLine("string Maximum: " + s3);  // Expected output: Peach


            //Refactcored code
            //int type
            //Console.WriteLine("For integer type (TC2):"+ GenericMax<int>.GenericFindMax(10, 20, 30));
            //Console.WriteLine("For integer type (TC1):" + GenericMax<int>.GenericFindMax(10, 30, 20));
            //Console.WriteLine("For integer type (TC3):" + GenericMax<int>.GenericFindMax(30, 20, 10));
            ////double type
            //Console.WriteLine("For double type (TC1) :" + GenericMax<double>.GenericFindMax(10.25, 20.445, 30.12));
            //Console.WriteLine("For double type (TC2) :" + GenericMax<double>.GenericFindMax(10.25, 30.12, 20.445));
            //Console.WriteLine("For double type (TC3) :" + GenericMax<double>.GenericFindMax(30.12, 10.25, 20.445));
            ////string type
            //Console.WriteLine("For string type (TC1) :" + GenericMax<string>.GenericFindMax("apple", "Peach", "banana"));
            //Console.WriteLine("For string type (TC2) :" + GenericMax<string>.GenericFindMax("Peach", "apple", "banana"));
            //Console.WriteLine("For string type (TC3) :" + GenericMax<string>.GenericFindMax("banana", "apple", "Peach"));

            //refactored code 2
            //for int
            GenericMax<int> gm = new GenericMax<int>(10, 20, 30);
            Console.WriteLine("Max Value is: "+ gm.MaxMethod());

            //for string 
            GenericMax<string> st = new GenericMax<string>("Apple","Banana","Peach");
            Console.WriteLine("Max Value is: " + st.MaxMethod());

            //for double
            GenericMax<double> dou = new GenericMax<double>(210.45,321.32,112.12);
            Console.WriteLine("Max Value is: " + dou.MaxMethod());




        }
    }

}
