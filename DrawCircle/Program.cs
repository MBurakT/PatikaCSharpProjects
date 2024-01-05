using System;
using Utilities;

namespace DrawCircle;

class Program
{
    static void Run(string[] args)
    {
        while (true)
        {
            if (!int.TryParse(CustomFunctions.GetInputFromUser("Please enter the radius of circle"), out int input))
            {
                Console.WriteLine($"Value is not numeric! input");
            }
            else if (input < 1)
            {
                Console.WriteLine($"Error: value must be greater than zero! input: {input}");
                break;
            }
            else
            {
                CustomFunctions.DrawCircle(input);
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