namespace IceTask3;

public class Rectangle : Shape, ICalculateArea
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string name, double width, double height) : base(name)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Width: {Width}, Height: {Height}, Area: {CalculateArea()}");
    }
}
