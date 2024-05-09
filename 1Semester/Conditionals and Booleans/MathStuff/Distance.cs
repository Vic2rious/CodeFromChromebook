//Victor Ivanov 11/6

using System;

public class Distance_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    double BigX = Math.Pow(x2 - x1, 2);
    double BigY = Math.Pow(y2 - y1, 2);

    double d = Math.Pow(BigX + BigY, 0.5);
    Console.WriteLine("The distance between (" + x1 + ", " + y1 + ") and ("
    + x2 + ", " + y2 + ") is " + d);
  }
}
