//Victor Ivanov 11/6

using System;

public class HighLowGame_VictorIvanov {
  public static void Main (string[] args){

    Random rnd = new Random();
    int a = rnd.Next(1,100);

    int tries = 6;
    Console.WriteLine("I have thought of a number between 0 and 100.....");

    while(tries != 0) {

      Console.WriteLine("Please guess a number between 0 and 100");
      Console.WriteLine("You have " + tries + " remaining");
      int n = Convert.ToInt32(Console.ReadLine());

      if(n == a) {
        Console.WriteLine("Great Job! You guessed the number in " + (7-tries) + " tries!");
        break;

      }

      Console.WriteLine("You guessed too " + (n<a ? "LOW" : "HIGH"));
      Console.WriteLine();
      tries--;
      Console.WriteLine();

    }

    if(tries == 0) {
      Console.WriteLine("Sorry, the number was " + a);
    }

    Console.WriteLine("Press any key to quit");
    Console.WriteLine();
    Console.ReadLine();

  }
}
