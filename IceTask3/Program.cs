namespace IceTask3;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle("Rectangle", 5, 10);
        rect.Display();

        Circle circ = new Circle("Circle", 7);
        circ.Display();
    }
}