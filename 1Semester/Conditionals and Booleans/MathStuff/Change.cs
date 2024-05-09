//Victor Ivanov 11/6

using System;

public class Change_VictorIvanov {
  public static void Main (string[] args){

    int[] arr = {50, 20, 10, 5, 2, 1};

    Console.WriteLine("Enter an amount in leva: ");
    double money = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Your amount of " + money + " leva consists of:");

    Console.WriteLine((int)money + "\tLeva");

    int sum =Convert.ToInt32(money%1 * 100); //sum of Stotinki
    // int sum = (int)SumBeta; Doesn't work

    //int sum = Convert.ToInt32(SumBeta);

    for(int i = 0; i < 6; i++) {

        Console.WriteLine(sum/arr[i] + " " + arr[i] + " Stotinki ");
        sum-=(sum/arr[i])*arr[i];
    }
  }
}
