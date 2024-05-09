//Victor Ivanov 11/6

using System;

public class Name_VictorIvanov {
  public static void Main (string[] args){

    Random rnd = new Random();
    int[] arr = new int[10];


    for(int i = 0; i<arr.Length; i++) {
      arr[i] = rnd.Next(100);
    }

    for(int i = 0; i<arr.Length-1; i++) {
      if(arr[i]>arr[i+1]) {
        arr[i] = arr[i] + arr[i+1];
        arr[i+1] = arr[i] - arr[i+1];
        arr[i] = arr[i] - arr[i+1];

        i = -1;
      }
    }
    for(int i = 0; i<arr.Length; i++) {
      Console.Write(arr[i] + " ");
    }


  }
}
