using System;
using Utilities;

namespace CalculateAverage;

class Program
{
    static void Run(string[] args)
    {
        while (true)
        {
            if (!int.TryParse(CustomFunctions.GetInputFromUser("Please enter depth of fibonnaci"), out int input))
                return;

            if (input == 0) break;

            if (input > 2)
            {
                int fib0 = 0, fib1 = 1, counter;
                float total = 1;

                for (counter = 2; counter < input; counter++)
                {
                    int fib = fib1 + fib0;
                    fib0 = fib1;
                    fib1 = fib;
                    total += fib;
                }

                Console.WriteLine((total / input).ToString("F2"));
            }
            else if (input == 2)
            {
                Console.WriteLine("0.5");
                return;
            }
            else if (input == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("input is negative!");
                return;
            }
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Run(args);
            if (Console.ReadLine() == "clear") Console.Clear();
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
        }
    }
}