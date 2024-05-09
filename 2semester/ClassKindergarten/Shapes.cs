//Victor Ivanov 11/6

using System;

public class Shape
{
    protected double area { get; set; }
    protected double perimiter { get; set; }

    protected string colour { get; set; }
    protected int sides { get; set; }

    public virtual double getArea()
    {
        return area;
    }

    public virtual double getPerimiter()
    {
        return perimiter;
    }

    public virtual string getColour()
    {
        return colour;
    }

    public virtual int getSides()
    {
        return sides;
    }
}

public class Rectangle : Shape
{
    protected int width;
    protected int length;

    colour = "blue";
    sides = 4;

    public Rectangle(int w, int l)
    {
        this.width = w;
        this.length = l;
    }
    area = width*length;
    perimiter = 2*(width+length);

}

public class Square : Rectangle
{
  colour = "red";

  public Square(int s)
    {
        this.width = s;
        this.length = s;
    }
}

public class Triangle : Shape
{
  sides = 3;
  colour = "pink";
  protected double halfP;
    public Triangle(int a, int b, int c) {
      perimiter = a + b + c;
      halfP = perimiter/2;
      area = Math.Sqrt(halfP * ( halfP - a) * (halfP - b) * (halfP - c));
    }
}

public class Circle : Shape
{
    protected double circimfurance;
    sides = 0;

    public Circle(int r) {
      circimfurance = 2 * r * Math.PI;
      area = Math.PI * r * r;
    }

    public override string GetSides()
    {
        return base.GetSides().ToString() + " or infinite, depends how you look at it";
    }

    public override double getPerimiter()
    {
        return circimfurance; // circles don't have perimeters
    }
}

public static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rect: ");
        Employee jim = new Rectangle(3, 4);
        Console.WriteLine("Area:\t" + jim.getArea());
        Console.WriteLine("Perimeter:\t\t" + jim.getPerimiter());
        Console.WriteLine("Colour:\t" + jim.getColour());
        Console.WriteLine("Sides\t" + jim.getSides());

        Console.WriteLine("Square: ");
        Employee bob = new Square(3);
        Console.WriteLine("Area:\t" + bob.getArea());
        Console.WriteLine("Perimeter:\t\t" + bob.getPerimiter());
        Console.WriteLine("Colour:\t" + bob.getColour());
        Console.WriteLine("Sides\t" + bob.getSides());

        Console.WriteLine("Trianlge: ");
        Employee juan = new Triangle(3, 4, 5);
        Console.WriteLine("Area:\t" + juan.getArea());
        Console.WriteLine("Perimeter:\t\t" + juan.getPerimiter());
        Console.WriteLine("Colour:\t" + juan.getColour());
        Console.WriteLine("Sides\t" + juan.getSides());

        Console.WriteLine("Circle: ");
        Employee jeff = new Circle(3);
        Console.WriteLine("Area:\t" + jeff.getArea());
        Console.WriteLine("Perimeter:\t\t" + jeff.getPerimiter());
        Console.WriteLine("Colour:\t" + jeff.getColour());
        Console.WriteLine("Sides\t" + jeff.getSides());

    }
}
