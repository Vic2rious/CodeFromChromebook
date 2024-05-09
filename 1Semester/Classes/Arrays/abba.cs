//Victor Ivanov 11/6

using System;

public class Name_VictorIvanov {

  public static string pattern = "aaaa";
  public static string s = "dog cat dog dog";
  public static string[] word = s.Split(' ');
  public static string[] pat = new String[pattern.Length];

  public static void Main (string[] args){

    printArray(word);
    splitToArray(pattern, pat);
    printArray(pat);

    Console.WriteLine(Bum());
    }
    public static void splitToArray(String s, String[] a){
      for(int i = 0; i<s.Length; i++) {
        a[i] = Char.ToString(s[i]);
      }
    }

    public static void printArray(String[] s){
      for (int i = 0; i < s.Length; i++){
        Console.Write(s[i] + " ");
      }
      Console.WriteLine();
    }

    public static bool Bum() {
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
