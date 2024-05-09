//Victor Ivanov 11/6

using System;

public class Sorting_VictorIvanov {
  public static void Main (string[] args){

    //Random rnd = new Random();


    Console.WriteLine("Enter three values:");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());


    /*for(int i = 0; i<arr.Length; i++) {
      arr[i] = rnd.Next(100);
    }*/

    Console.Write("Ascending: ");
    displayAscending(a, b, c);
    Console.WriteLine();

    Console.Write("Descending: ");
    displayDescending(a, b, c);
    Console.WriteLine();


  }

  public static void displayDescending(int x, int y, int z){

        if(x<y){
          x+=y;
          y=x-y;
          x=x-y;
        }

        if(y<z){
          y+=z;
          z=y-z;
          y=y-z;
        }

        if(x<y){
          x+=y;
          y=x-y;
          x=x-y;
        }

        Console.Write(x + ", " + y + ", " + z);

  }


  public static void displayAscending(int x, int y, int z){

    if(x>y){
      x+=y;
      y=x-y;
      x=x-y;
    }

    if(y>z){
      y+=z;
      z=y-z;
      y=y-z;
    }

    if(x>y){
      x+=y;
      y=x-y;
      x=x-y;
    }

    Console.Write(x + ", " + y + ", " + z);
  }


}
