using System;

namespace Utilities;

public class CustomFunctions
{
    public static string GetInputFromUser(string message, int limit = 3)
    {
        if (limit == 0)
        {
            throw new Exception("Input is invalid, limit exceeded!");
        }

        Console.Write($"{message}: ");

        string? input = Console.ReadLine();

        if (input is null) input = GetInputFromUser(message, limit - 1);

        return input;
    }
}
