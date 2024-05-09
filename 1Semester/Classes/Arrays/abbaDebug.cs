using System;

public class Solution {
  public static string pattern1 = "abba";
  public static string s1 = "dog dog dog dog";

  public static void Main (string[] args){

    Console.WriteLine(WordPattern(pattern1, s1));
    }

    public class Solution {
    public bool WordPattern(string pattern, string s) {
        public static string[] word = s.Split(' ');
        public static string[] pat = new String[pattern.Length];

        for(int i = 0; i<s.Length; i++) {
        pat[i] = Char.ToString(word[i]);
      }

        for(int i = 0; i<word.Length; i++) {
            for(int j = i + 1; j<word.Length; j++) {
                if(pat[i] == pat[j]) {
                    if(word[i] != word[j]) {
                    return false;
                    }
                }
                if(word[i] == word[j]) {
                    if(pat[i] != pat[j]) {
                    return false;
                    }
                }
            }
      }
      return true;
    }
  }
}
