using System;

public class Vivanov24 {
  public static void Main (string[] args){

	double a = 11.34;
  int test = (int)a;
  test = ( (a - test)*100);
  Console.WriteLine(test);

    Console.WriteLine( (int)((a%1)*100) );

   // Console.WriteLine(a);
  }
}
