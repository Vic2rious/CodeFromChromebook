//Victor Ivanov 11/6

using System;

public class PointClassPt1_VictorIvanov {
  public static void Main (string[] args){

    Point p = new Point();
    Console.WriteLine("Rectangle A:");
    r.setLength(1.2);
    r.setHeigth(8.6);
    Console.WriteLine("Length: " + r.GetL());
    Console.WriteLine("Heigth: " + r.GetH());

  }


}

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
  public double GetXcoordinate() {
    return this._x;
  }

  public double GetYcoordinate() {
    return this._y;
  }

  //setter
  public void setCoordinate(double x, double y) {
    this._x = x;
    this._y = y;
  }


}
