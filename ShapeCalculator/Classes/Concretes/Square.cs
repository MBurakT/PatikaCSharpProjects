using System;

namespace ShapeCalculator;

class Square : Shape, IShape2D
{
    double _side;

    public Square() : base(4)
    {
        SetPerimeter(CalculatePerimeter());
        SetArea(CalculateArea());
    }

    public override void GetShapeInfos()
    {
        _side = SetFieldValue("Side");
    }

    public double CalculatePerimeter()
    {
        return 4 * _side;
    }

    public double CalculateArea()
    {
        return _side * _side;
    }
}