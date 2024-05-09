//Victor Ivanov 11/6

using System;

public class TablePow_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("a\tb\tpower(a, b)");

    for(int i = 1; i < 6; i++) {
        Console.WriteLine (i + "\t" + (i+1) + "\t" + Math.Pow(i, i+1));
    }

  }
}
