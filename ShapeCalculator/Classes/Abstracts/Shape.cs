using System;

namespace ShapeCalculator;

abstract class Shape
{
    int _sideNumber;
    double _perimeter;
    double _area;

    public int SideNumber => _sideNumber;
    public double GetPerimeter() { return _perimeter; }
    protected void SetPerimeter(double perimeter) { _perimeter = perimeter; }
    public double GetArea() { return _area; }
    protected void SetArea(double area) { _area = area; }

    public Shape(int sideNumber)
    {
        _sideNumber = sideNumber;
        GetShapeInfos();
    }

    public string GetInputFromUser(string message, int limit = 3)
    {
        if (limit == 0)
            throw new Exception("Input is invalid, maximum retry number exceeded!");

        Console.Write($"{message}: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            input = GetInputFromUser(message, limit - 1);

        return input;
    }

    public double SetFieldValue(string message, int limit = 3)
    {
        if (limit == 0)
            throw new Exception("Input is invalid!");

        if (!double.TryParse(GetInputFromUser(message), out double input))
            SetFieldValue(message, limit - 1);

        return input;
    }

    public virtual void PrintToConsole()
    {
        Console.WriteLine($"Side Number : {_sideNumber}\nPerimeter   : {_perimeter}\nArea        : {_area}");
    }

    public abstract void GetShapeInfos();
}