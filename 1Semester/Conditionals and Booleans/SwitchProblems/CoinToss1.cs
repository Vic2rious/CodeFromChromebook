//Victor Ivanov 11/6

using System;

public class CoinToss1_VictorIvanov {
  public static void Main (string[] args){

    Random rnd = new Random();
    int a = rnd.Next();
    bool isHeads = false;

    Console.Write("The result of the coin toss is: ");
    Console.WriteLine(CoinFlip(a, isHeads) == true ? "true" : "false");
  }

  public static Boolean CoinFlip (int num, bool coin) {
    coin = (num % 2 == 0) ? true : false;
    return coin;
  }
}
