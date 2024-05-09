//Victor Ivanov 11/6

using System;

public class PointClassPt2_VictorIvanov{
  public static void Main (String[] args){

  Point a = new Point();

  Console.WriteLine("First Point");
  Console.Write("X: ");
  double x = Convert.ToDouble(Console.ReadLine());
  Console.Write("Y: ");
  double y = Convert.ToDouble(Console.ReadLine());
  a.setCoordinate(x, y);

  Point b = new Point(x, y);

  Console.WriteLine("\nSecond Point");
  Console.Write("X: ");
  x = Convert.ToDouble(Console.ReadLine());
  Console.Write("Y: ");
  y = Convert.ToDouble(Console.ReadLine());
  b.setCoordinate(x, y);


  Console.WriteLine("\nPoint A: ("
  +a.getXCoordinate() +" , "+a.getYCoordinate() +")");

    Console.WriteLine("Point B: ("
  +b.getXCoordinate() +" , "+b.getYCoordinate() +")");

    Point c = new Point();
  //c.setCoordinate(-x, -y);

    Console.WriteLine("Point C: ("
  +c.getXCoordinate() +" , "+c.getYCoordinate() +")");

    Console.WriteLine("Distance from A to B: "+a.distance(b));
    Console.WriteLine("Point A: ("
  +a.getXCoordinate() +" , "+a.getYCoordinate() +")");
  a.flip();
    Console.WriteLine("Flip A: ("
  +a.getXCoordinate() +" , "+a.getYCoordinate() +")");
    Console.WriteLine("The line from Point A to Point B is vertical: "+ a.isVertical(b));
    Console.WriteLine("The line from Point B to Point C is vertical: "+ b.isVertical(c));
    Console.WriteLine("The slope between B and C is: "+b.slope(c));
    Console.WriteLine("Quadrant of Point A: "+a.quadrant());
    Console.WriteLine("Quadrant of Point B: "+b.quadrant());
    Console.WriteLine("Quadrant of Point C: "+c.quadrant());
  }
}

class Point {
  //attricbutes
  private double x;
  private double y;

  //constructor
  public Point() {
    x = 0;
    y = 0;
  }

  public Point(double x, double y) {
    this.x = x;
    this.y = y;
  }

  public double distance (Point other) {
    double a = Math.Pow(other.x - this.x, 2);
    double b = Math.Pow(other.y - this.y, 2);

    return Math.Sqrt(a+b);
  }

  // getter
  public double getXCoordinate() {
    return this.x;
  }

  public double getYCoordinate() {
    return this.y;
  }

  public bool isVertical(Point other) {
    return this.x == other.x;
  }

  public double slope (Point other) {
    return (other.y-this.y)/(other.x-this.x);
  }

  public int quadrant (){
    if(this.x == 0 || this.y == 0){
      return 0;
    }
      if(this.x > 0) {
        return this.y>0 ? 1 : 4;
      }

      return this.y>0 ? 2 : 3;

  }

  //setter
  public void setCoordinate(double x, double y) {
    this.x = x;
    this.y = y;
  }

  public void flip() {
    this.x = this.x + this.y;
    this.y = (this.x - this.y);
    this.x = (this.x - this.y)*-1;
    this.y*=-1;
  }
}
