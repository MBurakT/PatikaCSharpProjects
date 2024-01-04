using System;
using System.Linq;

namespace Utilities;

public class CustomFunctions
{
    public static string GetInputFromUser(string message, int limit = 3)
    {
        if (limit == 0)
        {
            throw new Exception("Input is invalid, maximum retry number exceeded!");
        }

        Console.Write($"{message}: ");

        string? input = Console.ReadLine();

        if (input is null) input = GetInputFromUser(message, limit - 1);

        return input;
    }

    public static double Average(int[] array)
    {
        return (double)array.Sum() / array.Length;
    }

    public static int[] CreateFibonacciArray(int depth)
    {
        if (depth > 2)
        {
            int[] fib = new int[depth];
            fib[0] = 0;
            fib[1] = 1;

            for (int counter = 2; counter < depth; counter++)
            {
                fib[counter] = fib[counter - 1] + fib[counter - 2];
            }

            return fib;
        }
        else if (depth == 2)
        {
            return [0, 1];
        }
        else if (depth == 1)
        {
            return [0];
        }
        else
        {
            return [];
        }
    }
}