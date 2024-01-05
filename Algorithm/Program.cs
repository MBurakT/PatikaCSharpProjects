using System;
using Utilities;

namespace Algorithm;

class Program
{
    static void Run(string[] args)
    {
        string[] inputs = CustomFunctions.GetInputFromUser("Input").Split(',');

        Console.WriteLine(inputs[0].Remove(int.Parse(inputs[1]), 1));
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