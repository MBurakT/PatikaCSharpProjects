using System;
using Utilities;

namespace Absolute;

class Program
{
    static void Run(string[] args)
    {
        while (true)
        {
            if (!int.TryParse(CustomFunctions.GetInputFromUser("Please enter how many numbers you will type"), out int size))
            {
                Console.WriteLine("Value is not numeric!");
            }
            else if (size < 1)
            {
                Console.WriteLine($"Error: value must be greater than zero! input: {size}");
                break;
            }
            else
            {
                int limit = 0, underTotal = 0, overTotal = 0;

                for (int i = 0; i < size; i++)
                {
                    if (int.TryParse(CustomFunctions.GetInputFromUser("Please enter number"), out int number))
                    {
                        if (number < 67)
                        {
                            underTotal = number - underTotal;
                        }
                        else
                        {
                            overTotal = number - overTotal;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Value is not numeric!");
                        limit++;
                        if (limit == 3) break;
                        i--;
                    }
                }

                Console.WriteLine(string.Format("Under Abs: {0}\nOver Abs: {1}", Math.Abs(underTotal), Math.Abs(overTotal)));
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