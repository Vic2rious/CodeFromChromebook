//Victor Ivanov 11/6

using System;

public class StringsReplace_VictorIvanov {
  public static void Main (string[] args)
  {
    
    ReplacementOfStirngs();
    CorrectSentence();
    StringCutting();
    
  }

  public static int findAge(int x, int y) {
    return x - y;
  }

  public static void ReplacementOfStirngs() {
    Console.WriteLine("First Name:");
    string FirstName = Console.ReadLine();
    
    Console.WriteLine("Last Name:");
    string LastName = Console.ReadLine();
    
    Console.WriteLine("City of birth:");
    string CityBirth = Console.ReadLine();
    
    Console.WriteLine("State of birth:");
    string StateBirth = Console.ReadLine();

    Console.WriteLine("Year of birth:");
    string YearBirth = Console.ReadLine();
    const int currentYear = 2023;
    int Age = findAge(currentYear, Convert.ToInt32(YearBirth));

    Console.WriteLine("Famous Quote:");
    string Quote = Console.ReadLine();

    Console.WriteLine($"\nHello, {FirstName} {LastName}.");
    Console.WriteLine($"You were born in {CityBirth}, {StateBirth} in the year of {YearBirth}.");
    Console.WriteLine($"This means you are currently {Age} years old.");
    Console.WriteLine($"You are known to say: \"{Quote}\".\n");
  }

  public static void CorrectSentence() {

    Console.WriteLine("Please enter a sentence:");
    string sen = Console.ReadLine();

    Console.WriteLine("\n" + sen);
    Console.WriteLine(sen.ToUpper());
    Console.WriteLine(sen.ToLower());
    Console.WriteLine(char.ToUpper(sen[0]) + sen.ToLower().Substring(1) + "\n");
  }
  public static void StringCutting() {
    String tale = "It was the best of times, it was the worst of times...";
    String whale = "Call me Ishmael";
    String f451 = "It was a pleasure to burn";
    String web = "Where's Papa going with that ax?";
    String wrinkle = "It was a dark and stormy night";
    String hobbit ="In a hole in the ground there lived a hobbit";

    Console.WriteLine(tale.Substring(11,13));
    Console.WriteLine(whale.Substring(0,7));
    Console.WriteLine(f451.Substring(21).ToUpper());
    Console.WriteLine(web.Substring(8,4));
    Console.WriteLine(wrinkle.Substring(9,15));
    Console.WriteLine(hobbit.Substring(38));

    Console.WriteLine("\n" + whale.Substring(0,8) + web.Substring(8,4).ToUpper());
    Console.WriteLine(char.ToUpper(f451[21]) + f451.Substring(22) + hobbit.Substring(12,5) + hobbit.Substring(38));
    Console.WriteLine(tale.Substring(0,15) + wrinkle.Substring(17));
    
  }
}