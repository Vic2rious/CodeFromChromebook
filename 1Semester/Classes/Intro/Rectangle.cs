//Victor Ivanov 11/6

using System;

public class Rectangle_VictorIvanov {
  public static void Main (string[] args){

    Rectangle r = new Rectangle();
    Rectangle g = new Rectangle(142, 857);

    Console.WriteLine("Rectangle R:");
    r.setLength(1.2);
    r.setHeigth(8.6);
    Console.WriteLine("Length: " + r.GetL());
    Console.WriteLine("Heigth: " + r.GetH());
    Console.WriteLine("Area " + r.GetArea());

    Console.WriteLine();

    Console.WriteLine("Rectangle G:");
    Console.WriteLine("Length: " + g.GetL());
    Console.WriteLine("Heigth: " + g.GetH());

  }

  public static double randomNumber(double n) {
    Random a = new Random();

    n = a.Next(0,100);
    return n;
  }


}

class Rectangle {
  //attricbutes
  private double l;
  private double h;

  //constructor
  public Rectangle() {
    l = 1;
    h = 1;
  }

  public Rectangle(double L, double H) {
    this.l = L;
    this.h = H;
  }

  // getter
  public double GetL() {
    return this.l;
  }

  public double GetH() {
    return this.h;
  }

  public double GetArea() {
    return this.h*this.l;
  }

  //setter
  public void setLength(double L) {
    this.l = L;
  }

  public void setHeigth(double H) {
    this.h = H;
  }

}
