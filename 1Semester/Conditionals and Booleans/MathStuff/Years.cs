//Victor Ivanov 11/6

using System;

public class Years_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Enter a number of minutes: ");
    int min = Convert.ToInt32(Console.ReadLine());

    int y = min/525600;
    int d = (min%525600)/1440;

    Console.WriteLine(min + " minutes is approximately " + y
    + " years and " + d + " days");
  }
}
