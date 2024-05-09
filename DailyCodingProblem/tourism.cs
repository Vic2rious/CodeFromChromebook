//Victor Ivanov 11/6

using System;

public static class globals {

  public static int N = 6; // gradove
  public static int M = 7; // magistrali
  public static int K = 3; // pravilo za plashtane
  public static Stack Paths = new Stack();
  public static Stack FullTax = new Stack();
  public static Stack PastCities = new Stack();


}


public class tourism_VictorIvanov {

  public static void Main (string[] args){


    grad[] gradove = new grad[globals.N];
    gradove[1-1].makeMagistrala(gradove[2-1], 2);
    gradove[2-1].makeMagistrala(gradove[3-1], 2);
    gradove[3-1].makeMagistrala(gradove[4-1], 2);
    gradove[4-1].makeMagistrala(gradove[5-1], 8);
    gradove[5-1].makeMagistrala(gradove[1-1], 1);
    gradove[5-1].makeMagistrala(gradove[6-1], 7);
    gradove[4-1].makeMagistrala(gradove[6-1], 3);

  }


}

public class grad {
  grad[] connections = new grad[globals.N-1];
  int[] taxes = new int[globals.N];
  int countMagistrala = 0;

  public void makeMagistrala(grad b, int tax) {
    connections[countMagistrala] = b;
    b.connections[countMagistrala] = this;

    taxes[countMagistrala] = tax;
    b.taxes[countMagistrala] = tax;

    countMagistrala++;

  }
}
