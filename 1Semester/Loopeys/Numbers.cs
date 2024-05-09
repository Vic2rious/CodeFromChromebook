//Victor Ivanov 11/6


using System;

public class Numbers_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int sum = sumOfFactors(num);

    Console.Write("The number is ");

    if(isPerfect(num, sum)) {
      Console.Write("Perfect\n");
    } else if (isDeficient(num, sum)) {
      Console.Write("Deficient\n");
    } else if (isAbundant(num, sum)) {
      Console.Write("Abundant\n");
    }

  }

  public static int sumOfFactors (int n) {
    int s = 0;

    for(int i = 1; i<n; i++) {
      if(n%i == 0) {
        s+=i;
      }
    }

    return s;
  }

  public static bool isPerfect (int n, int s) {
    return s == n ? true : false;
  }

  public static bool isDeficient (int n, int s) {
    return s < n ? true : false;
  }

  public static bool isAbundant (int n, int s) {
    return s > n ? true : false;
  }

}
