namespace IceTask3;

public class Circle : Shape, ICalculateArea
{
    public double Radius { get; set; }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea()}");
    }
}