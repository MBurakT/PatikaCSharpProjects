using System;
using System.IO;
using Utilities;

namespace AADeneme;

class Program
{
    static void Run(string[] args)
    {
        while (true)
        {
            if (!int.TryParse(CustomFunctions.GetInputFromUser("Please enter"), out int input))
            {
                Console.WriteLine("Value is not numeric!");
            }
            else if (input < 1)
            {
                Console.WriteLine($"Error: value must be greater than zero! input: {input}");
                break;
            }
            else
            {
                Console.WriteLine(File.ReadAllText(Environment.CurrentDirectory + @"\ATMApp\Logs\2024\January\09\EOD_20240109.txt"));
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