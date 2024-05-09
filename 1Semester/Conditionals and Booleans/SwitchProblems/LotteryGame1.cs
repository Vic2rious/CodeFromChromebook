//Victor Ivanov 11/6

using System;

public class LotteryGame1_VictorIvanov {
  public static void Main (string[] args){

    Random rnd = new Random();
    int A = rnd.Next(10);
    int B = rnd.Next(10);

    //int A = 0;
    //int B = 8;

    Console.WriteLine("Enter your lottery pick (two digits): ");
    int Inp = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The lottery number is " + A + "" + B);
    Console.WriteLine(Output(A, B, Inp));

  }

  public static string Output(int a, int b, int inp) {
    int ia = inp / 10;
    int ib = inp % 10;

    if(ia == a || ib == b) {
      if (ia == a && ib == b) {
        return "Exact match: you win $10,000";
      }
      return "Match one digit: you win $1,000";
    } else if (ia == b && ib == a) {
        return "Match all digits: you win $3,000";
    } else {
      return "Sorry: no match";
    }


  }
}
