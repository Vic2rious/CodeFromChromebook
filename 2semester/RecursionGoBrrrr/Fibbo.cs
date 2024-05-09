//Victor Ivanov 11/6

using System;

public class Name_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine(fib(12));
  }

  public static long fib (int n) {
    if(n == 1) {
      return 1;
    } else if(n == 0) {
      return 0;
    }
    return fib(n-1) + fib(n-2);
  }
}
