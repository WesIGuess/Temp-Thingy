
using System;

namespace TempConv
{
    class Program
    {
        public static void Main(string[] args)
        {
            double farhenheit;
            double celsius;
            string input;
            Console.WriteLine("Temperature in F:");
            input = Console.ReadLine();
            farhenheit = double.Parse(input);

            celsius = (farhenheit - 32) *5 / 9;
            Console.WriteLine("The Temperature in C is: " + celsius);
            Console.ReadLine();
        }
    }
}