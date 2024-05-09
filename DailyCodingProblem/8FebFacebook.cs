// Good morning! Here's your coding interview problem for today.
//
// This problem was asked by Facebook.
//
// Given a string of round, curly, and square open and closing brackets,
// return whether the brackets are balanced (well-formed).
//
// For example, given the string '([])[]({})', you should return true.
//
// Given the string '([)]' or '((()', you should return false.

//Victor Ivanov 11/6

using System;
using System.Linq;
using System.Collections.Generic;

public class Name_VictorIvanov {

  public static string a = "([])[]({})";
  public static string b = "([)]";
  public static string c = "([])";

  public static char[] open = {'(', '{', '['};
  public static char[] close = {')', '}', ']'};
  public static Dictionary<char, char> brackets =
  new Dictionary<char, char>();


  public static void Main (string[] args){

    brackets.Add('(', ')');
    brackets.Add('{', '}');
    brackets.Add('[', ']');


    a = c;
    Console.WriteLine(a);
    Console.WriteLine(jab(0));




  }

  public static bool jab(int count) {
    if(open.Contains(a[count])) {
      return jab(count++);
    } else if (a[count--] == brackets[a[count]]) {
      return true;
    } else {
      return false;
    }

  }
}
