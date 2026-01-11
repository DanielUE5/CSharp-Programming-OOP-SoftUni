using System;
namespace ClassBoxData;
public class Box
{
    private double Length;
    private double Width;
    private double Height;

    private const string ExceptionMessage = "{0} cannot be zero or negative.";

    public Box(double length, double width, double height)
    { 
        if (length <= 0) throw new ArgumentException(string.Format(ExceptionMessage, "Length"));
        if (width <= 0) throw new ArgumentException(string.Format(ExceptionMessage, "Width"));
        if (height <= 0) throw new ArgumentException(string.Format(ExceptionMessage, "Height"));

        Length = length;
        Width = width;
        Height = height;
    }

    public double SurfaceArea()
    {
        return 2 * (Length * Width + Width * Height + Height * Length);
    }

    public double LateralSurfaceArea()
    {
        return 2 * Height * (Length + Width);
    }

    public double Volume()
    {
        return Length * Width * Height;
    }
}
