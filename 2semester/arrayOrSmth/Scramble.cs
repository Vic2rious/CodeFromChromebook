//Victor Ivanov 11/6

using System;

public class Scramble {
  public static string original;
  public static void Main(String[] args){


  //add words to the wordList array (should be a theme)


  String[] wordList = {
    "alpha",
    "bravo",
    "charlie",
    "delta",
    "echo",
    "foxtrot",
    "golf",
    "hotel",
    "india",
    "julliet",
    "kilo",
    "lima",
    "mike",
    "november",
    "oscar",
    "papa",
    "quebec",
    "romeo",
    "sierra",
    "tango",
    "uniform",
    "victor",
    "whiskey",
    "xray",
    "yankee",
    "zulu"
  };

  string word = scrambleWord(getWord(wordList));

  while(true) {
    Console.WriteLine(word);
    Console.WriteLine("Guess Word:");
    string guess = Console.ReadLine();
    Console.WriteLine( guess == original ? "good job!" : "try again\n\n");
    if (guess == original) break;

  }

  //get random word
  //scramble word
  //display scrambled word to screen
  //accept user input
  //if correct: end program
  //else re-display scrambled word


  }

  public static String getWord (String[] s){
  //method should get a random word from a String array and return
  //a string.

  Random rnd = new Random();
  int a = rnd.Next(s.Length);
  original = s[a];
  return s[a];

  }

  public static String scrambleWord(String s){

    string output = "";
    Random rnd = new Random();
    int a;

    while(s.Length != 0) {
      a = rnd.Next(s.Length);
      output += s[a];
      s = s.Remove(a,1);
      //Console.WriteLine(s);
    }
    return output;


  //method should accept a string.
  //the string should then be randomly scrambled.
  //a scrambled string, of the same length, should be returned.
  //USE STRING METHODS
  }
}
