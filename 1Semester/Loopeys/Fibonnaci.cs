//Victor Ivanov 11/6

using System;

public class Name_VictorIvanov {
  public static void Main (string[] args){



    Console.WriteLine("How many Fibonnaci numbers to write?");
    int num = Convert.ToInt32(Console.ReadLine());
    FibonacciAmount(num);



    //Console.Write("1 ") 1 1 2 3 5


  }

  public static void FibonacciAmount(int n){

    int n1 = 0;
    int n2 = 1;

    for(int i = 0; i<n; i++) {
    
    n2 = n1*2 + n2;
    n1 = n2 - n1;
    n2 = n2 - n1;

    Console.Write(n2 + " ");
    }
  }
}
