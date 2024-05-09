using System;

public class GratuityExtended_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Enter the subtotal: ");
    int subtotal = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Percent\tGratuity\tTotal");
    double GratuityR;

    for(double i = 8; i < 14; i+=2) {
        GratuityR = i/100 * subtotal;
        Console.WriteLine (i + "%\t$" + GratuityR + "\t$" + (subtotal+GratuityR));
    }

  }
}
