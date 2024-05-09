// Good morning! Here's your coding interview problem for today.
//
// This problem was asked by Google.
//
// Find the minimum number of coins required to make n cents.
//
// You can use standard American denominations, that is, 1¢, 5¢, 10¢, and 25¢.
//
// For example, given n = 16, return 3 since we can make it with a 10¢, a 5¢, and a 1¢.

//Victor Ivanov 11/6

using System;

public class Cents_VictorIvanov {
  public static void Main (string[] args){

    int[] values = {25, 10, 5, 1};
    int n = 16;
    int sum = 0;

    foreach(var i in values) {
      sum+= (n/i);
      n-=(n/i)*i;
    }
    Console.WriteLine(sum);
    Console.WriteLine(rec(16, 0, values));

  }

  public static int rec(int n, int i, int[] values) {
    return i == values.Length - 1 ? n/values[i] : n/values[i] + rec(n-(n/values[i])*values[i], ++i, values);
  }
}
