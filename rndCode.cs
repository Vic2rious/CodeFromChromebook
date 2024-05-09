//Victor Ivanov 12/1

using System;

public class Name_VictorIvanov {
  public static void Main (string[] args){

    int max_attempts = 10;
    int attempts = 0;
    string[] words = { "cat", "elephant", "nothing", "vehicle", "crocodile"};
    //string[] words = { "crocodile" };

    bool isWinner = false;
    bool hasLetter = false;
    Random random = new Random();
    int index = random.Next(words.Length);
    string  gameWord = words[index];
    string codeWord = "";
    for (int i = 0; i < gameWord.Length; i++)
    {

        codeWord += "*";

    }

    Console.WriteLine(codeWord);

    do
    {
        //guess
        string temp = "";
        hasLetter = false;
        Console.WriteLine("Wrong Attempts " + attempts);
        Console.WriteLine("letter: ");
        char letter = Console.ReadLine()[0];
        for (int i = 0; i < gameWord.Length; i++)
        {

            if (gameWord[i] == letter)
            {
                temp += gameWord[i];
                hasLetter = true;
            }
            else
            {
                //Console.WriteLine("blabal");

                temp += codeWord[i];
            }



        }
        if (!hasLetter)
        {
            attempts++;

        }
        if (temp.Equals(gameWord))
        {
            Console.WriteLine("Well done!");
            isWinner = true;
            break;
        }
        codeWord = temp;
        Console.WriteLine(codeWord);
    }
    while (attempts <= max_attempts);

    if (!isWinner)
    {
        Console.WriteLine("Sorry, you lost...");
    }
    Console.WriteLine("The word was " + gameWord);
  }
}
