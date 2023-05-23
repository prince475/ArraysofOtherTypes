// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> {1,1};

            while(fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
            {
            Console.WriteLine(item);
            }

            // challenge get the first 20 fibonacci numbers.



        }
    }
}


