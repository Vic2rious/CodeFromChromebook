  using System;

  public class Caesar {
  public static void Main(String[] args){

    String s = "";
    Console.WriteLine("Enter Message: ");
    s = Console.ReadLine();

    Console.WriteLine("Enter shift: ");
    int shift = Convert.ToInt32(Console.ReadLine());

    s = Cipher.caesarEncode(s);
    Console.WriteLine("Encoded Message: "+s);
    s = Cipher.caesarDecode(s);
    Console.WriteLine("Decoded Message: "+s);

    Console.WriteLine();

    s = Cipher.caesarEncode(s, shift);
    Console.WriteLine("Encoded Message: "+s);
    s = Cipher.caesarDecode(s, shift);
    Console.WriteLine("Decoded Message: "+s);

    }


  }

  public class Cipher {

    public static String alphabet = "abcdefghijklmnopqrstuvwxyz";

    /* accepts a string and returns an encrypted string based upon a
    Caesar cipher (left rotation of 3) */

    public static String caesarEncode (String s){
    String encode = "";
      //code goes here

        for (int j = 0; j<s.Length; j++) {
          int i = alphabet.IndexOf(s[j]);
          encode += i == -1 ? s[j] : i > 22 ? alphabet[i-23] : alphabet[i+3];
        }

    return encode;
    }

    /*accepts an encrypted String and returns a plaintext String based upon
    a Caesar cipher (left rotation of 3) */
    public static String caesarDecode (String s){
      String decode = "";
        //code goes here
        for (int j = 0; j<s.Length; j++) {
          int i = alphabet.IndexOf(s[j]);
          decode += i == -1 ? s[j] : i < 3 ? alphabet[23+i] : alphabet[i-3];
        }
      return decode;
    }

    /* accepts a string and returns an encrypted string based upon a
    Caesar cipher with a specified rotation */
  public static String caesarEncode (String s, int shift){
    String encode = "";
        //code goes here
        for (int j = 0; j<s.Length; j++) {
          int i = alphabet.IndexOf(s[j]);
          encode += i == -1 ? s[j] : i > (25-shift) ? alphabet[i-(26-shift)] : alphabet[i+shift];
        }

    return encode;

  }

  /*accepts an encrypted String and returns a plaintext String based upon
  a Caesar cipher with a specified rotation */
  public static String caesarDecode (String s, int shift){
    String decode = "";
      //code goes here
      for (int j = 0; j<s.Length; j++) {
        int i = alphabet.IndexOf(s[j]);
        decode += i == -1 ? s[j] : i < shift ? alphabet[(26-shift)+i] : alphabet[i-shift];
      }
      
    return decode;
    }
  }
