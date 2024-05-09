//Victor Ivanov 11/6

using System;

public class AveAcceleration_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Initial Velocity: ");
    double Vo = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Final Velocity: ");
    double Vf = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Time: ");
    double t = Convert.ToDouble(Console.ReadLine());

    double a = (Vf - Vo)/t;
    Console.WriteLine("The average acceleration is: " + a);
  }
}
