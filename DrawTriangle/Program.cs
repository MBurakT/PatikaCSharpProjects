using System;
using Utilities;

namespace DrawTriangle;

class Program
{
    static void Run(string[] args)
    {
        while (true)
        {
            if (!int.TryParse(CustomFunctions.GetInputFromUser("Please enter depth of triangle"), out int input))
            {
                Console.WriteLine($"Value is not numeric! input: {input}");
            }
            else if (input < 2)
            {
                Console.WriteLine($"Value is not greater than two! input: {input}");
                break;
            }
            else
            {
                CustomFunctions.DrawTriangle(input);
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