using System;
using System.Linq;
using Utilities;

namespace Algorithm;

class Program
{
    static void Run(string[] args)
    {
        string input = CustomFunctions.GetInputFromUser("Input");

        Console.WriteLine(input.Reverse().ToArray());
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