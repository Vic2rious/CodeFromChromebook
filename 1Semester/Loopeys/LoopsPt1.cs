//Victor Ivanov 11/6

using System;

public class LoopsClass_VictorIvanov {
  public static void Main (string[] args){
    countdown(10);
    Console.WriteLine();
    countTo(1,8);
    Console.WriteLine();
    Console.WriteLine(isPrime(223));
    Console.WriteLine();
    findPrime();
    Console.WriteLine();
    divisibleBy5and6();
    Console.WriteLine();
    divisibleBy5or6();

  }

  public static void countdown(int a) {
    while(a>=0) {
      Console.WriteLine(a--);
    }
  }

  public static void countTo(int a, int b) {
    if (b<a) {
      Console.WriteLine(-1);
    } else {
      while(a<=b) {
      Console.WriteLine(a++);
      }
    }

  }

  public static bool isPrime(int a) {
    for(int i = 2; i<=a/2; i++) {
      if(a%i == 0) {
        return false;
      }
    }
    return true;
  }

  public static void findPrime() {
    for(int i = 2; i<=100; i++) {
      Console.Write(isPrime(i) == true ? i + " " : "");
    }
    Console.WriteLine();
  }

  public static void divisibleBy5and6(){

    int j = 0;
    for(int i = 100; i<=1000; i++) {

      if(i%5 == 0 && i%6 == 0) {
        j++;
        Console.Write(j%10 != 0 ? i + " " : i + "\n");
      }
    }
  }

  public static void divisibleBy5or6(){

    int j = 0;
    for(int i = 100; i<=1000; i++) {

      if(i%30 != 0 && (i%5 == 0 || i%6 == 0)) {
        j++;
        Console.Write(j%10 != 0 ? i + " " : i + "\n");
      }
    }
  }
}
