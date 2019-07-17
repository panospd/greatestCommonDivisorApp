using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.DirectoryServices;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Please enter first number:");
                long? a = UserInputConverter.GetNumberFromUserInput(Console.ReadLine());

                Console.WriteLine("Please enter second number:");
                long? b = UserInputConverter.GetNumberFromUserInput(Console.ReadLine());

                if (a == null || b == null)
                {
                    Console.WriteLine("Incorrect input..");
                    Console.WriteLine("Type 1 for another round or any key to exit:");
                    playAgain = UserInputConverter.PlayAgain(Console.ReadLine());
                    continue;
                }

                long result = GetGreatestCommonDivisor((long)a, (long)b);
                Console.WriteLine($"The GCD for {a} and {b} is: {result}");

                Console.WriteLine("Type 1 for another round or any key to exit:");
                playAgain = UserInputConverter.PlayAgain(Console.ReadLine());
            }
        }

        private static long GetGreatestCommonDivisor(long number1, long number2)
        {
            while (number1 != number2)
            {
                if (number1 > number2)
                    number1 = number1 - number2;
                else
                    number2 = number2 - number1;
            }

            return number1;
        }
    }
}
