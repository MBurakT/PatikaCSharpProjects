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
            {
                Console.WriteLine($"Value is not numeric! input: {input}");
            }
            else if (input < 1)
            {
                Console.WriteLine($"Value is zero or negative! input: {input}");
                break;
            }
            else
            {
                Console.WriteLine(CustomFunctions.Average(CustomFunctions.CreateFibonacciArray(input)).ToString("F2"));
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