using System;
using Utilities;
using System.Linq;

namespace SumIntegers;

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
                int[] numbers = new int[size];
                bool isSame = true;
                int temp = 0, limit = 0;


                for (int i = 0; i < size; i++)
                {
                    if (int.TryParse(CustomFunctions.GetInputFromUser("Please enter number"), out numbers[i]))
                    {
                        if (i == 0)
                            temp = numbers[i];
                        else if
                            (temp != numbers[i]) isSame = false;
                    }
                    else
                    {
                        Console.WriteLine("Value is not numeric!");
                        limit++;
                        if (limit == 3) break;
                        i--;
                    }
                }

                if (limit == 3) break;

                if (isSame)
                    Console.WriteLine(Math.Pow(temp, size));
                else
                    Console.WriteLine(numbers.Sum());
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