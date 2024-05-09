//Victor Ivanov 11/6

using System;

public class F2M_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Enter a value for feet: ");
    double feet = Convert.ToDouble(Console.ReadLine());
    double meter = feet*0.305;
    Console.WriteLine(feet + " feet is " + meter + " meters");
  }
}
