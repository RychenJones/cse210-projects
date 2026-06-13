public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    {
        _radius = radius;
        SetColor(color);
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}