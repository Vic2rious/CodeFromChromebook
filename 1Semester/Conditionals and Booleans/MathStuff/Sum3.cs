//Victor Ivanov 11/6

using System;

public class Sum3_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Enter a number between 0 and 1000: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int sum = 0;

    while (num != 0) {
      sum+=num%10;
      num/=10;
    }
    Console.WriteLine("The sum of the digits is " + sum);
  }
}
