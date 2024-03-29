using System;

namespace ShapeCalculator;

class Rectangle : Shape, IShape2D
{
    double _firstSide;
    double _secondSide;

    public Rectangle() : base(4)
    {
        SetPerimeter(CalculatePerimeter());
        SetArea(CalculateArea());
    }

    public override void GetShapeInfos()
    {
        _firstSide = SetFieldValue("First Side");
        _secondSide = SetFieldValue("Second Side");
    }

    public double CalculatePerimeter()
    {
        return 2 * (_secondSide + _firstSide);
    }

    public double CalculateArea()
    {
        return 2 * _secondSide * _firstSide;
    }
}