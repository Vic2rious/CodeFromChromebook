//Victor Ivanov 11/6

using System;

public class CoinTossStats_VictorIvanov {
  public static void Main (string[] args){

    int menuChoice;             //user input menu option
    int total = 0;
    int numHeads = 0;
    int numTails = 0;
    bool enterMenu = true;   //for the menu loop

    while(enterMenu != false) {
      Console.WriteLine();
      Console.WriteLine("Coin Toss Simulator (with stats)");
      Console.WriteLine("1. Simulate");
      Console.WriteLine("2. Display Stats");
      Console.WriteLine("3. Clear Stats");
      Console.WriteLine("4. Exit");

      menuChoice = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine();

      switch (menuChoice) {
        case 1:
        Console.WriteLine("Number of Simulations: ");
        int a = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i<a; i++) {
          bool isHeads = coinToss();
          if(isHeads == true) {
            numHeads++;
          } else numTails++;
          total++;
          Console.WriteLine(isHeads == true ? "Heads" : "Tails");
        }
        break;
        case 2:
          displayStats(numHeads, numTails, total);
        break;
        case 3:
          total = 0;
          numHeads = 0;
          numTails = 0;
          Console.WriteLine("Stats cleared!");
        break;
        case 4:
          enterMenu = false;
          Console.WriteLine("Goodbye!");
        break;
        default:
          Console.WriteLine("Not an option! Choose between 1 and 4 only!");
        break;

      }
    }

  }

  //coinToss(): returns a 0 or 1 to represent Heads or Tails

public static bool coinToss () {
    Random rnd = new Random();
    int a = rnd.Next(0,2);

    return a == 1 ? true : false;
  }

//displayStats will handle ALL of the output for the menu option 2.

//Method will display appropriate stats OR display "No stats to report" if total = 0

//method header:

public static void displayStats(int heads, int tails, int totalFlips) {

    if(totalFlips == 0) {
      Console.WriteLine("No stats to report!");
      return;
    }

    Console.WriteLine("Stats of " + totalFlips + " tosses");
    Console.WriteLine("Heads: " + heads);
    Console.WriteLine("Tails: " + tails);
    Console.WriteLine("Total: " + totalFlips);
    Console.WriteLine("Percentage:");
    Console.WriteLine("%Heads " + (double)heads*100/totalFlips + "%");
    Console.WriteLine("%Tails " + (double)tails*100/totalFlips + "%");
  }

}
