//Victor Ivanov 11/6

using System;

public class RunwayLength_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Takeoff Speed: ");
    double Vf = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Acceleration: ");
    double a = Convert.ToDouble(Console.ReadLine());

    double d = Math.Pow(Vf, 2)/2/a;
    Console.WriteLine("The minimum runway length is: " + d);
  }
}
