//Victor Ivanov 11/6

using System;

public class Add2_VictorIvanov {
  public static void Main (string[] args){

    Random rnd = new Random();
    int a = rnd.Next(10);
    int b = rnd.Next(10);
    int sum = a + b;
    bool isCorrect;


    Console.WriteLine(a + " + " + b + " = ");
    int UserSum = Convert.ToInt32(Console.ReadLine());

    isCorrect = (UserSum == sum) ? true : false;

    Console.Write(a + " + " + b + " = " + UserSum);

    switch (isCorrect) {
      case true:
        Console.WriteLine(" is true");
        Console.WriteLine("Good Job!");
      break;

      case false:
        Console.WriteLine(" is false");
        Console.WriteLine("Wrong Answer!");
      break;

    }


  }
}
