//Victor Ivanov 11/6

using System;

public class Quad_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Quadratic Solver with Discriminate");

    Console.WriteLine("Enter A: ");
    double A = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter B: ");
    double B = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter C: ");
    double C = Convert.ToDouble(Console.ReadLine());

    switch (numRoots(A, B, C))
    {
      case 0:
      Console.WriteLine("Equation has no real roots!");

      break;
      case 1:
      Console.WriteLine("Equation has one real root:");
      Console.WriteLine(findZeroDiscriminateQuad(A, B, C));

      break;
      case 2:
      Console.WriteLine("Equation has two real roots: ");
      Console.WriteLine(findPositiveQuad(A, B, C) + " and " + findNegativeQuad(A, B, C));

      break;
      case 3:
      Console.WriteLine("Solutions do not exist!");
      break;
    }

  }
  public static int numRoots (double a, double b, double c) {

    if(a==0) {
      return 3;
    } else if ((b*b - 4*a*c) > 0) {
      return 2;
    } else if ((b*b - 4*a*c) == 0) {
      return 1;
    } else {
      return 0;
    }
  }

  public static double findPositiveQuad(double a, double b, double c) {
    return ((Math.Sqrt(b*b - 4*a*c) - b)/2*a);
  }


  public static double findNegativeQuad(double a, double b, double c) {
    return ((Math.Sqrt(b*b - 4*a*c) + b)/-2*a);
  }

  public static double findZeroDiscriminateQuad(double a, double b, double c) {
    return (b/-2*a);
  }

}
