using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringLengthLibrary;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringLength L = new StringLength();
            string inputString = "hello, world";
            int length = L.CalculateStringLength(inputString);
            Console.WriteLine($"the length of the string is : {length}");

            Console.ReadLine();
        }
    }
}
