using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Anna";
            int value1 = -13;
            int value2 = -28;
            int value3 = 28; 
            Console.WriteLine(a.IsPolindrom(true));  // the output is: True 
            Console.WriteLine(value1.SumOfDigets()); // the output is: -4
            Console.WriteLine(value1.IsPrime());     // the output is: True
            Console.WriteLine(value2.IsPerfect());   // the output is: False
            Console.WriteLine(value3.IsPerfect());   // the output is: True
            Console.ReadKey();
        }
    }
}
