using System;

public class PointClassPt1{
public static void Main (String[] args){
//main method
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
c.setCoordinate(-x, -y);

Console.WriteLine("Point C: ("
+c.getXCoordinate() +" , "+c.getYCoordinate() +")");

}
//other methods live here

}

//other class
class Point {
  //attricbutes
  private double _x;
  private double _y;

  //constructor
  public Point() {
    _x = 0;
    _y = 0;
  }

  public Point(double x, double y) {
    this._x = x;
    this._y = y;
  }

  // getter
  public double getXCoordinate() {
    return this._x;
  }

  public double getYCoordinate() {
    return this._y;
  }

  //setter
  public void setCoordinate(double x, double y) {
    this._x = x;
    this._y = y;
  }

}
