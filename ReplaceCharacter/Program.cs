using System;
using Utilities;

namespace ReplaceCharacter;

class Program
{
    static void Run(string[] args)
    {
        while (true)
        {
            string input = CustomFunctions.GetInputFromUser("Please enter text that you wanna replace");

            if (input.Equals("0"))
                break;
            else if (input.Length == 1)
                Console.WriteLine(input);
            else
            {
                char[] words = input.ToCharArray();

                char temp = words[0];
                words[0] = words[words.Length - 1];
                words[words.Length - 1] = temp;

                Console.WriteLine(words);
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