//Victor Ivanov 12/1

using System;

public class Stuff_VictorIvanov {
  public static void Main (string[] args){

    int k = 6;
    string sentence = "abcdefghijklmnopqrstuvwxyz";
    int TheLength = sentence.Length;
    sentence+=space(k*2);

    int sum = 0;

    for(int i = 0; i<k; i++) {
      for(int j = 0; j < TheLength; j+=k*2-2) {
        Console.Write(space(i));
        Console.Write(sentence[i +j]);
        Console.Write(space((k-1)*2 - 1 - i*2));

        if(i != (k-1) && i != 0)
        Console.Write(sentence[(k-1)*2 - i + j]);

        Console.Write(space(i-1));


      }
      Console.WriteLine();

    }
  }

  public static string space(int a) {
    string space = "";
    for(int i = 0; i<a; i++) {
      space+=" ";
    }
    return space;
  }
}

/*

(k-1)*2 - 1

Given a string and a number of lines k, print the string in zigzag form.
In zigzag, characters are printed out diagonally from top left to bottom right
until reaching the kth line, then back up to top right, and so on.

For example, given the sentence "thisisazigzag" and k = 4, you should print:

t     a     g
 h   s z   a
  i i   i z
   s     g
*/
