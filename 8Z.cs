using System;

abstract class Shape
{
    protected string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public abstract void draw();

    public bool equals(Shape other)
    {
        if (this.GetType() != other.GetType())
        {
            return false;
        }

        return this.color == other.color;
    }
}

class Circle : Shape
{
    private double x;
    private double y;
    private double radius;

    public Circle(string color, double x, double y, double radius) : base(color)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public override void draw()
    {
        Console.WriteLine($"Рисуем {цветной} круг в точке ({x}, {y}) с радиусом {radius}");
    }

    public bool equals(Circle other)
    {
        if (!base.equals(other))
        {
            return false;
        }

        return this.x == other.x && this.y == other.y && this.radius == other.radius;
    }
}

class Rectangle : Shape
{
    private double x1;
    private double y1;
    private double x2;
    private double y2;

    public Rectangle(string color, double x1, double y1, double x2, double y2) : base(color)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public override void draw()
    {
        Console.WriteLine($"Рисуем прямоугольник {color} с углами в ({x1}, {y1}) и ({x2}, {y2}");
    }

    public bool equals(Rectangle other)
    {
        if (!base.equals(other))
        {
            return false;
        }

        return this.x1 == other.x1 && this.y1 == other.y1 && this.x2 == other.x2 && this.y2 == other.y2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Circle("red", 0, 0, 1),
            new Rectangle("blue", 0, 0, 1, 1),
            new Circle("green", 1, 1, 2)
        };

        foreach (Shape shape in shapes)
        {
            shape.draw();
        }

        Console.WriteLine(shapes[0].equals(shapes[1])); // DA
        Console.WriteLine(shapes[0].equals(shapes[2])); // NET
        Console.WriteLine(shapes[0].equals(shapes[0])); // DA
    }
}