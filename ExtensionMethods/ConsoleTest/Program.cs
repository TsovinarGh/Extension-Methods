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
            Console.WriteLine(a.IsPolindrom(true));
            Console.WriteLine(value1.SumOfDigets());
            Console.WriteLine(value1.IsPrime());
            Console.WriteLine(value2.IsPerfect());
            Console.WriteLine(value3.IsPerfect());
            Console.ReadKey();
        }
    }
}
