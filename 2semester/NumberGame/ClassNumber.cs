//Victor Ivanov 11/6

using System;

public class NumberGameWithClasses_VictorIvanov {
  public static void Main (string[] args){

    int tries = 7;
    int maxNumber = 100;

    Player p = new Player();
    Number num = new Number(maxNumber, tries);

    Console.WriteLine($"I have thought of a number between 0 and {maxNumber}.....");
    Console.WriteLine();
    while(p.tries != num.maxTries) {

      Console.WriteLine("Please guess a number between 0 and 100");
      Console.WriteLine($"You have {num.maxTries - p.tries} remaining");

      if (p.Guess() == num.Num) {
        Console.WriteLine($"Great Job! You guessed the number in {p.tries+1} tries!");
        break;
      }
      else {
        Console.WriteLine("You guessed too " + (p.guess<num.Num ? "LOW" : "HIGH"));
        p.turnEnd();
        if(p.tries == num.maxTries) {
          Console.WriteLine("The number was " + num.Num);
        }
      }


      }

  }
}

public class Number {

  public int Num {get; private set;}
  public int maxTries {get; private set;}

  public Number(int n, int maxT) {
    Random rnd = new Random();
    Num = rnd.Next(n);
    this.maxTries = maxT;

  }

}

public class Player {

  public int tries {get; private set;}
  public int guess {get; private set;}

  public Player() {
    this.tries = 0;
  }

  public void turnEnd() {
    this.tries++;
  }

  public int Guess() {
    this.guess = Convert.ToInt32(Console.ReadLine());
    return this.guess;
  }

}
