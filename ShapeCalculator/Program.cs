using System;
using Utilities;

namespace ShapeCalculator;

class Program
{
    static void Run(string[] args)
    {
        while (true)
        {
            if (!int.TryParse(CustomFunctions.GetInputFromUser("(1) Circle\n(2) Triangle\n(3) Square\n(4) Rectangle\n(0) Quit\n" +
                "Please enter number of shape"), out int choice))
            {
                Console.WriteLine("Shape number is not numeric!");
            }
            else if (choice == 0)
            {
                break;
            }
            else if (choice < 1 || choice > 4)
            {
                Console.WriteLine($"Error: shape number must be greater than zero and less than 5! input: {choice}");
            }
            else
            {
                Shapes shapeChoice = (Shapes)choice;

                if (!int.TryParse(CustomFunctions.GetInputFromUser("(0) Back\n(1) Perimeter\n(2) Area\n" +
                "Please enter number of calculate"), out choice))
                {
                    Console.WriteLine("Calculate number is not numeric!");
                }
                else if (choice == 0) { }
                else if (choice < 0 || choice > 2)
                {
                    Console.WriteLine($"Error: calculate number must be greater than zero and less than 3! input: {choice}");
                }
                else
                {
                    Shape shape = shapeChoice switch
                    {
                        Shapes.Circle => new Circle(),
                        Shapes.Triangle => new Triangle(),
                        Shapes.Square => new Square(),
                        Shapes.Rectangle => new Rectangle()
                    };

                    Calculates calculate = (Calculates)choice;

                    Console.WriteLine($"{calculate}: " +
                    calculate switch
                    {
                        Calculates.Perimeter => shape.GetPerimeter(),
                        Calculates.Area => shape.GetArea()
                    });

                    Console.WriteLine();
                    shape.PrintToConsole();
                }
            }
            Console.WriteLine();
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