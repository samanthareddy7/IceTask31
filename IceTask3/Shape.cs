namespace IceTask3;

public abstract class Shape
{
    public string Name { get; set; }

    public Shape(string name)
    {
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Shape: {Name}");
    }
}

