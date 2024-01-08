using System;
using Utilities;

namespace ConsonantWordControl;

class Program
{
    static void Run(string[] args)
    {
        while (true)
        {
            string input = CustomFunctions.GetInputFromUser("Please enter text that you wanna control");

            if (input.Equals("0") || input.Length < 2)
                break;
            else
            {
                string[] words = input.Split(' ');

                foreach (string word in words)
                {
                    bool isConsonant = false;
                    char[] temp = word.ToCharArray();
                    int length = temp.Length;

                    if (length > 2)
                    {
                        length--;

                        for (int i = 0; i < length; i++)
                        {
                            if (CustomFunctions.IsConsonant(temp[i]) && CustomFunctions.IsConsonant(temp[i + 1]))
                            {
                                isConsonant = true;
                                break;
                            }
                        }
                    }

                    Console.Write($"{isConsonant} ");
                }

                Console.WriteLine();
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