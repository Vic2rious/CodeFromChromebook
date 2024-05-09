//Victor Ivanov 11/6

using System;

public class Name_VictorIvanov {
  public static int ways = 0;
  public static void Main (string[] args){

    int[,] A = {{0, 0, 0, 0},
                {0, 0, 1, 0},
                {1, 0, 0, 0}};

    fun(A, 0, 0);

    Console.WriteLine(ways);
  }

  public static void fun(int[,] arr, int x, int y) {
    if(x == arr.GetLength(0)-1 && y == arr.GetLength(1)-1) {
      ways++;
      return;
    }

    if(x != arr.GetLength(0)-1) {
      if (arr[x+1,y] == 0) {
        fun(arr, x+1, y);
      }
    }
    if (y!= arr.GetLength(1)-1) {
      if (arr[x,y+1] == 0){
       fun(arr, x, y+1);
     }
    }

  }
}
